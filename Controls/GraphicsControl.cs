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
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Collections.Generic;
using Rika.Data;
using Rika.Forms;

namespace Rika.Controls
{
    public partial class GraphicsControl : UserControl
    {
        /// <summary>
        /// Fields
        /// </summary>
        private MainForm _mainForm = null;
        private ObjectID _selectedObject = null;
        private List<Color> _palette = null;
        private bool _loading = false;

        /// <summary>
        /// Properties
        /// </summary>
        public MainForm MainForm { get { return _mainForm; } set { _mainForm = value; LoadData(); } }
        public string SelectedInformation { get { return GetSelectedInfo(); } }
        private bool HasData { get { return _mainForm != null && _mainForm.RomData != null && trSprites.SelectedNode != null; } }

        /// <summary>
        /// Constructors
        /// </summary>
        public GraphicsControl()
        {
            InitializeComponent();
            grdPalettes.RowsDefaultCellStyle.BackColor = SystemColors.Control;
            grdPalettes.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.Window;
        }

        /// <summary>
        /// Sprite selection changed
        /// </summary>
        private void trSprites_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Set sprite fields
            SetSpriteFields();
            if (tabMain.SelectedTab != tabSprite && tabMain.SelectedTab != tabSpriteTilesets && tabMain.SelectedTab != tabSpriteTileMaps)
                tabMain.SelectedTab = tabSprite;
            SetInformation();
        }

        /// <summary>
        /// Sort selection changed
        /// </summary>
        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_mainForm == null || _mainForm.RomData == null)
                return;

            SortType sortType = SortType.None;
            List<ComboBox> comboBoxes = new List<ComboBox>();
            if (sender == cbSpritesSort)
            {
                List<object> items = new List<object>();
                items.AddRange(MainForm.RomData.Sprites.ToArray());
                sortType = (SortType)(cbSpritesSort.SelectedItem as ObjectID).ID;
                switch (sortType)
                {
                    case SortType.Asc: items.Sort((x, y) => string.Compare((x as ObjectID).CustomName, (y as ObjectID).CustomName)); break;
                    case SortType.Desc: items.Sort((x, y) => string.Compare((y as ObjectID).CustomName, (x as ObjectID).CustomName)); break;
                    default: break;
                }
                trSprites.Nodes.Clear();
                foreach (Sprite sprite in items)
                {
                    TreeNode node = new TreeNode(sprite.Name) { Tag = sprite.ID };
                    trSprites.Nodes.Add(node);
                }
                return;
            }
            else if (sender == cbPaletteGroupsSort)
            {
                comboBoxes.Add(cbPaletteGroups);
                sortType = (SortType)(cbPaletteGroupsSort.SelectedItem as ObjectID).ID;
                List<Palette> palettes = new List<Palette>();
                palettes.AddRange(MainForm.RomData.GetPalettes().ToArray());
                switch (sortType)
                {
                    case SortType.Asc: palettes.Sort((x, y) => string.Compare((x as ObjectID).CustomName, (y as ObjectID).CustomName)); break;
                    case SortType.Desc: palettes.Sort((x, y) => string.Compare((y as ObjectID).CustomName, (x as ObjectID).CustomName)); break;
                    default: palettes.Sort((x, y) => (x as ObjectID).DataStart.CompareTo((y as ObjectID).DataStart)); break;
                }
                grdPalettes.AutoGenerateColumns = false;
                grdPalettes.DataSource = palettes;
            }
            else if (sender == cbTilesetsSort)
            {
                comboBoxes.AddRange(new ComboBox[] { cbTilesets });
                sortType = (SortType)(cbTilesetsSort.SelectedItem as ObjectID).ID;
            }
            else if (sender == cbTileMapsSort)
            {
                comboBoxes.AddRange(new ComboBox[] { cbTileMaps });
                sortType = (SortType)(cbTileMapsSort.SelectedItem as ObjectID).ID;
            }
            else if (sender == cbSpriteLabSort)
            {
                comboBoxes.AddRange(new ComboBox[] { cbSpriteLabTileMaps, cbSpriteLabTilesets1, cbSpriteLabTilesets2, cbSpriteLabTilesets3, cbSpriteLabTilesets4, cbSpriteLabTilesets5 });
                sortType = (SortType)(cbSpriteLabSort.SelectedItem as ObjectID).ID;
            }
            foreach (ComboBox cb in comboBoxes)
            {
                object[] array = new object[cb.Items.Count];
                cb.Items.CopyTo(array, 0);
                List<object> items = new List<object>();
                items.AddRange(array);
                switch (sortType)
                {
                    case SortType.Asc: items.Sort((x, y) => string.Compare((x as ObjectID).CustomName, (y as ObjectID).CustomName)); break;
                    case SortType.Desc: items.Sort((x, y) => string.Compare((y as ObjectID).CustomName, (x as ObjectID).CustomName)); break;
                    default: items.Sort((x, y) => (x as ObjectID).ID.CompareTo((y as ObjectID).ID)); break;
                }
                cb.Items.Clear();
                cb.Items.AddRange(items.ToArray());
                if (cb != cbPaletteGroups && cb != cbSpriteLabTileMaps)
                {
                    for (int i = 0; i < cb.Items.Count; i++)
                        if ((cb.Items[i] as ObjectID).ID == -1)
                            cb.Items.RemoveAt(i);

                    cb.Items.Insert(0, new ObjectID(-1, "None"));
                }
                cb.SelectedIndex = cb.Items.Count > 0 ? 0 : -1;
            }
            SetInformation();
        }

        /// <summary>
        /// Selected tab changed
        /// </summary>
        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetInformation();
        }

        /// <summary>
        /// Selected tileset scale changed
        /// </summary>
        private void cbScale_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender == cbSpriteScale && cbSpriteScale.SelectedItem != null)
                pnlSprite.ImageScale = (cbSpriteScale.SelectedItem as ObjectID).ID;
            else if (sender == cbTilesetScale && cbTilesetScale.SelectedItem != null)
                pnlTilesets.ImageScale = (cbTilesetScale.SelectedItem as ObjectID).ID;
        }

        /// <summary>
        /// A control affecting sprite data changed
        /// </summary>
        private void ctrlSprite_Changed(object sender, EventArgs e)
        {
            // Set sprite fields
            if (!_loading && cbSpriteTilesets.SelectedItem != null && cbSpriteTileMaps.SelectedItem != null && cbSpriteScale.SelectedItem != null)
                SetSpriteImages();
        }

        /// <summary>
        /// Selected palette collection changed
        /// </summary>
        private void cbPaletteCollection_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If no valid palette collection and sprite scale has been selected
            if (!_loading && cbPaletteGroups.SelectedItem != null)
            {
                SetPalettes(0);
                SetSpriteImages();
                SetImages(false);
                SetSpriteLabImage(false);
            }
        }

        /// <summary>
        /// Selected palette changed
        /// </summary>
        private void grdPalettes_SelectionChanged(object sender, EventArgs e)
        {
            // If no valid palette has been selected
            if (!_loading && grdPaletteGroups.SelectedRows != null)
            {
                SetPalette(0, grdPaletteGroups.CurrentRow.Index);
                SetSpriteImages();
                SetImages(false);
                SetSpriteLabImage(false);
            }
        }

        /// <summary>
        /// Save button click
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        /// <summary>
        /// Sprite size changed
        /// </summary>
        private void numSpriteSize_ValueChanged(object sender, EventArgs e)
        {
            // If the required data is missing, return
            if (!_loading && HasData)
                SetSpriteImages();
        }

        /// <summary>
        /// Selected tileset changed
        /// </summary>
        private void cbTilesets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_loading)
                SetImages(false);
        }

        /// <summary>
        /// Selected tile map changed
        /// </summary>
        private void cbTileMaps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_loading)
                SetImages(true);
        }

        /// <summary>
        /// Tile map changed
        /// </summary>
        private void ctrlTileMap_Changed(object sender, EventArgs e)
        {
            if (!_loading)
                SetImages(false);
        }

        /// <summary>
        /// Selected sprite lab tile map changed
        /// </summary>
        private void cbLabTileMaps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_loading)
                SetSpriteLabImage(true);
        }

        /// <summary>
        /// Sprite lab sprite changed
        /// </summary>
        private void ctrlSpriteLab_Changed(object sender, EventArgs e)
        {
            if (!_loading)
                SetSpriteLabImage(false);
        }

        /// <summary>
        /// Loads sprite data
        /// </summary>
        private void LoadData()
        {
            // Load sort types to UI
            foreach (ComboBox cb in new List<ComboBox>() { cbSpritesSort, cbPaletteGroupsSort, cbTilesetsSort, cbTileMapsSort, cbSpriteLabSort })
            {
                cb.Items.Clear();
                foreach (int value in Enum.GetValues(typeof(SortType)))
                    cb.Items.Add(new ObjectID(value, EnumMethods.GetDescription(typeof(SortType), (SortType)value)));
            }

            // Load scale types to UI
            foreach (ComboBox cb in new List<ComboBox>() { cbSpriteScale, cbTilesetScale, cbSpriteLabScale })
            {
                cb.Items.Clear();
                foreach (int value in Enum.GetValues(typeof(ScaleType)))
                    cb.Items.Add(new ObjectID(value, EnumMethods.GetDescription(typeof(ScaleType), (ScaleType)value)));
            }

            // Load save types to UI
            foreach (ComboBox cb in new List<ComboBox>() { cbSave })
            {
                cb.Items.Clear();
                foreach (int value in Enum.GetValues(typeof(SaveType)))
                    cb.Items.Add(new ObjectID(value, EnumMethods.GetDescription(typeof(SaveType), (SaveType)value)));
            }

            // Load save as types to UI
            foreach (ComboBox cb in new List<ComboBox>() { cbSaveAs })
            {
                cb.Items.Clear();
                foreach (int value in Enum.GetValues(typeof(SaveAsType)))
                    cb.Items.Add(new ObjectID(value, EnumMethods.GetDescription(typeof(SaveAsType), (SaveAsType)value)));
            }

            // If there is data, load palette and sprite data
            if (_mainForm != null && _mainForm.RomData != null)
            {
                // Load sprites to UI
                trSprites.Nodes.Clear();
                foreach (Sprite sprite in MainForm.RomData.Sprites)
                {
                    TreeNode node = new TreeNode(sprite.Name) { Tag = sprite.ID };
                    trSprites.Nodes.Add(node);
                }

                // Load palette collections to UI
                foreach (ComboBox cb in new List<ComboBox>() { cbPaletteGroups })
                {
                    cb.Items.Clear();
                    foreach (PaletteGroup collection in MainForm.RomData.PaletteGroups)
                        cb.Items.Add(new ObjectID(collection.ID, collection.Name));
                }

                // Load tilesets to UI
                foreach (ComboBox cb in new List<ComboBox>() { cbTilesets, cbSpriteLabTilesets1, cbSpriteLabTilesets2, cbSpriteLabTilesets3, cbSpriteLabTilesets4, cbSpriteLabTilesets5 })
                {
                    cb.Items.Clear();
                    foreach (Tileset tileset in MainForm.RomData.Tilesets)
                        if (tileset.ID != 0)
                            cb.Items.Add(new ObjectID(tileset.ID, tileset.Name));
                }

                // Load tile maps to UI
                foreach (ComboBox cb in new List<ComboBox>() { cbTileMaps, cbSpriteLabTileMaps })
                {
                    cb.Items.Clear();
                    foreach (TileMap tileMap in MainForm.RomData.TileMaps)
                        cb.Items.Add(new ObjectID(tileMap.ID, tileMap.Name));
                }

                // Set palette grid
                grdPalettes.AutoGenerateColumns = false;
                grdPalettes.DataSource = MainForm.RomData.GetPalettes();
            }

            // Select first item
            foreach (ComboBox cb in new List<ComboBox>() { cbPaletteGroups, cbPaletteGroupsSort, cbSave, cbSaveAs, cbSpriteScale, cbTilesetScale, cbSpriteLabScale })
                if (cb.Items.Count > 0)
                    cb.SelectedIndex = 0;

            // Select second item
            foreach (ComboBox cb in new List<ComboBox>() { cbSpritesSort, cbPaletteGroupsSort, cbTilesetsSort, cbTileMapsSort, cbSpriteLabSort })
                if (cb.Items.Count > 1)
                    cb.SelectedIndex = 1;
        }

        /// <summary>
        /// Sets sprite fields with data
        /// </summary>
        private void SetSpriteFields()
        {
            // If no data, return
            if (!HasData)
                return;

            // Fill out the UI based on selected sprite data
            _loading = true;
            Sprite sprite = GetSelectedSprite();
            if (sprite == null)
                return;
            Tileset tileset = MainForm.RomData.GetCombinedTileset(sprite.TilesetIDs, "Combined");
            if (tileset == null)
                return;
            if (MainForm.RomData.GetTileMaps(sprite.TileMapIDs).Count < 1)
                return;
            lblSpriteName.Text = sprite.Name;
            TileMap tileMap = MainForm.RomData.GetTileMaps(sprite.TileMapIDs)[0];
            cbPaletteGroups.SelectedIndex = MainForm.GetIndexByValue(cbPaletteGroups, sprite.PaletteGroupID);
            if (sprite.PaletteGroupID > 0)
            {
                SetPalettes(sprite.PaletteIndex);
                SetPalette(sprite.PaletteGroupID, sprite.PaletteIndex);
            }
            numSpriteColumns.Value = tileMap.Columns;
            numSpriteRows.Value = tileMap.Rows;
            foreach (ComboBox cb in new List<ComboBox>() { cbSpriteTilesets, cbSpriteTileMaps })
                cb.Items.Clear();
            foreach (ComboBox cb in new List<ComboBox>() { cbSpriteTilesets })
                foreach (Tileset tiles in MainForm.RomData.GetTilesets(sprite.TilesetIDs))
                    cb.Items.Add(new ObjectID(tiles.ID, tiles.Name));
            if (sprite.TilesetIDs.Count > 1)
                cbSpriteTilesets.Items.Insert(0, tileset as ObjectID);
            foreach (ComboBox cb in new List<ComboBox>() { cbSpriteTileMaps })
                cb.Items.AddRange(MainForm.RomData.GetTileMaps(sprite.TileMapIDs).ToArray());
            foreach (ComboBox cb in new List<ComboBox>() { cbSpriteTilesets, cbSpriteTileMaps })
                cb.SelectedIndex = cb.Items.Count > 0 ? 0 : cb.SelectedIndex;
            SetSpriteImages();
            _loading = false;
            SetInformation();
        }

        /// <summary>
        /// Sets palette grid based on selected palette collection
        /// </summary>
        private void SetPalettes(int index)
        {
            // If no data, return
            if (!HasData || cbPaletteGroups.SelectedItem == null)
                _palette = null;

            PaletteGroup collection = MainForm.RomData.PaletteGroups.Find(x => x.ID == (cbPaletteGroups.SelectedItem as ObjectID).ID);
            grdPaletteGroups.AutoGenerateColumns = false;
            grdPaletteGroups.DataSource = collection.Palettes;
            if (index < grdPaletteGroups.Rows.Count)
                grdPaletteGroups.Rows[index].Selected = true;
        }

        /// <summary>
        /// Sets the selected palette colors
        /// </summary>
        /// <param name="paletteGroupID">The id of the given palette group</param>
        /// <param name="index">Index override</param>
        private void SetPalette(int paletteGroupID, int index)
        {
            // If no data, return
            if (!HasData || cbPaletteGroups.SelectedItem == null)
                _palette = null;

            paletteGroupID = paletteGroupID <= 0 ? (cbPaletteGroups.SelectedItem as ObjectID).ID : paletteGroupID;
            PaletteGroup group = MainForm.RomData.PaletteGroups.Find(x => x.ID == paletteGroupID);
            Palette palette = index < group.Palettes.Count ? group.Palettes[index] : grdPaletteGroups.CurrentRow != null ? (Palette)grdPaletteGroups.CurrentRow.DataBoundItem : group.Palettes[0];
            _palette = palette.Colors;
        }

        /// <summary>
        /// Sets the sprite image UIs
        /// </summary>
        private void SetSpriteImages()
        {
            // If no data, return
            if (!HasData)
                return;

            Sprite sprite = GetSelectedSprite();
            if (sprite == null)
                return;


            Tileset tileset = GetSelectedTileset(cbSpriteTilesets);
            Tileset combined = MainForm.RomData.GetCombinedTileset(sprite.TilesetIDs, "");
            if (tileset == null || combined == null)
                return;

            if (MainForm.RomData.GetTileMaps(sprite.TileMapIDs).Count < 1)
                return;

            TileMap tileMap = MainForm.RomData.GetTileMaps(sprite.TileMapIDs)[0];
            tileMap.Columns = (int)numSpriteColumns.Value;
            tileMap.Rows = (int)numSpriteRows.Value;

            // Refresh images
            pnlSprite.BackColor = chkUseBlackBackground.Checked ? Color.Black : Color.White;
            pnlSprite.Image = Sprite.GetImage(combined, tileMap, _palette);
            pnlSprite.ImageScale = (cbSpriteScale.SelectedItem as ObjectID).ID;
            pnlSpriteTilesets.Image = tileset.GetImageWithIDs(_palette);
            pnlSpriteTileMaps.Image = GetSelectedTileMap(cbSpriteTileMaps)?.GetImageWithTileset(tileMap.Columns, tileMap.Rows, combined, _palette, cbSpriteIgnoreIdZero.Checked);
            SetInformation();
        }

        /// <summary>
        /// Sets the tilesets and tile maps image UIs
        /// </summary>
        private void SetImages(bool loading)
        {
            // If no data, return
            if (_mainForm == null || _mainForm.RomData == null)
                return;

            // Refresh images
            Tileset tileset = GetSelectedTileset(cbTilesets);
            if (tileset != null && _palette != null)
                pnlTilesets.Image = tileset.GetImage(1, _palette);

            SetInformation();
            TileMap tileMap = GetSelectedTileMap(cbTileMaps);
            if (tileMap == null)
                return;

            int cols = (int)numTileMapsColumns.Value;
            int rows = (int)numTileMapRows.Value;
            _loading = true;
            if (loading)
            {
                cols = tileMap.Columns;
                rows = tileMap.Rows;
                numTileMapsColumns.Value = cols;
                numTileMapRows.Value = rows;
            }
            _loading = false;
            pnlTileMaps.Image = tileMap.GetImage(cols, rows, cbIgnoreIdZero.Checked);
            SetInformation();
        }

        /// <summary>
        /// Sets the sprite lab image
        /// </summary>
        private void SetSpriteLabImage(bool loading)
        {
            // If no data, return
            if (_mainForm == null || _mainForm.RomData == null)
                return;

            // Get the tile map
            List<int> tileMapIDs = new List<int>();
            foreach (ComboBox cb in new List<ComboBox> { cbSpriteLabTileMaps })
                if (cb.SelectedItem != null)
                    tileMapIDs.Add((cb.SelectedItem as ObjectID).ID);

            // If the tile map is empty, return
            TileMap tileMap = GetSelectedTileMap(cbSpriteLabTileMaps);
            if (tileMapIDs.Count <= 0 || tileMap == null)
                return;

            // Set sprite lab
            tileMap.Columns = loading ? tileMap.Columns : (int)numSpriteLabColumns.Value;
            tileMap.Rows = loading ? tileMap.Rows : (int)numSpriteLabRows.Value;
            _loading = true;
            if (loading)
            {
                Sprite sprite = MainForm.RomData.Sprites.Find(x => x.TileMapIDs.Contains(tileMapIDs[0]));
                numSpriteLabColumns.Value = tileMap.Columns;
                numSpriteLabRows.Value = tileMap.Rows;
            }
            _loading = false;
            // Get the tileset
            List<int> tilesetIDs = new List<int>();
            foreach (ComboBox cb in new List<ComboBox> { cbSpriteLabTilesets1, cbSpriteLabTilesets2, cbSpriteLabTilesets3, cbSpriteLabTilesets4, cbSpriteLabTilesets5 })
                if (cb.SelectedItem != null)
                    tilesetIDs.Add((cb.SelectedItem as ObjectID).ID);

            // If the tileset is empty, return
            Tileset tileset = MainForm.RomData.GetCombinedTileset(tilesetIDs, "SpriteLab");
            if (tileset == null)
                return;

            pnlSpriteLab.BackColor = chkSpriteLabUseBlackBackground.Checked ? Color.Black : Color.White;
            pnlSpriteLab.ImageScale = (cbSpriteLabScale.SelectedItem as ObjectID).ID;
            pnlSpriteLab.Image = Sprite.GetImage(tileset, tileMap, _palette);
            SetInformation();
        }

        /// <summary>
        /// Gets the selected palette group
        /// </summary>
        /// <returns>the selected palette group</returns>
        private PaletteGroup GetSelectedPaletteGroup()
        {
            return cbPaletteGroups.SelectedItem == null ? null : MainForm.RomData.PaletteGroups.Find(x => x.ID == (cbPaletteGroups.SelectedItem as ObjectID).ID);
        }

        /// <summary>
        /// Gets the selected sprite
        /// </summary>
        /// <returns>The selected sprite</returns>
        private Sprite GetSelectedSprite()
        {
            return HasData ? MainForm.RomData.Sprites.Find(x => x.ID == (int)trSprites.SelectedNode.Tag) : null; 
        }

        /// <summary>
        /// Gets the selected tileset from the given combobox
        /// </summary>
        /// <param name="comboBox">The combobox to check</param>
        /// <returns>The selected tileset</returns>
        private Tileset GetSelectedTileset(ComboBox comboBox)
        {
            if (comboBox.SelectedItem == null)
                return null;
            else if ((comboBox.SelectedItem as ObjectID).Name == "Combined")
            {
                Sprite sprite = GetSelectedSprite();
                if (sprite == null)
                    return null;
                return MainForm.RomData.GetCombinedTileset(sprite.TilesetIDs, "Combined");
            }
            else
               return MainForm.RomData.Tilesets.Find(x => x.ID == (comboBox.SelectedItem as ObjectID).ID);
        }

        /// <summary>
        /// Gets the selected tile map
        /// </summary>
        /// <param name="comboBox">The combobox to check</param>
        /// <returns>The selected tile map</returns>
        private TileMap GetSelectedTileMap(ComboBox comboBox)
        {
            return comboBox.SelectedItem == null ? null : MainForm.RomData.TileMaps.Find(x => x.ID == (comboBox.SelectedItem as ObjectID).ID);
        }

        /// <summary>
        /// Saves selected data
        /// </summary>
        private void SaveData()
        {
            // If the required objects are missing, return
            if (_mainForm == null || _mainForm.RomData == null || cbSave.SelectedItem == null || cbSaveAs.SelectedItem == null)
                return;

            // Set up objects
            ObjectID objectID = null;
            Bitmap bmp = null;
            SaveType saveType = (SaveType)(cbSave.SelectedItem as ObjectID).ID;
            SaveAsType saveAsType = (SaveAsType)(cbSaveAs.SelectedItem as ObjectID).ID;
            string save = EnumMethods.GetDescription(typeof(SaveType), saveType);
            string saveAs = EnumMethods.GetDescription(typeof(SaveAsType), saveAsType);
            switch (saveType)
            {
                case SaveType.PaletteGroup: objectID = GetSelectedPaletteGroup(); bmp = objectID != null ? GetSelectedPaletteGroup().GetPaletteGroupImage() : null; break;
                case SaveType.Sprite: objectID = GetSelectedSprite(); bmp = pnlSprite.Image; break;
                case SaveType.SpriteTileset: objectID = GetSelectedTileset(cbSpriteTilesets); bmp = pnlSpriteTilesets.Image; break;
                case SaveType.SpriteTileMap: objectID = GetSelectedTileMap(cbSpriteTileMaps); bmp = pnlSpriteTileMaps.Image; break;
                case SaveType.Tileset: objectID = GetSelectedTileset(cbTilesets); bmp = pnlTilesets.Image; break;
                case SaveType.TileMap: objectID = GetSelectedTileMap(cbTileMaps); bmp = pnlTileMaps.Image; break;
            }

            // If no object was selected, return
            if (objectID == null)
            {
                ShowMessage("Please select a " + EnumMethods.GetDescription(typeof(SaveType), saveType).ToLower() + " to save.");
                return;
            }

            // Create open file dialog
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                // Set up the open file dialog
                dialog.Filter = saveAsType == SaveAsType.Binary ? "Uncompressed Binary|*.bin" : saveAsType == SaveAsType.CompressedBinary ? "Compressed Binary|*.bin" : "Image|*.png";
                dialog.Title = "Save " + save + " " + saveAs + " File";
                dialog.FileName = objectID.Name + saveType.ToString() + saveAsType.ToString();

                // Show dialog, if the user clicks OK
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Write data to disk, based on save as type
                    switch (saveAsType)
                    {
                        case SaveAsType.Binary: using (BinaryWriter bw = new BinaryWriter(File.Create(dialog.FileName))) { bw.Write(MainForm.RomData.Decompress(objectID.Compression, objectID.DataStart, objectID.Length)); break; }
                        case SaveAsType.CompressedBinary: using (BinaryWriter bw = new BinaryWriter(File.Create(dialog.FileName))) { bw.Write(MainForm.RomData.GetBytes(objectID.DataStart, objectID.Length)); } break;
                        case SaveAsType.Image: if (bmp != null) bmp.Save(dialog.FileName, ImageFormat.Png); break;
                    }
                }
            }
        }

        /// <summary>
        /// Shows a message with a default template
        /// </summary>
        /// <param name="message">Message to display</param>
        private void ShowMessage(string message)
        {
            MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK);
        }

        /// <summary>
        /// Sets the selected info based on current tab
        /// </summary>
        private void SetInformation()
        {
            if (_mainForm == null)
                return;

            if (tabMain.SelectedTab == tabSprite || tabMain.SelectedTab == tabSpriteLab)
            {
                Sprite sprite = GetSelectedSprite();
                TileMap tileMap = GetSelectedTileMap(cbSpriteTileMaps);
                if (tileMap != null)
                {
                    sprite.DataStart = tileMap.DataStart;
                    sprite.DataEnd = tileMap.DataEnd;
                    sprite.Length = tileMap.Length;
                    sprite.Compression = tileMap.Compression;
                }
                _selectedObject = sprite;
            }
            else if (tabMain.SelectedTab == tabSpriteTilesets)
                _selectedObject = GetSelectedTileset(cbSpriteTilesets);
            else if (tabMain.SelectedTab == tabSpriteTileMaps)
                _selectedObject = GetSelectedTileMap(cbSpriteTileMaps);
            else if (tabMain.SelectedTab == tabTilesets)
                _selectedObject = GetSelectedTileset(cbTilesets);
            else if (tabMain.SelectedTab == tabTileMaps)
                _selectedObject = GetSelectedTileMap(cbTileMaps);
            else if (tabMain.SelectedTab == tabPalettes)
                _selectedObject = GetSelectedPaletteGroup();

            MainForm.SetSelectedInformation(this, SelectedInformation);
        }

        /// <summary>
        /// Gets the selected object information
        /// </summary>
        /// <returns>Object information</returns>
        private string GetSelectedInfo()
        {
            if (_mainForm == null || _selectedObject == null)
                return "Nothing";

            string type = "";
            if (tabMain.SelectedTab == tabSprite || tabMain.SelectedTab == tabSpriteLab)
                type = "Sprite: ";
            else if (tabMain.SelectedTab == tabSpriteTilesets)
                type = "Sprite Tileset: ";
            else if (tabMain.SelectedTab == tabSpriteTileMaps)
                type = "Sprite Tile Map: ";
            else if (tabMain.SelectedTab == tabTilesets)
                type = "Tileset: ";
            else if (tabMain.SelectedTab == tabTileMaps)
                type = "Tile Map: ";
            else if (tabMain.SelectedTab == tabPalettes)
                type = "Palette Group: ";

            ObjectID clone = _selectedObject.Clone();
            clone.Name = type + clone.Name;
            return MainForm.GetSelectedInformation(clone);
        }
    }
}
