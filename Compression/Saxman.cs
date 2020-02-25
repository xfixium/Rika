using System;
using System.IO;
using System.Collections.Generic;

namespace Rika
{
    public static class Saxman
    {
        public static byte[] Decompress(string sourceFilePath)
        {
            using (FileStream input = File.OpenRead(sourceFilePath))
            {
                using (MemoryStream output = new MemoryStream())
                {
                    Decompress(input, output);
                    return output.ToArray();
                }
            }
        }

        public static byte[] Decompress(string sourceFilePath, long size)
        {
            using (FileStream input = File.OpenRead(sourceFilePath))
            {
                using (MemoryStream output = new MemoryStream())
                {
                    Decompress(input, output, size);
                    return output.ToArray();
                }
            }
        }

        public static void Decompress(byte[] sourceData, string destinationFilePath)
        {
            using (MemoryStream input = new MemoryStream(sourceData))
            {
                using (FileStream output = File.Create(destinationFilePath))
                {
                    Decompress(input, output);
                }
            }
        }

        public static void Decompress(byte[] sourceData, string destinationFilePath, long size)
        {
            using (MemoryStream input = new MemoryStream(sourceData))
            {
                using (FileStream output = File.Create(destinationFilePath))
                {
                    Decompress(input, output, size);
                }
            }
        }

        public static void Decompress(string sourceFilePath, string destinationFilePath)
        {
            using (FileStream input = File.OpenRead(sourceFilePath))
            {
                using (FileStream output = File.Create(destinationFilePath))
                {
                    Decompress(input, output);
                }
            }
        }

        public static void Decompress(string sourceFilePath, string destinationFilePath, long size)
        {
            using (FileStream input = File.OpenRead(sourceFilePath))
            {
                using (FileStream output = File.Create(destinationFilePath))
                {
                    Decompress(input, output, size);
                }
            }
        }

        public static byte[] Decompress(byte[] sourceData)
        {
            using (MemoryStream input = new MemoryStream(sourceData))
            {
                using (MemoryStream output = new MemoryStream())
                {
                    Decompress(input, output);
                    return output.ToArray();
                }
            }
        }

        public static byte[] Decompress(byte[] sourceData, bool withSize)
        {
            using (MemoryStream input = new MemoryStream(sourceData))
            {
                using (MemoryStream output = new MemoryStream())
                {
                    if (withSize)
                        Decompress(input, output);
                    else
                        Decompress(input, output, sourceData.Length);

                    return output.ToArray();
                }
            }
        }

        public static byte[] Decompress(byte[] sourceData, long size)
        {
            using (MemoryStream input = new MemoryStream(sourceData))
            {
                using (MemoryStream output = new MemoryStream())
                {
                    Decompress(input, output, size);
                    return output.ToArray();
                }
            }
        }

        public static void Decompress(Stream input, Stream output)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            if (output == null)
            {
                throw new ArgumentNullException("output");
            }

            Decode(input, output);
        }

        public static void Decompress(Stream input, Stream output, long size)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            if (output == null)
            {
                throw new ArgumentNullException("output");
            }

            Decode(input, output, size);
        }

        private static void Decode(Stream input, Stream output)
        {
            ushort size = LittleEndian.Read2(input);
            Decode(input, output, size);
        }

        private static void Decode(Stream input, Stream output, long size)
        {
            long end = input.Position + size;
            UInt8_NE_L_InputBitStream bitStream = new UInt8_NE_L_InputBitStream(input);
            List<byte> outputBuffer = new List<byte>();
            while (input.Position < end)
            {
                if (bitStream.Pop())
                {
                    if (input.Position >= end)
                    {
                        break;
                    }

                    outputBuffer.Add(NeutralEndian.Read1(input));
                }
                else
                {
                    if (input.Position >= end)
                    {
                        break;
                    }

                    int offset = NeutralEndian.Read1(input);

                    if (input.Position >= end)
                    {
                        break;
                    }

                    byte count = NeutralEndian.Read1(input);

                    // We've just read 2 bytes: %llllllll %hhhhcccc
                    // offset = %hhhhllllllll + 0x12, count = %cccc + 3
                    offset |= (ushort)((count & 0xF0) << 4);
                    offset += 0x12;
                    offset &= 0xFFF;
                    offset |= (ushort)(outputBuffer.Count & 0xF000);
                    count &= 0xF;
                    count += 3;

                    if (offset >= outputBuffer.Count)
                    {
                        offset -= 0x1000;
                    }

                    outputBuffer.AddRange(new byte[count]);

                    if (offset < 0)
                    {
                        // Zero-fill
                        for (int destinationIndex = outputBuffer.Count - count; destinationIndex < outputBuffer.Count; ++destinationIndex)
                        {
                            outputBuffer[destinationIndex] = 0;
                        }
                    }
                    else
                    {
                        // Dictionary reference
                        if (offset < outputBuffer.Count)
                        {
                            for (int sourceIndex = offset, destinationIndex = outputBuffer.Count - count;
                                destinationIndex < outputBuffer.Count;
                                sourceIndex++, destinationIndex++)
                            {
                                outputBuffer[destinationIndex] = outputBuffer[sourceIndex];
                            }
                        }
                    }
                }
            }

            byte[] bytes = outputBuffer.ToArray();
            output.Write(bytes, 0, bytes.Length);
        }
    }
}
