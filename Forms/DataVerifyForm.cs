// 
// Rika
// Copyright (C) 2020 xfixium | xfixium@yahoo.com
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//

using System;
using System.Windows.Forms;

namespace Rika.Forms
{
    public partial class DataVerifyForm : Form
    {
        /// <summary>
        /// Fields
        /// </summary>
        private byte[] _data;

        /// <summary>
        /// Constructors
        /// </summary>
        /// <param name="data">The data to use for verification</param>
        public DataVerifyForm(byte[] data)
        {
            InitializeComponent();
            _data = data;
        }

        /// <summary>
        /// Copy result button click
        /// </summary>
        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtResult.Text);
        }

        /// <summary>
        /// Verify button click
        /// </summary>
        private void btnVerify_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            int from = (int)numFrom.Value;
            int to = (int)numTo.Value;
            int length = to - from;
            byte[] range = GetBytes(from, length, _data);
            try { byte[] result = Nemesis.Decompress(range); txtResult.Text = "Nemesis (" + length + " bytes)"; return; } catch { }
            try  { byte[] result = Enigma.Decompress(range, Endianness.BigEndian); txtResult.Text = "Enigma (" + length + " bytes)"; return; } catch {  }
            try { byte[] result = Kosinski.Decompress(range); txtResult.Text = "Kosinski (" + length + " bytes)"; return; } catch { }
            txtResult.Text = "Not Compressed (" + length + " bytes)";
        }

        /// <summary>
        /// Reads a chunk of bytes
        /// </summary>
        /// <param name="index">The starting point to read bytes</param>
        /// <param name="length">The amount of bytes to read</param>
        /// <param name="data">The data to read from</param>
        /// <returns>The read byte chunk</returns>
        private byte[] GetBytes(int index, int length, byte[] data)
        {
            byte[] bytes = new byte[length];
            for (int i = 0; i < length; i++)
                bytes[i] = data[index + i];
            return bytes;
        }
    }
}
