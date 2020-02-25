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
using System.Collections.Generic;
using Rika.Data;
using Rika.Forms;

namespace Rika.Controls
{
    public partial class MapsControl : UserControl
    {
        /// <summary>
        /// Fields
        /// </summary>
        private MainForm _mainForm = null;
        private bool _loading = false;

        /// <summary>
        /// Properties
        /// </summary>
        public MainForm MainForm { get { return _mainForm; } set { _mainForm = value; LoadData(); } }
        private bool HasData { get { return _mainForm != null && _mainForm.RomData != null; } }

        /// <summary>
        /// Constructors
        /// </summary>
        public MapsControl()
        {
            InitializeComponent();
            lstTilesets.DrawItem += MainForm.ListBoxDrawItem;
        }

        /// <summary>
        /// Map tree selection changed
        /// </summary>
        private void trMaps_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!_loading && trMaps.SelectedNode != null)
                SetMapFields(true);
        }

        /// <summary>
        /// Selected map palette changed
        /// </summary>
        private void grdMapPalettes_SelectionChanged(object sender, EventArgs e)
        {
            if (!_loading && grdTilesetPalettes.SelectedRows != null && lstTilesets.SelectedItem != null)
                SetMapFields(false);
        }

        /// <summary>
        /// Selected scale changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbScale_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender == cbTilesetScale && cbTilesetScale.SelectedItem != null)
                pnlTileset.ImageScale = (cbTilesetScale.SelectedItem as ObjectID).ID;
        }

        /// <summary>
        /// Selected map tileset changed
        /// </summary>
        private void lstMapTilesets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_loading && lstTilesets.SelectedItem != null && grdTilesetPalettes.SelectedRows != null)
                SetMapFields(false);
        }

        /// <summary>
        /// Loads map data
        /// </summary>
        private void LoadData()
        {
            // Load scale types to UI
            foreach (ComboBox cb in new List<ComboBox>() { cbTilesetScale })
            {
                cb.Items.Clear();
                foreach (int value in Enum.GetValues(typeof(ScaleType)))
                    cb.Items.Add(new ObjectID(value, EnumMethods.GetDescription(typeof(ScaleType), (ScaleType)value)));
            }

            // If there is data, load map data
            if (_mainForm != null && _mainForm.RomData != null)
            {
                // Load maps
                foreach (Map map in MainForm.RomData.Maps)
                {
                    TreeNode mapNode = new TreeNode(map.Name);
                    mapNode.Tag = map.ID.ToString();
                    trMaps.Nodes.Add(mapNode);
                }
            }
        }

        /// <summary>
        /// Sets map fields for selected map
        /// </summary>
        private void SetMapFields(bool loading)
        {
            if (!HasData)
                return;

            Map map = MainForm.RomData.Maps.Find(x => x.ID == Convert.ToInt32(trMaps.SelectedNode.Tag));
            PaletteGroup collection = MainForm.RomData.PaletteGroups.Find(x => x.ID == map.PaletteGroupID);
            List<Tileset> tilesets = MainForm.RomData.GetTilesets(map.TilesetIDs);
            if (loading)
            {
                _loading = true;
                grdTilesetPalettes.AutoGenerateColumns = false;
                grdTilesetPalettes.DataSource = collection.Palettes;
                lstTilesets.Items.Clear();
                foreach (Tileset tileset in tilesets)
                    lstTilesets.Items.Add(new ObjectID(tileset.ID, tileset.Name));
                lstTilesets.SelectedIndex = 0;
                _loading = false;
            }
            Palette palette = (Palette)grdTilesetPalettes.CurrentRow.DataBoundItem;
            Tileset selected = tilesets.Find(x => x.ID == (lstTilesets.SelectedItem as ObjectID).ID);
            pnlTileset.Image = selected.GetImage(1, palette.Colors);
            txtMapDialog.Text = MainForm.RomData.DialogGroups.Find(x => x.ID == map.DialogGroupID).ToString();
        }
    }
}
