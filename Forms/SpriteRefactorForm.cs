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
using System.Linq;
using System.Text;
using System.Reflection;
using System.Collections.Generic;
using System.Windows.Forms;
using Rika.Data;

namespace Rika.Forms
{
    public partial class SpriteRefactorForm : Form
    {
        /// <summary>
        /// Constructors
        /// </summary>
        public SpriteRefactorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Results text key down
        /// </summary>
        private void txtResults_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control)
            {
                (sender as TextBox).SelectAll();
                e.Handled = true;
            }
        }

        /// <summary>
        /// Refactor button click
        /// </summary>
        private void btnRefactor_Click(object sender, EventArgs e)
        {
            int index = 0;
            StringBuilder sb = new StringBuilder();
            // Enum.GetValues doesn't order the enums as they are listed in code, this itrates in code order, or at least it should XD
            // It is done this way to make sure enemy and character sprites are in the order they are in the rom, as an offset is used for their sprite id
            foreach (FieldInfo type in typeof(SpriteType).GetFields().Where(fi => fi.IsStatic).OrderBy(fi => fi.MetadataToken))
            {
                // Only increment sprite values, other types use their byte address as the value
                sb.AppendLine("[Description(\"" + EnumMethods.GetDescription(typeof(SpriteType), type.Name) + "\")]");
                sb.AppendLine("[PaletteGroupID(" + EnumMethods.GetPaletteGroupID(typeof(SpriteType), type.Name) + ")]");
                sb.AppendLine("[PaletteIndex(" + EnumMethods.GetPaletteIndex(typeof(SpriteType), type.Name) + ")]");
                string tilesetIDs = "new int[] { ";
                List<int> ts = EnumMethods.GetTilesetIDs(typeof(SpriteType), type.Name);
                foreach (int tilesetId in ts)
                    tilesetIDs += tilesetId + (tilesetId != ts[ts.Count - 1] ? ", " : "");
                string tileMapIDs = "new int[] { ";
                List<int> tm = EnumMethods.GetTileMapIDs(typeof(SpriteType), type.Name);
                foreach (int tileMapId in tm)
                    tileMapIDs += tileMapId + (tileMapId != tm[tm.Count - 1] ? ", " : "");
                sb.AppendLine("[TilesetIDs(" + tilesetIDs + " })]");
                sb.AppendLine("[TileMapIDs(" + tileMapIDs + " })]");
                sb.AppendLine(type.Name + " = " + index + ",");
                index++;
            }
            // Dump to control (Use ouput to replace SpriteType enumeration)
            txtResults.Text = sb.ToString();
        }
    }
}
