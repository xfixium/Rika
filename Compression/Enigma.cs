using System;
using System.IO;
using System.Reflection;
using System.Globalization;
using System.Reflection.Emit;

namespace Rika
{
    public static class Enigma
    {
        // Cached delegates
        private static readonly Action<Stream, ushort> Write2BE = BigEndian.Write2;
        private static readonly Action<Stream, ushort> Write2LE = LittleEndian.Write2;
        private static readonly MethodInfo UShortInputBitStreamGet = typeof(InputBitStream<ushort>).GetMethod("Get");
        private static readonly MethodInfo UShortOutputBitStreamPut = typeof(OutputBitStream<ushort>).GetMethod("Put");
        private static readonly Func<InputBitStream<ushort>, ushort>[] BitfieldReaders =
            new Func<InputBitStream<ushort>, ushort>[0x20];
        private static readonly Action<OutputBitStream<ushort>, ushort>[] BitfieldWriters =
            new Action<OutputBitStream<ushort>, ushort>[0x20];

        public static byte[] Decompress(string sourceFilePath, Endianness endianness)
        {
            ValidateEndianness(endianness);
            using (FileStream input = File.OpenRead(sourceFilePath))
            {
                using (MemoryStream output = new MemoryStream())
                {
                    Decompress(input, output, endianness);
                    return output.ToArray();
                }
            }
        }

        public static void Decompress(byte[] sourceData, string destinationFilePath, Endianness endianness)
        {
            ValidateEndianness(endianness);
            using (MemoryStream input = new MemoryStream(sourceData))
            {
                using (FileStream output = File.Create(destinationFilePath))
                {
                    Decompress(input, output, endianness);
                }
            }
        }

        public static void Decompress(string sourceFilePath, string destinationFilePath, Endianness endianness)
        {
            ValidateEndianness(endianness);
            using (FileStream input = File.OpenRead(sourceFilePath))
            {
                using (FileStream output = File.Create(destinationFilePath))
                {
                    Decompress(input, output, endianness);
                }
            }
        }

        public static byte[] Decompress(byte[] sourceData, Endianness endianness)
        {
            ValidateEndianness(endianness);
            using (MemoryStream input = new MemoryStream(sourceData))
            {
                using (MemoryStream output = new MemoryStream())
                {
                    Decompress(input, output, endianness);
                    return output.ToArray();
                }
            }
        }

        public static void Decompress(Stream input, Stream output, Endianness endianness)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            if (output == null)
            {
                throw new ArgumentNullException("output");
            }

            ValidateEndianness(endianness);
            Decode(input, output, endianness);
        }

        private static void ValidateEndianness(Endianness endianness)
        {
            if (endianness != Endianness.BigEndian && endianness != Endianness.LittleEndian)
            {
                throw new ArgumentOutOfRangeException("endianness");
            }
        }

        private static void Decode(Stream input, Stream output, Endianness endianness)
        {
            using (PaddedStream paddedInput = new PaddedStream(input, 2, PaddedStreamMode.Read))
            {
                byte packetLength = NeutralEndian.Read1(paddedInput);
                var readBitfield = GetBitfieldReader(NeutralEndian.Read1(paddedInput));

                ushort incrementingValue;
                ushort commonValue;
                InputBitStream<ushort> bitStream;
                Action<Stream, ushort> write2;

                if (endianness == Endianness.BigEndian)
                {
                    incrementingValue = BigEndian.Read2(paddedInput);
                    commonValue = BigEndian.Read2(paddedInput);
                    bitStream = new UInt16BE_E_L_InputBitStream(paddedInput);
                    write2 = Write2BE;
                }
                else
                {
                    incrementingValue = LittleEndian.Read2(paddedInput);
                    commonValue = LittleEndian.Read2(paddedInput);
                    bitStream = new UInt16LE_E_L_InputBitStream(paddedInput);
                    write2 = Write2LE;
                }

                // Loop until the end-of-data marker is found (if it is not found before the end of the stream, UInt8InputBitStream
                // will throw an exception)
                for (; ; )
                {
                    if (bitStream.Get())
                    {
                        int mode = bitStream.Read(2);
                        int count = bitStream.Read(4);
                        switch (mode)
                        {
                            case 0:
                            case 1:
                                {
                                    ushort flags = readBitfield(bitStream);
                                    ushort outv = (ushort)(bitStream.Read(packetLength) | flags);

                                    do
                                    {
                                        write2(output, outv);
                                        outv += (ushort)mode;
                                    } while (--count >= 0);
                                }

                                break;

                            case 2:
                                mode = -1;
                                goto case 0;

                            case 3:
                                {
                                    // End of compressed data
                                    if (count == 0xf)
                                    {
                                        return;
                                    }

                                    do
                                    {
                                        ushort flags = readBitfield(bitStream);
                                        ushort outv = bitStream.Read(packetLength);
                                        write2(output, (ushort)(outv | flags));
                                    } while (--count >= 0);
                                }

                                break;
                        }
                    }
                    else
                    {
                        bool mode = bitStream.Get();
                        int count = bitStream.Read(4);
                        if (mode)
                        {
                            do
                            {
                                write2(output, commonValue);
                            } while (--count >= 0);
                        }
                        else
                        {
                            do
                            {
                                write2(output, incrementingValue++);
                            } while (--count >= 0);
                        }
                    }
                }
            }
        }

        private static Func<InputBitStream<ushort>, ushort> GetBitfieldReader(byte enabledFlags)
        {
            if (enabledFlags > 0x1f)
            {
                throw new ArgumentOutOfRangeException("enabledFlags");
            }

            // Lazily initialize the bitfield readers
            if (BitfieldReaders[enabledFlags] == null)
            {
                // Lock the array for thread safety
                lock (BitfieldReaders)
                {
                    // If the bitfield reader has been compiled while we were waiting for the lock, don't initialize it again!
                    if (BitfieldReaders[enabledFlags] == null)
                    {
                        DynamicMethod method = new DynamicMethod(
                            string.Format(CultureInfo.InvariantCulture, "ReadBitfield<{0}>", enabledFlags),
                            typeof(ushort),
                            new Type[] { typeof(InputBitStream<ushort>) });
                        method.DefineParameter(0, ParameterAttributes.None, "bitStream");
                        ILGenerator ilg = method.GetILGenerator();
                        if (enabledFlags == 0)
                        {
                            ilg.Emit(OpCodes.Ldc_I4_0);
                        }
                        else
                        {
                            // Keep track of how many bits are set, so we can generate the correct number of 'or' instructions
                            int bits = 0;

                            // Loop through the bits
                            for (int i = 4; i >= 0; i--)
                            {
                                // Test bits 4 to 0
                                if ((enabledFlags & (1 << i)) != 0)
                                {
                                    ++bits;

                                    // Call InputBitStream<ushort>.Get()
                                    ilg.Emit(OpCodes.Ldarg_0); // bitStream
                                    ilg.Emit(OpCodes.Callvirt, UShortInputBitStreamGet);

                                    // Shift the value by 15 to 11, depending on the bit being tested
                                    ilg.Emit(OpCodes.Ldc_I4_S, 11 + i);
                                    ilg.Emit(OpCodes.Shl);
                                }
                            }

                            // Decrement by one to keep one value on the stack
                            // For example, if enabledFlags is 0x1f, there will be 5 values on the stack. We want to end up with
                            // one value on the stack, so we must emit 4 'or' instructions.
                            --bits;
                            for (int i = 0; i < bits; i++)
                            {
                                // Emit 'or' instructions
                                ilg.Emit(OpCodes.Or);
                            }
                        }

                        ilg.Emit(OpCodes.Ret);

                        BitfieldReaders[enabledFlags] = (Func<InputBitStream<ushort>, ushort>)method.CreateDelegate(
                            typeof(Func<InputBitStream<ushort>, ushort>));
                    }
                }
            }

            return BitfieldReaders[enabledFlags];
        }
    }
}
