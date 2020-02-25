using System;
using System.IO;

namespace Rika
{
    public enum PaddedStreamMode
    {
        Read,
        Write
    }

    public enum Endianness
    {
        BigEndian,
        LittleEndian
    }

    public static class BigEndian
    {
        public static ushort Read2(Stream stream)
        {
            byte[] bytes = new byte[2];
            if (stream.Read(bytes, 0, 2) != 2)
            {
                throw new EndOfStreamException();
            }

            return (ushort)((bytes[0] << 8) | bytes[1]);
        }

        public static void Write2(Stream stream, ushort value)
        {
            byte[] bytes = new byte[] { (byte)(value >> 8), (byte)(value & 0xFF) };
            stream.Write(bytes, 0, 2);
        }
    }

    public static class LittleEndian
    {
        public static ushort Read2(Stream stream)
        {
            byte[] bytes = new byte[2];
            if (stream.Read(bytes, 0, 2) != 2)
            {
                throw new EndOfStreamException();
            }

            return (ushort)((bytes[1] << 8) | bytes[0]);
        }

        public static void Write2(Stream stream, ushort value)
        {
            byte[] bytes = new byte[] { (byte)(value & 0xFF), (byte)(value >> 8) };
            stream.Write(bytes, 0, 2);
        }
    }

    public static class NeutralEndian
    {
        public static byte Read1(Stream stream)
        {
            int value = stream.ReadByte();
            if (value == -1)
            {
                throw new EndOfStreamException();
            }

            return (byte)value;
        }

        public static void Write1(Stream stream, byte value)
        {
            stream.WriteByte(value);
        }
    }

    public abstract class InputBitStream
    {
        public abstract bool Get();

        public abstract bool Pop();
    }

    public abstract class InputBitStream<T> : InputBitStream where T : struct
    {
        public abstract T Read(int count);
    }

    public sealed class UInt16LE_E_L_InputBitStream : InputBitStream<ushort>
    {
        private Stream stream;
        private int remainingBits;
        private ushort byteBuffer;

        public UInt16LE_E_L_InputBitStream(Stream stream)
        {
            if (stream == null)
            {
                throw new ArgumentNullException("stream");
            }

            this.stream = stream;

            this.remainingBits = 16;
            this.byteBuffer = LittleEndian.Read2(stream);
        }

        public override bool Get()
        {
            this.CheckBuffer();
            --this.remainingBits;
            ushort bit = (ushort)(this.byteBuffer & (1 << this.remainingBits));
            this.byteBuffer ^= bit; // clear the bit
            return bit != 0;
        }

        public override bool Pop()
        {
            --this.remainingBits;
            ushort bit = (ushort)(this.byteBuffer & 1);
            this.byteBuffer >>= 1;

            this.CheckBuffer();

            return bit != 0;
        }

        public override ushort Read(int count)
        {
            this.CheckBuffer();
            if (this.remainingBits < count)
            {
                int delta = count - this.remainingBits;
                ushort lowBits = (ushort)(this.byteBuffer << delta);
                this.byteBuffer = LittleEndian.Read2(stream);
                this.remainingBits = 16 - delta;
                ushort highBits = (ushort)(this.byteBuffer >> this.remainingBits);
                this.byteBuffer ^= (ushort)(highBits << this.remainingBits);
                return (ushort)(lowBits | highBits);
            }

            this.remainingBits -= count;
            ushort bits = (ushort)(this.byteBuffer >> this.remainingBits);
            this.byteBuffer ^= (ushort)(bits << this.remainingBits);
            return bits;
        }

        private void CheckBuffer()
        {
            if (this.remainingBits == 0)
            {
                this.byteBuffer = LittleEndian.Read2(stream);
                this.remainingBits = 16;
            }
        }
    }


    public sealed class UInt8_E_L_InputBitStream : InputBitStream<byte>
    {
        private Stream stream;
        private int remainingBits;
        private byte byteBuffer;

        public UInt8_E_L_InputBitStream(Stream stream)
        {
            if (stream == null)
            {
                throw new ArgumentNullException("stream");
            }

            this.stream = stream;

            this.remainingBits = 8;
            this.byteBuffer = NeutralEndian.Read1(stream);
        }

        public override bool Get()
        {
            this.CheckBuffer();
            --this.remainingBits;
            byte bit = (byte)(this.byteBuffer & (1 << this.remainingBits));
            this.byteBuffer ^= bit; // clear the bit
            return bit != 0;
        }

        public override bool Pop()
        {
            --this.remainingBits;
            byte bit = (byte)(this.byteBuffer & 1);
            this.byteBuffer >>= 1;

            this.CheckBuffer();

            return bit != 0;
        }

        public override byte Read(int count)
        {
            this.CheckBuffer();
            if (this.remainingBits < count)
            {
                int delta = count - this.remainingBits;
                byte lowBits = (byte)(this.byteBuffer << delta);
                this.byteBuffer = NeutralEndian.Read1(stream);
                this.remainingBits = 8 - delta;
                ushort highBits = (byte)(this.byteBuffer >> this.remainingBits);
                this.byteBuffer ^= (byte)(highBits << this.remainingBits);
                return (byte)(lowBits | highBits);
            }

            this.remainingBits -= count;
            byte bits = (byte)(this.byteBuffer >> this.remainingBits);
            this.byteBuffer ^= (byte)(bits << this.remainingBits);
            return bits;
        }

        private void CheckBuffer()
        {
            if (this.remainingBits == 0)
            {
                this.byteBuffer = NeutralEndian.Read1(stream);
                this.remainingBits = 8;
            }
        }
    }

    public sealed class UInt8_NE_H_InputBitStream : InputBitStream<byte>
    {
        private Stream stream;
        private int remainingBits;
        private byte byteBuffer;

        public UInt8_NE_H_InputBitStream(Stream stream)
        {
            if (stream == null)
            {
                throw new ArgumentNullException("stream");
            }

            this.stream = stream;

            this.remainingBits = 0;
        }

        public override bool Get()
        {
            this.CheckBuffer();
            --this.remainingBits;
            byte bit = (byte)(this.byteBuffer & (0x80 >> this.remainingBits));
            this.byteBuffer ^= bit; // clear the bit
            return bit != 0;
        }

        public override bool Pop()
        {
            this.CheckBuffer();

            --this.remainingBits;
            byte bit = (byte)(this.byteBuffer & 0x80);
            this.byteBuffer <<= 1;

            return bit != 0;
        }

        public override byte Read(int count)
        {
            this.CheckBuffer();
            if (this.remainingBits < count)
            {
                int delta = count - this.remainingBits;
                byte lowBits = (byte)(this.byteBuffer >> delta);
                this.byteBuffer = NeutralEndian.Read1(stream);
                this.remainingBits = 8 - delta;
                ushort highBits = (byte)(this.byteBuffer << this.remainingBits);
                this.byteBuffer ^= (byte)(highBits >> this.remainingBits);
                return (byte)(lowBits | highBits);
            }

            this.remainingBits -= count;
            byte bits = (byte)(this.byteBuffer << this.remainingBits);
            this.byteBuffer ^= (byte)(bits >> this.remainingBits);
            return bits;
        }

        private void CheckBuffer()
        {
            if (this.remainingBits == 0)
            {
                this.byteBuffer = NeutralEndian.Read1(stream);
                this.remainingBits = 8;
            }
        }
    }

    public abstract class OutputBitStream
    {
        public abstract bool Put(bool bit);

        public abstract bool Push(bool bit);

        public abstract bool Flush(bool unchanged);
    }

    public abstract class OutputBitStream<T> : OutputBitStream where T : struct
    {
        public abstract bool Write(T data, int size);
    }

    public sealed class UInt16LE_E_L_OutputBitStream : OutputBitStream<ushort>
    {
        private Stream stream;
        private int waitingBits;
        private ushort byteBuffer;

        public UInt16LE_E_L_OutputBitStream(Stream stream)
        {
            if (stream == null)
            {
                throw new ArgumentNullException("stream");
            }

            this.stream = stream;
        }

        public bool HasWaitingBits
        {
            get
            {
                return this.waitingBits != 0;
            }
        }

        public override bool Put(bool bit)
        {
            this.byteBuffer <<= 1;
            this.byteBuffer |= Convert.ToUInt16(bit);
            if (++this.waitingBits >= 16)
            {
                LittleEndian.Write2(this.stream, this.byteBuffer);
                this.waitingBits = 0;
                this.byteBuffer = 0;
                return true;
            }

            return false;
        }

        public override bool Push(bool bit)
        {
            this.byteBuffer |= (ushort)(Convert.ToUInt16(bit) << this.waitingBits);
            if (++this.waitingBits >= 16)
            {
                LittleEndian.Write2(this.stream, this.byteBuffer);
                this.waitingBits = 0;
                this.byteBuffer = 0;
                return true;
            }

            return false;
        }

        public override bool Flush(bool unchanged)
        {
            if (this.waitingBits != 0)
            {
                if (!unchanged)
                {
                    this.byteBuffer <<= 16 - this.waitingBits;
                }

                LittleEndian.Write2(this.stream, this.byteBuffer);
                this.waitingBits = 0;
                return true;
            }

            return false;
        }

        public override bool Write(ushort data, int size)
        {
            if (this.waitingBits + size >= 16)
            {
                int delta = 16 - this.waitingBits;
                this.waitingBits = (this.waitingBits + size) % 16;
                ushort bits = (ushort)((this.byteBuffer << delta) | (data >> this.waitingBits));
                LittleEndian.Write2(this.stream, bits);
                this.byteBuffer = data;
                return true;
            }

            this.byteBuffer <<= size;
            this.byteBuffer |= data;
            this.waitingBits += size;
            return false;
        }
    }

    public sealed class UInt8_E_L_OutputBitStream : OutputBitStream<byte>
    {
        private Stream stream;
        private int waitingBits;
        private byte byteBuffer;

        public UInt8_E_L_OutputBitStream(Stream stream)
        {
            if (stream == null)
            {
                throw new ArgumentNullException("stream");
            }

            this.stream = stream;
        }

        public override bool Put(bool bit)
        {
            this.byteBuffer <<= 1;
            this.byteBuffer |= Convert.ToByte(bit);
            if (++this.waitingBits >= 8)
            {
                NeutralEndian.Write1(this.stream, this.byteBuffer);
                this.waitingBits = 0;
                this.byteBuffer = 0;
                return true;
            }

            return false;
        }

        public override bool Push(bool bit)
        {
            this.byteBuffer |= (byte)(Convert.ToByte(bit) << this.waitingBits);
            if (++this.waitingBits >= 8)
            {
                NeutralEndian.Write1(this.stream, this.byteBuffer);
                this.waitingBits = 0;
                this.byteBuffer = 0;
                return true;
            }

            return false;
        }

        public override bool Flush(bool unchanged)
        {
            if (this.waitingBits != 0)
            {
                if (!unchanged)
                {
                    this.byteBuffer <<= 8 - this.waitingBits;
                }

                NeutralEndian.Write1(this.stream, this.byteBuffer);
                this.waitingBits = 0;
                return true;
            }

            return false;
        }

        public override bool Write(byte data, int size)
        {
            if (this.waitingBits + size >= 8)
            {
                int delta = 8 - this.waitingBits;
                this.waitingBits = (this.waitingBits + size) % 8;
                byte bits = (byte)((this.byteBuffer << delta) | (data >> this.waitingBits));
                NeutralEndian.Write1(this.stream, bits);
                this.byteBuffer = data;
                return true;
            }

            this.byteBuffer <<= size;
            this.byteBuffer |= data;
            this.waitingBits += size;
            return false;
        }
    }

    public sealed class UInt16BE_E_L_InputBitStream : InputBitStream<ushort>
    {
        private Stream stream;
        private int remainingBits;
        private ushort byteBuffer;

        public UInt16BE_E_L_InputBitStream(Stream stream)
        {
            if (stream == null)
            {
                throw new ArgumentNullException("stream");
            }

            this.stream = stream;

            this.remainingBits = 16;
            this.byteBuffer = BigEndian.Read2(stream);
        }

        public override bool Get()
        {
            this.CheckBuffer();
            --this.remainingBits;
            ushort bit = (ushort)(this.byteBuffer & (1 << this.remainingBits));
            this.byteBuffer ^= bit; // clear the bit
            return bit != 0;
        }

        public override bool Pop()
        {
            --this.remainingBits;
            ushort bit;

            bit = (ushort)(this.byteBuffer & 1);
            this.byteBuffer >>= 1;

            this.CheckBuffer();

            return bit != 0;
        }

        public override ushort Read(int count)
        {
            this.CheckBuffer();
            if (this.remainingBits < count)
            {
                int delta = count - this.remainingBits;
                ushort lowBits = (ushort)(this.byteBuffer << delta);
                this.byteBuffer = BigEndian.Read2(stream);
                this.remainingBits = 16 - delta;
                ushort highBits = (ushort)(this.byteBuffer >> this.remainingBits);
                this.byteBuffer ^= (ushort)(highBits << this.remainingBits);
                return (ushort)(lowBits | highBits);
            }

            this.remainingBits -= count;
            ushort bits = (ushort)(this.byteBuffer >> this.remainingBits);
            this.byteBuffer ^= (ushort)(bits << this.remainingBits);
            return bits;
        }

        private void CheckBuffer()
        {
            if (this.remainingBits == 0)
            {
                this.byteBuffer = BigEndian.Read2(stream);
                this.remainingBits = 16;
            }
        }
    }

    public sealed class UInt8_NE_L_InputBitStream : InputBitStream<byte>
    {
        private Stream stream;
        private int remainingBits;
        private byte byteBuffer;

        public UInt8_NE_L_InputBitStream(Stream stream)
        {
            if (stream == null)
            {
                throw new ArgumentNullException("stream");
            }

            this.stream = stream;

            this.remainingBits = 0;
        }

        public override bool Get()
        {
            this.CheckBuffer();
            --this.remainingBits;
            byte bit = (byte)(this.byteBuffer & (1 << this.remainingBits));
            this.byteBuffer ^= bit; // clear the bit
            return bit != 0;
        }

        public override bool Pop()
        {
            this.CheckBuffer();

            --this.remainingBits;
            byte bit = (byte)(this.byteBuffer & 1);
            this.byteBuffer >>= 1;

            return bit != 0;
        }

        public override byte Read(int count)
        {
            this.CheckBuffer();
            if (this.remainingBits < count)
            {
                int delta = count - this.remainingBits;
                byte lowBits = (byte)(this.byteBuffer << delta);
                this.byteBuffer = NeutralEndian.Read1(stream);
                this.remainingBits = 8 - delta;
                ushort highBits = (byte)(this.byteBuffer >> this.remainingBits);
                this.byteBuffer ^= (byte)(highBits << this.remainingBits);
                return (byte)(lowBits | highBits);
            }

            this.remainingBits -= count;
            byte bits = (byte)(this.byteBuffer >> this.remainingBits);
            this.byteBuffer ^= (byte)(bits << this.remainingBits);
            return bits;
        }

        private void CheckBuffer()
        {
            if (this.remainingBits == 0)
            {
                this.byteBuffer = NeutralEndian.Read1(stream);
                this.remainingBits = 8;
            }
        }
    }

    /// <summary>
    /// Wraps a stream and automatically reads or writes null bytes to make the length of the stream a multiple of a specified
    /// alignment value.
    /// </summary>
    public class PaddedStream : Stream
    {
        private static readonly string TypeName = typeof(PaddedStream).FullName;

        private Stream stream;
        private long alignment;
        private long offset;
        private PaddedStreamMode mode;

        /// <summary>
        /// Initializes a new instance of the <see cref="PaddedStream" /> class with the specified underlying stream.
        /// </summary>
        /// <param name="stream">The underlying stream.</param>
        /// <param name="alignment">
        /// Alignment of the stream. The length of the stream will be a multiple of the alignment.
        /// </param>
        /// <param name="mode">Operating mode for the <see cref="PaddedStream"/>.</param>
        public PaddedStream(Stream stream, long alignment, PaddedStreamMode mode)
        {
            if (stream == null)
            {
                throw new ArgumentNullException("stream");
            }

            switch (mode)
            {
                case PaddedStreamMode.Read:
                case PaddedStreamMode.Write:
                    break;

                default:
                    throw new ArgumentOutOfRangeException("mode");
            }

            this.stream = stream;
            this.alignment = alignment;
            this.mode = mode;
        }

        public override bool CanRead
        {
            get
            {
                if (this.stream == null)
                {
                    throw new ObjectDisposedException(TypeName);
                }

                return this.mode == PaddedStreamMode.Read && this.stream.CanRead;
            }
        }

        public override bool CanSeek
        {
            get
            {
                if (this.stream == null)
                {
                    throw new ObjectDisposedException(TypeName);
                }

                return this.stream.CanSeek;
            }
        }

        public override bool CanWrite
        {
            get
            {
                if (this.stream == null)
                {
                    throw new ObjectDisposedException(TypeName);
                }

                return this.mode == PaddedStreamMode.Write && this.stream.CanWrite;
            }
        }

        public override void Flush()
        {
            if (this.stream == null)
            {
                throw new ObjectDisposedException(TypeName);
            }

            if (this.mode != PaddedStreamMode.Write)
            {
                throw new NotSupportedException();
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

                if (this.mode == PaddedStreamMode.Read)
                {
                    return this.AlignedLength(this.stream.Length);
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

                return this.stream.Position + this.offset;
            }
            set
            {
                this.Seek(value, SeekOrigin.Begin);
            }
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            if (this.stream == null)
            {
                throw new ObjectDisposedException(TypeName);
            }

            if (this.mode != PaddedStreamMode.Read)
            {
                throw new NotSupportedException();
            }

            int bytesRead = 0;

            // If this.offset is not zero, we've already read past the end of the underlying stream, so don't bother reading
            // from it.
            if (this.offset == 0)
            {
                bytesRead = this.stream.Read(buffer, offset, count);
            }

            // Write zeroes in the buffer until the requested count is satisfied or until the end of the padded stream.
            while (bytesRead < count && this.Position < this.Length)
            {
                buffer[offset + bytesRead] = 0;
                ++bytesRead;
                ++this.offset;
            }

            return bytesRead;
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            if (this.stream == null)
            {
                throw new ObjectDisposedException(TypeName);
            }

            long position;
            switch (origin)
            {
                case SeekOrigin.Begin:
                    position = this.stream.Seek(offset, SeekOrigin.Begin);
                    this.offset = 0;
                    break;

                case SeekOrigin.Current:
                    position = this.stream.Seek(offset, SeekOrigin.Current);
                    this.offset = 0;
                    break;

                case SeekOrigin.End:
                    position = this.stream.Seek(offset + (this.Length - this.stream.Length), SeekOrigin.End);
                    this.offset = 0;
                    break;

                default:
                    throw new ArgumentOutOfRangeException("origin");
            }

            return position;
        }

        /// <summary>
        /// Sets the length of the underlying stream.
        /// </summary>
        /// <param name="value">New length of the underlying stream.</param>
        /// <exception cref="ObjectDisposedException">The stream has been disposed.</exception>
        /// <exception cref="NotSupportedException">
        /// The stream was not created in <see cref="PaddedStreamMode.Write"/> mode.
        /// </exception>
        public override void SetLength(long value)
        {
            if (this.stream == null)
            {
                throw new ObjectDisposedException(TypeName);
            }

            if (this.mode != PaddedStreamMode.Write)
            {
                throw new NotSupportedException();
            }

            this.stream.SetLength(value);
            this.offset = 0;
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            if (this.stream == null)
            {
                throw new ObjectDisposedException(TypeName);
            }

            if (this.mode != PaddedStreamMode.Write)
            {
                throw new NotSupportedException();
            }

            this.stream.Write(buffer, offset, count);
        }

        /// <summary>
        /// Releases the unmanaged resources used by the <see cref="PaddedStream"/> and optionally releases the managed
        /// resources.
        /// </summary>
        /// <param name="disposing">
        /// <c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.
        /// </param>
        /// <remarks>
        /// If the current <see cref="PaddedStream"/> is in <see cref="PaddedStreamMode.Write"/> mode, the underlying stream's
        /// length will be aligned to the alignment specified in the constructor. The underlying stream is not disposed.
        /// </remarks>
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && this.stream != null && this.mode == PaddedStreamMode.Write)
                {
                    long alignedLength = this.AlignedLength(this.stream.Length);
                    if (alignedLength > this.stream.Length)
                    {
                        // Pad the stream
                        this.stream.SetLength(alignedLength);
                    }
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        /// <summary>
        /// Returns the first integer greater than or equal to <paramref name="length"/> that is a multiple of
        /// <see cref="alignment"/>.
        /// </summary>
        /// <param name="length">Length to align.</param>
        /// <returns>
        /// The first integer greater than or equal to <paramref name="length"/> that is a multiple of <see cref="alignment"/>.
        /// </returns>
        private long AlignedLength(long length)
        {
            long alignmentMinusOne = this.alignment - 1;

            // If this.alignment is a power of two...
            if ((this.alignment & alignmentMinusOne) == 0)
            {
                // ...then we can use a faster algorithm.
                return (length + alignmentMinusOne) & ~alignmentMinusOne;
            }

            return (length + (this.alignment - 1)) / this.alignment * this.alignment;
        }
    }
}
