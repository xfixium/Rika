using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Rika
{
    public static class Nemesis
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

        private static byte[,] linearCoeffs2 = new byte[2, 2] {
            { 3, 0 },
            { 1, 1 } };

        private static byte[,] linearCoeffs3 = new byte[4, 3] {
            { 4, 0, 0 },
            { 2, 1, 0 },
            { 1, 0, 1 },
            { 0, 2, 0 }};

        private static byte[,] linearCoeffs4 = new byte[6, 4] {
            { 5, 0, 0, 0 },
            { 3, 1, 0, 0 },
            { 2, 0, 1, 0 },
            { 1, 2, 0, 0 },
            { 1, 0, 0, 1 },
            { 0, 1, 1, 0 } };

        private static byte[,] linearCoeffs5 = new byte[10, 5] {
            { 6, 0, 0, 0, 0 },
            { 4, 1, 0, 0, 0 },
            { 3, 0, 1, 0, 0 },
            { 2, 2, 0, 0, 0 },
            { 2, 0, 0, 1, 0 },
            { 1, 1, 1, 0, 0 },
            { 1, 0, 0, 0, 1 },
            { 0, 3, 0, 0, 0 },
            { 0, 1, 0, 1, 0 },
            { 0, 0, 2, 0, 0 } };

        private static byte[,] linearCoeffs6 = new byte[14, 6] {
            { 7, 0, 0, 0, 0, 0 },
            { 5, 1, 0, 0, 0, 0 },
            { 4, 0, 1, 0, 0, 0 },
            { 3, 2, 0, 0, 0, 0 },
            { 3, 0, 0, 1, 0, 0 },
            { 2, 1, 1, 0, 0, 0 },
            { 2, 0, 0, 0, 1, 0 },
            { 1, 3, 0, 0, 0, 0 },
            { 1, 1, 0, 1, 0, 0 },
            { 1, 0, 2, 0, 0, 0 },
            { 1, 0, 0, 0, 0, 1 },
            { 0, 2, 1, 0, 0, 0 },
            { 0, 1, 0, 0, 1, 0 },
            { 0, 0, 1, 1, 0, 0 } };

        private static byte[,] linearCoeffs7 = new byte[21, 7] {
            { 8, 0, 0, 0, 0, 0, 0 },
            { 6, 1, 0, 0, 0, 0, 0 },
            { 5, 0, 1, 0, 0, 0, 0 },
            { 4, 2, 0, 0, 0, 0, 0 },
            { 4, 0, 0, 1, 0, 0, 0 },
            { 3, 1, 1, 0, 0, 0, 0 },
            { 3, 0, 0, 0, 1, 0, 0 },
            { 2, 3, 0, 0, 0, 0, 0 },
            { 2, 1, 0, 1, 0, 0, 0 },
            { 2, 0, 2, 0, 0, 0, 0 },
            { 2, 0, 0, 0, 0, 1, 0 },
            { 1, 2, 1, 0, 0, 0, 0 },
            { 1, 1, 0, 0, 1, 0, 0 },
            { 1, 0, 1, 1, 0, 0, 0 },
            { 1, 0, 0, 0, 0, 0, 1 },
            { 0, 4, 0, 0, 0, 0, 0 },
            { 0, 2, 0, 1, 0, 0, 0 },
            { 0, 1, 2, 0, 0, 0, 0 },
            { 0, 1, 0, 0, 0, 1, 0 },
            { 0, 0, 1, 0, 1, 0, 0 },
            { 0, 0, 0, 2, 0, 0, 0 } };

        private static byte[][,] linearCoeffs = new byte[][,] { linearCoeffs2, linearCoeffs3, linearCoeffs4, linearCoeffs5, linearCoeffs6, linearCoeffs7 };

        private static void Decode(Stream input, Stream output)
        {
            DecodingCodeTreeNode codeTree = new DecodingCodeTreeNode();
            ushort numberOfTiles = BigEndian.Read2(input);
            bool xorOutput = (numberOfTiles & 0x8000) != 0;
            numberOfTiles &= 0x7fff;
            DecodeHeader(input, output, codeTree);
            DecodeInternal(input, output, codeTree, numberOfTiles, xorOutput);
        }

        private static void DecodeHeader(Stream input, Stream output, DecodingCodeTreeNode codeTree)
        {
            byte outputValue = 0;
            byte inputValue;

            // Loop until a byte with value 0xFF is encountered
            while ((inputValue = NeutralEndian.Read1(input)) != 0xFF)
            {
                if ((inputValue & 0x80) != 0)
                {
                    outputValue = (byte)(inputValue & 0xF);
                    inputValue = NeutralEndian.Read1(input);
                }

                codeTree.SetCode(
                    NeutralEndian.Read1(input),
                    inputValue & 0xF,
                    new NibbleRun(outputValue, (byte)(((inputValue & 0x70) >> 4) + 1)));
            }

            // Store a special nibble run for inline RLE sequences (code = 0b111111, length = 6)
            // Length = 0xFF in the nibble run is just a marker value that will be handled specially in DecodeInternal
            codeTree.SetCode(0x3F, 6, new NibbleRun(0, 0xFF));
        }

        private static void DecodeInternal(Stream input, Stream output, DecodingCodeTreeNode codeTree, ushort numberOfTiles, bool xorOutput)
        {
            UInt8_E_L_InputBitStream inputBits = new UInt8_E_L_InputBitStream(input);
            UInt8_E_L_OutputBitStream outputBits;
            XorStream xorStream = null;
            try
            {
                if (xorOutput)
                {
                    xorStream = new XorStream(output);
                    outputBits = new UInt8_E_L_OutputBitStream(xorStream);
                }
                else
                {
                    outputBits = new UInt8_E_L_OutputBitStream(output);
                }

                // The output is: number of tiles * 0x20 (1 << 5) bytes per tile * 8 (1 << 3) bits per byte
                int outputSize = numberOfTiles << 8; // in bits
                int bitsWritten = 0;

                DecodingCodeTreeNode currentNode = codeTree;
                while (bitsWritten < outputSize)
                {
                    NibbleRun nibbleRun = currentNode.NibbleRun;
                    if (nibbleRun.Count == 0xFF)
                    {
                        // Bit pattern 0b111111; inline RLE.
                        // First 3 bits are repetition count, followed by the inlined nibble.
                        byte count = (byte)(inputBits.Read(3) + 1);
                        byte nibble = inputBits.Read(4);
                        DecodeNibbleRun(inputBits, outputBits, count, nibble, ref bitsWritten);
                        currentNode = codeTree;
                    }
                    else if (nibbleRun.Count != 0)
                    {
                        // Output the encoded nibble run
                        DecodeNibbleRun(inputBits, outputBits, nibbleRun.Count, nibbleRun.Nibble, ref bitsWritten);
                        currentNode = codeTree;
                    }
                    else
                    {
                        // Read the next bit and go down one level in the tree
                        currentNode = currentNode[inputBits.Get()];
                        if (currentNode == null)
                        {
                            throw new Exception("InvalidCode");
                        }
                    }
                }

                outputBits.Flush(false);
            }
            finally
            {
                if (xorStream != null)
                {
                    xorStream.Dispose();
                }
            }
        }

        private static void DecodeNibbleRun(UInt8_E_L_InputBitStream inputBits, UInt8_E_L_OutputBitStream outputBits, byte count, byte nibble, ref int bitsWritten)
        {
            bitsWritten += count * 4;

            // Write single nibble, if needed
            if ((count & 1) != 0)
            {
                outputBits.Write(nibble, 4);
            }

            // Write pairs of nibbles
            count >>= 1;
            nibble |= (byte)(nibble << 4);
            while (count-- != 0)
            {
                outputBits.Write(nibble, 8);
            }
        }

        private static IEnumerator<byte> Unpacked(Stream stream)
        {
            int b;
            while ((b = stream.ReadByte()) != -1)
            {
                yield return (byte)((b & 0xf0) >> 4);
                yield return (byte)(b & 0xf);
            }

            yield return 0xff;
        }

        private struct NibbleRun : IComparable<NibbleRun>
        {
            public byte Nibble;
            public byte Count;

            public NibbleRun(byte nibble, byte count)
                : this()
            {
                this.Nibble = nibble;
                this.Count = count;
            }

            public override string ToString()
            {
                return this.Count.ToString() + " × " + this.Nibble.ToString("X");
            }

            public int CompareTo(NibbleRun other)
            {
                int comp = this.Nibble.CompareTo(other.Nibble);
                if (comp == 0)
                {
                    comp = this.Count.CompareTo(other.Count);
                }

                return comp;
            }
        }

        private struct SizeMapItem : IComparable<SizeMapItem>
        {
            public SizeMapItem(long codeSize, long frequency, NibbleRun nibbleRun)
                : this()
            {
                this.CodeSize = codeSize;
                this.Frequency = frequency;
                this.NibbleRun = nibbleRun;
            }

            public long CodeSize { get; private set; }

            public long Frequency { get; private set; }

            public NibbleRun NibbleRun { get; private set; }

            public int CompareTo(SizeMapItem other)
            {
                int comp = this.CodeSize.CompareTo(other.CodeSize);
                if (comp == 0)
                {
                    comp = this.Frequency.CompareTo(other.Frequency);
                    if (comp == 0)
                    {
                        comp = this.NibbleRun.CompareTo(other.NibbleRun);
                    }
                }

                return comp;
            }
        }

        private sealed class EncodingCodeTreeNode : IComparable<EncodingCodeTreeNode>
        {
            private EncodingCodeTreeNode clear;
            private EncodingCodeTreeNode set;
            private long weight;
            private NibbleRun nibbleRun;

            public EncodingCodeTreeNode(NibbleRun nibbleRun, long weight)
            {
                this.nibbleRun = nibbleRun;
                this.weight = weight;
            }

            public EncodingCodeTreeNode(EncodingCodeTreeNode clear, EncodingCodeTreeNode set)
            {
                this.clear = clear;
                this.set = set;
                this.weight = clear.weight + set.weight;
            }

            public int CompareTo(EncodingCodeTreeNode other)
            {
                return other.weight.CompareTo(this.weight);
            }

            public void Traverse(SortedList<NibbleRun, long> sizeMap)
            {
                if (this.clear == null && this.set == null)
                {
                    long count;
                    sizeMap.TryGetValue(this.nibbleRun, out count);
                    sizeMap[this.nibbleRun] = count + 1;
                }
                else
                {
                    if (this.clear != null)
                    {
                        this.clear.Traverse(sizeMap);
                    }

                    if (this.set != null)
                    {
                        this.set.Traverse(sizeMap);
                    }
                }
            }
        }

        private sealed class DecodingCodeTreeNode
        {
            private DecodingCodeTreeNode clear;
            private DecodingCodeTreeNode set;
            private NibbleRun nibbleRun;

            public void SetCode(byte code, int length, NibbleRun nibbleRun)
            {
                if (length == 0)
                {
                    if (this.clear != null || this.set != null)
                    {
                        throw new Exception("CodeAlreadyUsedAsPrefix");
                    }

                    this.nibbleRun = nibbleRun;
                }
                else
                {
                    if (this.nibbleRun.Count != 0)
                    {
                        throw new Exception("PrefixAlreadyUsedAsCode");
                    }

                    --length;
                    if ((code & (1 << length)) == 0)
                    {
                        if (this.clear == null)
                        {
                            this.clear = new DecodingCodeTreeNode();
                        }

                        this.clear.SetCode(code, length, nibbleRun);
                    }
                    else
                    {
                        if (this.set == null)
                        {
                            this.set = new DecodingCodeTreeNode();
                        }

                        this.set.SetCode((byte)(code & ((1 << length) - 1)), length, nibbleRun);
                    }
                }
            }

            public DecodingCodeTreeNode this[bool side]
            {
                get
                {
                    return side ? this.set : this.clear;
                }
            }

            public NibbleRun NibbleRun
            {
                get
                {
                    return this.nibbleRun;
                }
            }
        }

        private sealed class MultiSet<T> : IEnumerable<T>
        {
            private SortedList<T, long> set;

            public MultiSet()
            {
                this.set = new SortedList<T, long>();
            }

            public void Add(T value)
            {
                long count;
                this.set.TryGetValue(value, out count);
                this.set[value] = count + 1;
            }

            public long Count(T value)
            {
                long count;
                this.set.TryGetValue(value, out count);
                return count;
            }

            public IEnumerator<T> GetEnumerator()
            {
                foreach (var item in this.set)
                {
                    for (long i = 0; i < item.Value; i++)
                    {
                        yield return item.Key;
                    }
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return this.GetEnumerator();
            }
        }

        private sealed class XorStream : Stream
        {
            private static string TypeName = typeof(XorStream).FullName;

            private Stream stream;
            private int subPosition; // 0-3
            private byte[] bytes;

            public XorStream(Stream stream)
            {
                if (stream == null)
                {
                    throw new ArgumentNullException("stream");
                }

                this.stream = stream;
                this.bytes = new byte[4];
            }

            public override bool CanRead
            {
                get { throw new System.NotImplementedException(); }
            }

            public override bool CanSeek
            {
                get { return false; }
            }

            public override bool CanWrite
            {
                get { return true; }
            }

            public override void Flush()
            {
                if (this.stream == null)
                {
                    throw new ObjectDisposedException(TypeName);
                }

                this.stream.Flush();
            }

            public override long Length
            {
                get
                {
                    if (this.stream == null)
                    {
                        throw new ObjectDisposedException(TypeName);
                    }

                    return this.stream.Length;
                }
            }

            public override long Position
            {
                get
                {
                    if (this.stream == null)
                    {
                        throw new ObjectDisposedException(TypeName);
                    }

                    return this.stream.Position;
                }
                set
                {
                    throw new NotSupportedException();
                }
            }

            public override int Read(byte[] buffer, int offset, int count)
            {
                if (buffer == null)
                {
                    throw new ArgumentNullException("buffer");
                }

                if (offset < 0)
                {
                    throw new ArgumentException();
                }

                if (count < 0)
                {
                    throw new ArgumentException();
                }

                if (offset > buffer.Length)
                {
                    throw new ArgumentException();
                }

                if (offset + count > buffer.Length)
                {
                    throw new ArgumentException();
                }

                if (this.stream == null)
                {
                    throw new ObjectDisposedException(TypeName);
                }

                int readBytes = this.stream.Read(buffer, offset, count);
                for (int i = 0; i < readBytes; i++)
                {
                    byte b = buffer[offset + i];
                    buffer[offset + i] ^= bytes[this.subPosition];
                    bytes[this.subPosition] = b;
                    ++this.subPosition;
                    this.subPosition &= 3;
                }

                return readBytes;
            }

            public override long Seek(long offset, SeekOrigin origin)
            {
                throw new NotSupportedException();
            }

            public override void SetLength(long value)
            {
                throw new NotSupportedException();
            }

            public override void Write(byte[] buffer, int offset, int count)
            {
                if (buffer == null)
                {
                    throw new ArgumentNullException("buffer");
                }

                if (offset < 0)
                {
                    throw new ArgumentException();
                }

                if (count < 0)
                {
                    throw new ArgumentException();
                }

                if (offset > buffer.Length)
                {
                    throw new ArgumentException();
                }

                if (offset + count > buffer.Length)
                {
                    throw new ArgumentException();
                }

                if (this.stream == null)
                {
                    throw new ObjectDisposedException(TypeName);
                }

                if (count == 0)
                {
                    return;
                }

                byte[] xorBuffer = new byte[count];
                for (int i = 0; i < count; i++)
                {
                    bytes[this.subPosition] ^= buffer[i];
                    xorBuffer[i] = bytes[this.subPosition];
                    ++this.subPosition;
                    this.subPosition &= 3;
                }

                this.stream.Write(xorBuffer, 0, count);
            }
        }
    }
}
