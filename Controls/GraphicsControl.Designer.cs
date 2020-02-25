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

namespace Rika.Controls
{
    partial class GraphicsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphicsControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tpnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblSpriteName = new System.Windows.Forms.Label();
            this.cbSave = new System.Windows.Forms.ComboBox();
            this.cbSaveAs = new System.Windows.Forms.ComboBox();
            this.lblSaveAs = new System.Windows.Forms.Label();
            this.grpSpriteSelect = new System.Windows.Forms.GroupBox();
            this.tpnlSpriteSelect = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPaletteGroupsBorder = new System.Windows.Forms.Panel();
            this.grdPaletteGroups = new System.Windows.Forms.DataGridView();
            this.colPalette = new System.Windows.Forms.DataGridViewImageColumn();
            this.cbPaletteGroupsSort = new System.Windows.Forms.ComboBox();
            this.cbSpritesSort = new System.Windows.Forms.ComboBox();
            this.cbPaletteGroups = new System.Windows.Forms.ComboBox();
            this.lblSprites = new System.Windows.Forms.Label();
            this.lblPaletteGroups = new System.Windows.Forms.Label();
            this.pnlSpritesBorder = new System.Windows.Forms.Panel();
            this.trSprites = new System.Windows.Forms.TreeView();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabSprite = new System.Windows.Forms.TabPage();
            this.tpnlSprite = new System.Windows.Forms.TableLayoutPanel();
            this.chkUseBlackBackground = new System.Windows.Forms.CheckBox();
            this.numSpriteRows = new System.Windows.Forms.NumericUpDown();
            this.lblTabSpriteRows = new System.Windows.Forms.Label();
            this.numSpriteColumns = new System.Windows.Forms.NumericUpDown();
            this.lblTabSpriteColumns = new System.Windows.Forms.Label();
            this.cbSpriteScale = new System.Windows.Forms.ComboBox();
            this.pnlSprite = new Rika.Controls.ImagePanel();
            this.lblSpriteScale = new System.Windows.Forms.Label();
            this.tabSpriteTilesets = new System.Windows.Forms.TabPage();
            this.tpnlSpriteTilesets = new System.Windows.Forms.TableLayoutPanel();
            this.cbSpriteTilesets = new System.Windows.Forms.ComboBox();
            this.lblSpriteTileset = new System.Windows.Forms.Label();
            this.pnlSpriteTilesets = new Rika.Controls.ImagePanel();
            this.tabSpriteTileMaps = new System.Windows.Forms.TabPage();
            this.tpnlSpriteTileMaps = new System.Windows.Forms.TableLayoutPanel();
            this.cbSpriteIgnoreIdZero = new System.Windows.Forms.CheckBox();
            this.cbSpriteTileMaps = new System.Windows.Forms.ComboBox();
            this.lblSpriteTileMap = new System.Windows.Forms.Label();
            this.pnlSpriteTileMaps = new Rika.Controls.ImagePanel();
            this.tabTilesets = new System.Windows.Forms.TabPage();
            this.tpnlTilesets = new System.Windows.Forms.TableLayoutPanel();
            this.cbTilesetsSort = new System.Windows.Forms.ComboBox();
            this.lblTileset = new System.Windows.Forms.Label();
            this.cbTilesetScale = new System.Windows.Forms.ComboBox();
            this.pnlTilesets = new Rika.Controls.ImagePanel();
            this.lblTilesetScale = new System.Windows.Forms.Label();
            this.cbTilesets = new System.Windows.Forms.ComboBox();
            this.tabTileMaps = new System.Windows.Forms.TabPage();
            this.tpnlTileMaps = new System.Windows.Forms.TableLayoutPanel();
            this.cbTileMapsSort = new System.Windows.Forms.ComboBox();
            this.numTileMapsColumns = new System.Windows.Forms.NumericUpDown();
            this.lblTileMapRows = new System.Windows.Forms.Label();
            this.numTileMapRows = new System.Windows.Forms.NumericUpDown();
            this.lblTileMapColumns = new System.Windows.Forms.Label();
            this.lblTileMap = new System.Windows.Forms.Label();
            this.pnlTileMaps = new Rika.Controls.ImagePanel();
            this.cbTileMaps = new System.Windows.Forms.ComboBox();
            this.cbIgnoreIdZero = new System.Windows.Forms.CheckBox();
            this.tabPalettes = new System.Windows.Forms.TabPage();
            this.grdPalettes = new System.Windows.Forms.DataGridView();
            this.colPaletteName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaletteImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.colPaletteDataStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaletteDataEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaletteDataSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSpriteLab = new System.Windows.Forms.TabPage();
            this.tpnlSpriteLab = new System.Windows.Forms.TableLayoutPanel();
            this.cbSpriteLabSort = new System.Windows.Forms.ComboBox();
            this.cbSpriteLabTilesets5 = new System.Windows.Forms.ComboBox();
            this.lblSpriteLabTileset5 = new System.Windows.Forms.Label();
            this.cbSpriteLabTilesets4 = new System.Windows.Forms.ComboBox();
            this.lblSpriteLabTileset4 = new System.Windows.Forms.Label();
            this.cbSpriteLabTilesets3 = new System.Windows.Forms.ComboBox();
            this.lblSpriteLabTileset3 = new System.Windows.Forms.Label();
            this.cbSpriteLabTilesets2 = new System.Windows.Forms.ComboBox();
            this.lblSpriteLabTileset2 = new System.Windows.Forms.Label();
            this.cbSpriteLabTilesets1 = new System.Windows.Forms.ComboBox();
            this.cbSpriteLabScale = new System.Windows.Forms.ComboBox();
            this.lblSpriteLabScale = new System.Windows.Forms.Label();
            this.numSpriteLabColumns = new System.Windows.Forms.NumericUpDown();
            this.lblSpriteLabRows = new System.Windows.Forms.Label();
            this.numSpriteLabRows = new System.Windows.Forms.NumericUpDown();
            this.lblSpriteLabColumns = new System.Windows.Forms.Label();
            this.lblSpriteLabTileMap = new System.Windows.Forms.Label();
            this.pnlSpriteLab = new Rika.Controls.ImagePanel();
            this.cbSpriteLabTileMaps = new System.Windows.Forms.ComboBox();
            this.chkSpriteLabUseBlackBackground = new System.Windows.Forms.CheckBox();
            this.lblSpriteLabTileset1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSave = new System.Windows.Forms.Label();
            this.lblSprite = new System.Windows.Forms.Label();
            this.tpnlMain.SuspendLayout();
            this.grpSpriteSelect.SuspendLayout();
            this.tpnlSpriteSelect.SuspendLayout();
            this.pnlPaletteGroupsBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPaletteGroups)).BeginInit();
            this.pnlSpritesBorder.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabSprite.SuspendLayout();
            this.tpnlSprite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpriteRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpriteColumns)).BeginInit();
            this.tabSpriteTilesets.SuspendLayout();
            this.tpnlSpriteTilesets.SuspendLayout();
            this.tabSpriteTileMaps.SuspendLayout();
            this.tpnlSpriteTileMaps.SuspendLayout();
            this.tabTilesets.SuspendLayout();
            this.tpnlTilesets.SuspendLayout();
            this.tabTileMaps.SuspendLayout();
            this.tpnlTileMaps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTileMapsColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTileMapRows)).BeginInit();
            this.tabPalettes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPalettes)).BeginInit();
            this.tabSpriteLab.SuspendLayout();
            this.tpnlSpriteLab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpriteLabColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpriteLabRows)).BeginInit();
            this.SuspendLayout();
            // 
            // tpnlMain
            // 
            this.tpnlMain.ColumnCount = 8;
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 264F));
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tpnlMain.Controls.Add(this.lblSpriteName, 2, 0);
            this.tpnlMain.Controls.Add(this.cbSave, 4, 0);
            this.tpnlMain.Controls.Add(this.cbSaveAs, 6, 0);
            this.tpnlMain.Controls.Add(this.lblSaveAs, 5, 0);
            this.tpnlMain.Controls.Add(this.grpSpriteSelect, 0, 0);
            this.tpnlMain.Controls.Add(this.tabMain, 1, 1);
            this.tpnlMain.Controls.Add(this.btnSave, 7, 0);
            this.tpnlMain.Controls.Add(this.lblSave, 3, 0);
            this.tpnlMain.Controls.Add(this.lblSprite, 1, 0);
            this.tpnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlMain.Location = new System.Drawing.Point(0, 0);
            this.tpnlMain.Name = "tpnlMain";
            this.tpnlMain.RowCount = 2;
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlMain.Size = new System.Drawing.Size(1028, 537);
            this.tpnlMain.TabIndex = 0;
            // 
            // lblSpriteName
            // 
            this.lblSpriteName.AutoSize = true;
            this.lblSpriteName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSpriteName.Location = new System.Drawing.Point(313, 0);
            this.lblSpriteName.Name = "lblSpriteName";
            this.lblSpriteName.Size = new System.Drawing.Size(264, 26);
            this.lblSpriteName.TabIndex = 8;
            this.lblSpriteName.Text = "None";
            this.lblSpriteName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbSave
            // 
            this.cbSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSave.FormattingEnabled = true;
            this.cbSave.Location = new System.Drawing.Point(622, 3);
            this.cbSave.Name = "cbSave";
            this.cbSave.Size = new System.Drawing.Size(154, 21);
            this.cbSave.TabIndex = 2;
            // 
            // cbSaveAs
            // 
            this.cbSaveAs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSaveAs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSaveAs.FormattingEnabled = true;
            this.cbSaveAs.Location = new System.Drawing.Point(811, 3);
            this.cbSaveAs.Name = "cbSaveAs";
            this.cbSaveAs.Size = new System.Drawing.Size(164, 21);
            this.cbSaveAs.TabIndex = 4;
            // 
            // lblSaveAs
            // 
            this.lblSaveAs.AutoSize = true;
            this.lblSaveAs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSaveAs.Location = new System.Drawing.Point(782, 0);
            this.lblSaveAs.Name = "lblSaveAs";
            this.lblSaveAs.Size = new System.Drawing.Size(23, 26);
            this.lblSaveAs.TabIndex = 3;
            this.lblSaveAs.Text = "As:";
            this.lblSaveAs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpSpriteSelect
            // 
            this.grpSpriteSelect.Controls.Add(this.tpnlSpriteSelect);
            this.grpSpriteSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSpriteSelect.Location = new System.Drawing.Point(3, 3);
            this.grpSpriteSelect.Name = "grpSpriteSelect";
            this.grpSpriteSelect.Padding = new System.Windows.Forms.Padding(8);
            this.tpnlMain.SetRowSpan(this.grpSpriteSelect, 2);
            this.grpSpriteSelect.Size = new System.Drawing.Size(258, 531);
            this.grpSpriteSelect.TabIndex = 0;
            this.grpSpriteSelect.TabStop = false;
            this.grpSpriteSelect.Text = "Sprite Select";
            // 
            // tpnlSpriteSelect
            // 
            this.tpnlSpriteSelect.ColumnCount = 3;
            this.tpnlSpriteSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tpnlSpriteSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlSpriteSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tpnlSpriteSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnlSpriteSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnlSpriteSelect.Controls.Add(this.pnlPaletteGroupsBorder, 0, 4);
            this.tpnlSpriteSelect.Controls.Add(this.cbPaletteGroupsSort, 2, 3);
            this.tpnlSpriteSelect.Controls.Add(this.cbSpritesSort, 2, 0);
            this.tpnlSpriteSelect.Controls.Add(this.cbPaletteGroups, 0, 3);
            this.tpnlSpriteSelect.Controls.Add(this.lblSprites, 0, 0);
            this.tpnlSpriteSelect.Controls.Add(this.lblPaletteGroups, 0, 2);
            this.tpnlSpriteSelect.Controls.Add(this.pnlSpritesBorder, 0, 1);
            this.tpnlSpriteSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlSpriteSelect.Location = new System.Drawing.Point(8, 23);
            this.tpnlSpriteSelect.Name = "tpnlSpriteSelect";
            this.tpnlSpriteSelect.RowCount = 5;
            this.tpnlSpriteSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlSpriteSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlSpriteSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlSpriteSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlSpriteSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tpnlSpriteSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnlSpriteSelect.Size = new System.Drawing.Size(242, 500);
            this.tpnlSpriteSelect.TabIndex = 0;
            // 
            // pnlPaletteGroupsBorder
            // 
            this.pnlPaletteGroupsBorder.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tpnlSpriteSelect.SetColumnSpan(this.pnlPaletteGroupsBorder, 3);
            this.pnlPaletteGroupsBorder.Controls.Add(this.grdPaletteGroups);
            this.pnlPaletteGroupsBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPaletteGroupsBorder.Location = new System.Drawing.Point(3, 399);
            this.pnlPaletteGroupsBorder.Name = "pnlPaletteGroupsBorder";
            this.pnlPaletteGroupsBorder.Padding = new System.Windows.Forms.Padding(1);
            this.pnlPaletteGroupsBorder.Size = new System.Drawing.Size(236, 98);
            this.pnlPaletteGroupsBorder.TabIndex = 6;
            // 
            // grdPaletteGroups
            // 
            this.grdPaletteGroups.AllowUserToAddRows = false;
            this.grdPaletteGroups.AllowUserToDeleteRows = false;
            this.grdPaletteGroups.AllowUserToResizeColumns = false;
            this.grdPaletteGroups.AllowUserToResizeRows = false;
            this.grdPaletteGroups.BackgroundColor = System.Drawing.Color.White;
            this.grdPaletteGroups.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdPaletteGroups.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdPaletteGroups.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdPaletteGroups.ColumnHeadersHeight = 40;
            this.grdPaletteGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdPaletteGroups.ColumnHeadersVisible = false;
            this.grdPaletteGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPalette});
            this.grdPaletteGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPaletteGroups.Location = new System.Drawing.Point(1, 1);
            this.grdPaletteGroups.MultiSelect = false;
            this.grdPaletteGroups.Name = "grdPaletteGroups";
            this.grdPaletteGroups.ReadOnly = true;
            this.grdPaletteGroups.RowHeadersVisible = false;
            this.grdPaletteGroups.RowTemplate.Height = 16;
            this.grdPaletteGroups.RowTemplate.ReadOnly = true;
            this.grdPaletteGroups.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPaletteGroups.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdPaletteGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPaletteGroups.ShowCellErrors = false;
            this.grdPaletteGroups.ShowCellToolTips = false;
            this.grdPaletteGroups.ShowEditingIcon = false;
            this.grdPaletteGroups.ShowRowErrors = false;
            this.grdPaletteGroups.Size = new System.Drawing.Size(234, 96);
            this.grdPaletteGroups.TabIndex = 0;
            this.grdPaletteGroups.SelectionChanged += new System.EventHandler(this.grdPalettes_SelectionChanged);
            // 
            // colPalette
            // 
            this.colPalette.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPalette.DataPropertyName = "PaletteImage";
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            this.colPalette.DefaultCellStyle = dataGridViewCellStyle3;
            this.colPalette.FillWeight = 160F;
            this.colPalette.HeaderText = "Palettes";
            this.colPalette.MinimumWidth = 25;
            this.colPalette.Name = "colPalette";
            this.colPalette.ReadOnly = true;
            this.colPalette.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cbPaletteGroupsSort
            // 
            this.cbPaletteGroupsSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbPaletteGroupsSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaletteGroupsSort.FormattingEnabled = true;
            this.cbPaletteGroupsSort.Items.AddRange(new object[] {
            "Unsorted",
            "Ascending",
            "Descending"});
            this.cbPaletteGroupsSort.Location = new System.Drawing.Point(185, 373);
            this.cbPaletteGroupsSort.Name = "cbPaletteGroupsSort";
            this.cbPaletteGroupsSort.Size = new System.Drawing.Size(54, 21);
            this.cbPaletteGroupsSort.TabIndex = 5;
            this.cbPaletteGroupsSort.SelectedIndexChanged += new System.EventHandler(this.cbSort_SelectedIndexChanged);
            // 
            // cbSpritesSort
            // 
            this.cbSpritesSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSpritesSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpritesSort.FormattingEnabled = true;
            this.cbSpritesSort.Location = new System.Drawing.Point(185, 3);
            this.cbSpritesSort.Name = "cbSpritesSort";
            this.cbSpritesSort.Size = new System.Drawing.Size(54, 21);
            this.cbSpritesSort.TabIndex = 1;
            this.cbSpritesSort.SelectedIndexChanged += new System.EventHandler(this.cbSort_SelectedIndexChanged);
            // 
            // cbPaletteGroups
            // 
            this.tpnlSpriteSelect.SetColumnSpan(this.cbPaletteGroups, 2);
            this.cbPaletteGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbPaletteGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaletteGroups.FormattingEnabled = true;
            this.cbPaletteGroups.Location = new System.Drawing.Point(3, 373);
            this.cbPaletteGroups.Name = "cbPaletteGroups";
            this.cbPaletteGroups.Size = new System.Drawing.Size(176, 21);
            this.cbPaletteGroups.TabIndex = 4;
            this.cbPaletteGroups.SelectedIndexChanged += new System.EventHandler(this.cbPaletteCollection_SelectedIndexChanged);
            // 
            // lblSprites
            // 
            this.lblSprites.AutoSize = true;
            this.lblSprites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSprites.Location = new System.Drawing.Point(3, 0);
            this.lblSprites.Name = "lblSprites";
            this.lblSprites.Size = new System.Drawing.Size(45, 26);
            this.lblSprites.TabIndex = 0;
            this.lblSprites.Text = "Sprites:";
            this.lblSprites.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPaletteGroups
            // 
            this.lblPaletteGroups.AutoSize = true;
            this.tpnlSpriteSelect.SetColumnSpan(this.lblPaletteGroups, 3);
            this.lblPaletteGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPaletteGroups.Location = new System.Drawing.Point(3, 344);
            this.lblPaletteGroups.Name = "lblPaletteGroups";
            this.lblPaletteGroups.Size = new System.Drawing.Size(236, 26);
            this.lblPaletteGroups.TabIndex = 3;
            this.lblPaletteGroups.Text = "Palette Groups:";
            this.lblPaletteGroups.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSpritesBorder
            // 
            this.pnlSpritesBorder.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tpnlSpriteSelect.SetColumnSpan(this.pnlSpritesBorder, 3);
            this.pnlSpritesBorder.Controls.Add(this.trSprites);
            this.pnlSpritesBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSpritesBorder.Location = new System.Drawing.Point(3, 29);
            this.pnlSpritesBorder.Name = "pnlSpritesBorder";
            this.pnlSpritesBorder.Padding = new System.Windows.Forms.Padding(1);
            this.pnlSpritesBorder.Size = new System.Drawing.Size(236, 312);
            this.pnlSpritesBorder.TabIndex = 2;
            // 
            // trSprites
            // 
            this.trSprites.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trSprites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trSprites.Location = new System.Drawing.Point(1, 1);
            this.trSprites.Name = "trSprites";
            this.trSprites.Size = new System.Drawing.Size(234, 310);
            this.trSprites.TabIndex = 0;
            this.trSprites.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trSprites_AfterSelect);
            // 
            // tabMain
            // 
            this.tpnlMain.SetColumnSpan(this.tabMain, 7);
            this.tabMain.Controls.Add(this.tabSprite);
            this.tabMain.Controls.Add(this.tabSpriteTilesets);
            this.tabMain.Controls.Add(this.tabSpriteTileMaps);
            this.tabMain.Controls.Add(this.tabTilesets);
            this.tabMain.Controls.Add(this.tabTileMaps);
            this.tabMain.Controls.Add(this.tabPalettes);
            this.tabMain.Controls.Add(this.tabSpriteLab);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(267, 29);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(758, 505);
            this.tabMain.TabIndex = 6;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // tabSprite
            // 
            this.tabSprite.Controls.Add(this.tpnlSprite);
            this.tabSprite.Location = new System.Drawing.Point(4, 22);
            this.tabSprite.Name = "tabSprite";
            this.tabSprite.Padding = new System.Windows.Forms.Padding(4);
            this.tabSprite.Size = new System.Drawing.Size(750, 479);
            this.tabSprite.TabIndex = 0;
            this.tabSprite.Text = "Sprite";
            this.tabSprite.UseVisualStyleBackColor = true;
            // 
            // tpnlSprite
            // 
            this.tpnlSprite.ColumnCount = 7;
            this.tpnlSprite.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tpnlSprite.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tpnlSprite.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tpnlSprite.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tpnlSprite.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tpnlSprite.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tpnlSprite.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlSprite.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnlSprite.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnlSprite.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnlSprite.Controls.Add(this.chkUseBlackBackground, 6, 0);
            this.tpnlSprite.Controls.Add(this.numSpriteRows, 3, 0);
            this.tpnlSprite.Controls.Add(this.lblTabSpriteRows, 2, 0);
            this.tpnlSprite.Controls.Add(this.numSpriteColumns, 1, 0);
            this.tpnlSprite.Controls.Add(this.lblTabSpriteColumns, 0, 0);
            this.tpnlSprite.Controls.Add(this.cbSpriteScale, 5, 0);
            this.tpnlSprite.Controls.Add(this.pnlSprite, 0, 1);
            this.tpnlSprite.Controls.Add(this.lblSpriteScale, 4, 0);
            this.tpnlSprite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlSprite.Location = new System.Drawing.Point(4, 4);
            this.tpnlSprite.Name = "tpnlSprite";
            this.tpnlSprite.RowCount = 2;
            this.tpnlSprite.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlSprite.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlSprite.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnlSprite.Size = new System.Drawing.Size(742, 471);
            this.tpnlSprite.TabIndex = 0;
            // 
            // chkUseBlackBackground
            // 
            this.chkUseBlackBackground.AutoSize = true;
            this.chkUseBlackBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkUseBlackBackground.Location = new System.Drawing.Point(323, 5);
            this.chkUseBlackBackground.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.chkUseBlackBackground.Name = "chkUseBlackBackground";
            this.chkUseBlackBackground.Size = new System.Drawing.Size(416, 18);
            this.chkUseBlackBackground.TabIndex = 7;
            this.chkUseBlackBackground.Text = "Use Black Background";
            this.chkUseBlackBackground.UseVisualStyleBackColor = true;
            this.chkUseBlackBackground.CheckedChanged += new System.EventHandler(this.ctrlSprite_Changed);
            // 
            // numSpriteRows
            // 
            this.numSpriteRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numSpriteRows.Location = new System.Drawing.Point(171, 3);
            this.numSpriteRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSpriteRows.Name = "numSpriteRows";
            this.numSpriteRows.Size = new System.Drawing.Size(54, 22);
            this.numSpriteRows.TabIndex = 3;
            this.numSpriteRows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSpriteRows.ValueChanged += new System.EventHandler(this.ctrlSprite_Changed);
            // 
            // lblTabSpriteRows
            // 
            this.lblTabSpriteRows.AutoSize = true;
            this.lblTabSpriteRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTabSpriteRows.Location = new System.Drawing.Point(125, 0);
            this.lblTabSpriteRows.Name = "lblTabSpriteRows";
            this.lblTabSpriteRows.Size = new System.Drawing.Size(40, 26);
            this.lblTabSpriteRows.TabIndex = 2;
            this.lblTabSpriteRows.Text = "Rows:";
            this.lblTabSpriteRows.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numSpriteColumns
            // 
            this.numSpriteColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numSpriteColumns.Location = new System.Drawing.Point(65, 3);
            this.numSpriteColumns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSpriteColumns.Name = "numSpriteColumns";
            this.numSpriteColumns.Size = new System.Drawing.Size(54, 22);
            this.numSpriteColumns.TabIndex = 1;
            this.numSpriteColumns.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSpriteColumns.ValueChanged += new System.EventHandler(this.numSpriteSize_ValueChanged);
            // 
            // lblTabSpriteColumns
            // 
            this.lblTabSpriteColumns.AutoSize = true;
            this.lblTabSpriteColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTabSpriteColumns.Location = new System.Drawing.Point(3, 0);
            this.lblTabSpriteColumns.Name = "lblTabSpriteColumns";
            this.lblTabSpriteColumns.Size = new System.Drawing.Size(56, 26);
            this.lblTabSpriteColumns.TabIndex = 0;
            this.lblTabSpriteColumns.Text = "Columns:";
            this.lblTabSpriteColumns.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbSpriteScale
            // 
            this.cbSpriteScale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSpriteScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpriteScale.Location = new System.Drawing.Point(276, 3);
            this.cbSpriteScale.Name = "cbSpriteScale";
            this.cbSpriteScale.Size = new System.Drawing.Size(41, 21);
            this.cbSpriteScale.TabIndex = 5;
            this.cbSpriteScale.SelectedIndexChanged += new System.EventHandler(this.cbScale_SelectedIndexChanged);
            // 
            // pnlSprite
            // 
            this.pnlSprite.AutoScroll = true;
            this.pnlSprite.AutoScrollMinSize = new System.Drawing.Size(736, 439);
            this.pnlSprite.BackColor = System.Drawing.Color.White;
            this.pnlSprite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlSprite.Centered = true;
            this.tpnlSprite.SetColumnSpan(this.pnlSprite, 7);
            this.pnlSprite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSprite.Image = null;
            this.pnlSprite.ImageScale = 1;
            this.pnlSprite.Location = new System.Drawing.Point(3, 29);
            this.pnlSprite.Name = "pnlSprite";
            this.pnlSprite.Size = new System.Drawing.Size(736, 439);
            this.pnlSprite.TabIndex = 6;
            // 
            // lblSpriteScale
            // 
            this.lblSpriteScale.AutoSize = true;
            this.lblSpriteScale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSpriteScale.Location = new System.Drawing.Point(231, 0);
            this.lblSpriteScale.Name = "lblSpriteScale";
            this.lblSpriteScale.Size = new System.Drawing.Size(39, 26);
            this.lblSpriteScale.TabIndex = 4;
            this.lblSpriteScale.Text = "Scale:";
            this.lblSpriteScale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabSpriteTilesets
            // 
            this.tabSpriteTilesets.Controls.Add(this.tpnlSpriteTilesets);
            this.tabSpriteTilesets.Location = new System.Drawing.Point(4, 22);
            this.tabSpriteTilesets.Name = "tabSpriteTilesets";
            this.tabSpriteTilesets.Padding = new System.Windows.Forms.Padding(3);
            this.tabSpriteTilesets.Size = new System.Drawing.Size(750, 479);
            this.tabSpriteTilesets.TabIndex = 1;
            this.tabSpriteTilesets.Text = "Sprite Tilesets";
            this.tabSpriteTilesets.UseVisualStyleBackColor = true;
            // 
            // tpnlSpriteTilesets
            // 
            this.tpnlSpriteTilesets.ColumnCount = 3;
            this.tpnlSpriteTilesets.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tpnlSpriteTilesets.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tpnlSpriteTilesets.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlSpriteTilesets.Controls.Add(this.cbSpriteTilesets, 1, 0);
            this.tpnlSpriteTilesets.Controls.Add(this.lblSpriteTileset, 0, 0);
            this.tpnlSpriteTilesets.Controls.Add(this.pnlSpriteTilesets, 0, 1);
            this.tpnlSpriteTilesets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlSpriteTilesets.Location = new System.Drawing.Point(3, 3);
            this.tpnlSpriteTilesets.Name = "tpnlSpriteTilesets";
            this.tpnlSpriteTilesets.RowCount = 2;
            this.tpnlSpriteTilesets.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlSpriteTilesets.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlSpriteTilesets.Size = new System.Drawing.Size(744, 473);
            this.tpnlSpriteTilesets.TabIndex = 0;
            // 
            // cbSpriteTilesets
            // 
            this.cbSpriteTilesets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSpriteTilesets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpriteTilesets.FormattingEnabled = true;
            this.cbSpriteTilesets.Location = new System.Drawing.Point(86, 3);
            this.cbSpriteTilesets.Name = "cbSpriteTilesets";
            this.cbSpriteTilesets.Size = new System.Drawing.Size(184, 21);
            this.cbSpriteTilesets.TabIndex = 1;
            this.cbSpriteTilesets.SelectedIndexChanged += new System.EventHandler(this.ctrlSprite_Changed);
            // 
            // lblSpriteTileset
            // 
            this.lblSpriteTileset.AutoSize = true;
            this.lblSpriteTileset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSpriteTileset.Location = new System.Drawing.Point(3, 0);
            this.lblSpriteTileset.Name = "lblSpriteTileset";
            this.lblSpriteTileset.Size = new System.Drawing.Size(77, 26);
            this.lblSpriteTileset.TabIndex = 0;
            this.lblSpriteTileset.Text = "Sprite Tileset:";
            this.lblSpriteTileset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSpriteTilesets
            // 
            this.pnlSpriteTilesets.AutoScroll = true;
            this.pnlSpriteTilesets.AutoScrollMinSize = new System.Drawing.Size(738, 441);
            this.pnlSpriteTilesets.BackColor = System.Drawing.Color.White;
            this.pnlSpriteTilesets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlSpriteTilesets.Centered = true;
            this.tpnlSpriteTilesets.SetColumnSpan(this.pnlSpriteTilesets, 3);
            this.pnlSpriteTilesets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSpriteTilesets.Image = null;
            this.pnlSpriteTilesets.ImageScale = 1;
            this.pnlSpriteTilesets.Location = new System.Drawing.Point(3, 29);
            this.pnlSpriteTilesets.Name = "pnlSpriteTilesets";
            this.pnlSpriteTilesets.Size = new System.Drawing.Size(738, 441);
            this.pnlSpriteTilesets.TabIndex = 2;
            // 
            // tabSpriteTileMaps
            // 
            this.tabSpriteTileMaps.Controls.Add(this.tpnlSpriteTileMaps);
            this.tabSpriteTileMaps.Location = new System.Drawing.Point(4, 22);
            this.tabSpriteTileMaps.Name = "tabSpriteTileMaps";
            this.tabSpriteTileMaps.Padding = new System.Windows.Forms.Padding(3);
            this.tabSpriteTileMaps.Size = new System.Drawing.Size(750, 479);
            this.tabSpriteTileMaps.TabIndex = 2;
            this.tabSpriteTileMaps.Text = "Sprite Tile Maps";
            this.tabSpriteTileMaps.UseVisualStyleBackColor = true;
            // 
            // tpnlSpriteTileMaps
            // 
            this.tpnlSpriteTileMaps.ColumnCount = 3;
            this.tpnlSpriteTileMaps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tpnlSpriteTileMaps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tpnlSpriteTileMaps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlSpriteTileMaps.Controls.Add(this.cbSpriteIgnoreIdZero, 2, 0);
            this.tpnlSpriteTileMaps.Controls.Add(this.cbSpriteTileMaps, 1, 0);
            this.tpnlSpriteTileMaps.Controls.Add(this.lblSpriteTileMap, 0, 0);
            this.tpnlSpriteTileMaps.Controls.Add(this.pnlSpriteTileMaps, 0, 1);
            this.tpnlSpriteTileMaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlSpriteTileMaps.Location = new System.Drawing.Point(3, 3);
            this.tpnlSpriteTileMaps.Name = "tpnlSpriteTileMaps";
            this.tpnlSpriteTileMaps.RowCount = 2;
            this.tpnlSpriteTileMaps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlSpriteTileMaps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlSpriteTileMaps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnlSpriteTileMaps.Size = new System.Drawing.Size(744, 473);
            this.tpnlSpriteTileMaps.TabIndex = 0;
            // 
            // cbSpriteIgnoreIdZero
            // 
            this.cbSpriteIgnoreIdZero.AutoSize = true;
            this.cbSpriteIgnoreIdZero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSpriteIgnoreIdZero.Location = new System.Drawing.Point(287, 5);
            this.cbSpriteIgnoreIdZero.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.cbSpriteIgnoreIdZero.Name = "cbSpriteIgnoreIdZero";
            this.cbSpriteIgnoreIdZero.Size = new System.Drawing.Size(454, 18);
            this.cbSpriteIgnoreIdZero.TabIndex = 7;
            this.cbSpriteIgnoreIdZero.Text = "Ignore Tile ID Zero";
            this.cbSpriteIgnoreIdZero.UseVisualStyleBackColor = true;
            this.cbSpriteIgnoreIdZero.CheckedChanged += new System.EventHandler(this.ctrlSprite_Changed);
            // 
            // cbSpriteTileMaps
            // 
            this.cbSpriteTileMaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSpriteTileMaps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpriteTileMaps.FormattingEnabled = true;
            this.cbSpriteTileMaps.Location = new System.Drawing.Point(97, 3);
            this.cbSpriteTileMaps.Name = "cbSpriteTileMaps";
            this.cbSpriteTileMaps.Size = new System.Drawing.Size(184, 21);
            this.cbSpriteTileMaps.TabIndex = 1;
            this.cbSpriteTileMaps.SelectedIndexChanged += new System.EventHandler(this.ctrlSprite_Changed);
            // 
            // lblSpriteTileMap
            // 
            this.lblSpriteTileMap.AutoSize = true;
            this.lblSpriteTileMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSpriteTileMap.Location = new System.Drawing.Point(3, 0);
            this.lblSpriteTileMap.Name = "lblSpriteTileMap";
            this.lblSpriteTileMap.Size = new System.Drawing.Size(88, 26);
            this.lblSpriteTileMap.TabIndex = 0;
            this.lblSpriteTileMap.Text = "Sprite Tile Map:";
            this.lblSpriteTileMap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSpriteTileMaps
            // 
            this.pnlSpriteTileMaps.AutoScroll = true;
            this.pnlSpriteTileMaps.AutoScrollMinSize = new System.Drawing.Size(738, 441);
            this.pnlSpriteTileMaps.BackColor = System.Drawing.Color.White;
            this.pnlSpriteTileMaps.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlSpriteTileMaps.Centered = true;
            this.tpnlSpriteTileMaps.SetColumnSpan(this.pnlSpriteTileMaps, 3);
            this.pnlSpriteTileMaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSpriteTileMaps.Image = null;
            this.pnlSpriteTileMaps.ImageScale = 1;
            this.pnlSpriteTileMaps.Location = new System.Drawing.Point(3, 29);
            this.pnlSpriteTileMaps.Name = "pnlSpriteTileMaps";
            this.pnlSpriteTileMaps.Size = new System.Drawing.Size(738, 441);
            this.pnlSpriteTileMaps.TabIndex = 2;
            // 
            // tabTilesets
            // 
            this.tabTilesets.Controls.Add(this.tpnlTilesets);
            this.tabTilesets.Location = new System.Drawing.Point(4, 22);
            this.tabTilesets.Name = "tabTilesets";
            this.tabTilesets.Padding = new System.Windows.Forms.Padding(3);
            this.tabTilesets.Size = new System.Drawing.Size(750, 479);
            this.tabTilesets.TabIndex = 3;
            this.tabTilesets.Text = "Tilesets";
            this.tabTilesets.UseVisualStyleBackColor = true;
            // 
            // tpnlTilesets
            // 
            this.tpnlTilesets.ColumnCount = 6;
            this.tpnlTilesets.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tpnlTilesets.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tpnlTilesets.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tpnlTilesets.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tpnlTilesets.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tpnlTilesets.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlTilesets.Controls.Add(this.cbTilesetsSort, 2, 0);
            this.tpnlTilesets.Controls.Add(this.lblTileset, 0, 0);
            this.tpnlTilesets.Controls.Add(this.cbTilesetScale, 4, 0);
            this.tpnlTilesets.Controls.Add(this.pnlTilesets, 0, 1);
            this.tpnlTilesets.Controls.Add(this.lblTilesetScale, 3, 0);
            this.tpnlTilesets.Controls.Add(this.cbTilesets, 1, 0);
            this.tpnlTilesets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlTilesets.Location = new System.Drawing.Point(3, 3);
            this.tpnlTilesets.Name = "tpnlTilesets";
            this.tpnlTilesets.RowCount = 2;
            this.tpnlTilesets.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlTilesets.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlTilesets.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnlTilesets.Size = new System.Drawing.Size(744, 473);
            this.tpnlTilesets.TabIndex = 0;
            // 
            // cbTilesetsSort
            // 
            this.cbTilesetsSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTilesetsSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTilesetsSort.FormattingEnabled = true;
            this.cbTilesetsSort.Location = new System.Drawing.Point(244, 3);
            this.cbTilesetsSort.Name = "cbTilesetsSort";
            this.cbTilesetsSort.Size = new System.Drawing.Size(54, 21);
            this.cbTilesetsSort.TabIndex = 5;
            this.cbTilesetsSort.SelectedIndexChanged += new System.EventHandler(this.cbSort_SelectedIndexChanged);
            // 
            // lblTileset
            // 
            this.lblTileset.AutoSize = true;
            this.lblTileset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTileset.Location = new System.Drawing.Point(3, 0);
            this.lblTileset.Name = "lblTileset";
            this.lblTileset.Size = new System.Drawing.Size(45, 26);
            this.lblTileset.TabIndex = 0;
            this.lblTileset.Text = "Tileset:";
            this.lblTileset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbTilesetScale
            // 
            this.cbTilesetScale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTilesetScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTilesetScale.Location = new System.Drawing.Point(349, 3);
            this.cbTilesetScale.Name = "cbTilesetScale";
            this.cbTilesetScale.Size = new System.Drawing.Size(41, 21);
            this.cbTilesetScale.TabIndex = 3;
            this.cbTilesetScale.SelectedIndexChanged += new System.EventHandler(this.cbScale_SelectedIndexChanged);
            // 
            // pnlTilesets
            // 
            this.pnlTilesets.AutoScroll = true;
            this.pnlTilesets.AutoScrollMinSize = new System.Drawing.Size(738, 441);
            this.pnlTilesets.BackColor = System.Drawing.Color.White;
            this.pnlTilesets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlTilesets.Centered = true;
            this.tpnlTilesets.SetColumnSpan(this.pnlTilesets, 6);
            this.pnlTilesets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTilesets.Image = null;
            this.pnlTilesets.ImageScale = 1;
            this.pnlTilesets.Location = new System.Drawing.Point(3, 29);
            this.pnlTilesets.Name = "pnlTilesets";
            this.pnlTilesets.Size = new System.Drawing.Size(738, 441);
            this.pnlTilesets.TabIndex = 4;
            // 
            // lblTilesetScale
            // 
            this.lblTilesetScale.AutoSize = true;
            this.lblTilesetScale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTilesetScale.Location = new System.Drawing.Point(304, 0);
            this.lblTilesetScale.Name = "lblTilesetScale";
            this.lblTilesetScale.Size = new System.Drawing.Size(39, 26);
            this.lblTilesetScale.TabIndex = 2;
            this.lblTilesetScale.Text = "Scale:";
            this.lblTilesetScale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbTilesets
            // 
            this.cbTilesets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTilesets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTilesets.FormattingEnabled = true;
            this.cbTilesets.Location = new System.Drawing.Point(54, 3);
            this.cbTilesets.Name = "cbTilesets";
            this.cbTilesets.Size = new System.Drawing.Size(184, 21);
            this.cbTilesets.TabIndex = 1;
            this.cbTilesets.SelectedIndexChanged += new System.EventHandler(this.cbTilesets_SelectedIndexChanged);
            // 
            // tabTileMaps
            // 
            this.tabTileMaps.Controls.Add(this.tpnlTileMaps);
            this.tabTileMaps.Location = new System.Drawing.Point(4, 22);
            this.tabTileMaps.Name = "tabTileMaps";
            this.tabTileMaps.Padding = new System.Windows.Forms.Padding(3);
            this.tabTileMaps.Size = new System.Drawing.Size(750, 479);
            this.tabTileMaps.TabIndex = 4;
            this.tabTileMaps.Text = "Tile Maps";
            this.tabTileMaps.UseVisualStyleBackColor = true;
            // 
            // tpnlTileMaps
            // 
            this.tpnlTileMaps.ColumnCount = 8;
            this.tpnlTileMaps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tpnlTileMaps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tpnlTileMaps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tpnlTileMaps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tpnlTileMaps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tpnlTileMaps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tpnlTileMaps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tpnlTileMaps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlTileMaps.Controls.Add(this.cbTileMapsSort, 2, 0);
            this.tpnlTileMaps.Controls.Add(this.numTileMapsColumns, 4, 0);
            this.tpnlTileMaps.Controls.Add(this.lblTileMapRows, 5, 0);
            this.tpnlTileMaps.Controls.Add(this.numTileMapRows, 6, 0);
            this.tpnlTileMaps.Controls.Add(this.lblTileMapColumns, 3, 0);
            this.tpnlTileMaps.Controls.Add(this.lblTileMap, 0, 0);
            this.tpnlTileMaps.Controls.Add(this.pnlTileMaps, 0, 1);
            this.tpnlTileMaps.Controls.Add(this.cbTileMaps, 1, 0);
            this.tpnlTileMaps.Controls.Add(this.cbIgnoreIdZero, 7, 0);
            this.tpnlTileMaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlTileMaps.Location = new System.Drawing.Point(3, 3);
            this.tpnlTileMaps.Name = "tpnlTileMaps";
            this.tpnlTileMaps.RowCount = 2;
            this.tpnlTileMaps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlTileMaps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlTileMaps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpnlTileMaps.Size = new System.Drawing.Size(744, 473);
            this.tpnlTileMaps.TabIndex = 0;
            // 
            // cbTileMapsSort
            // 
            this.cbTileMapsSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTileMapsSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTileMapsSort.FormattingEnabled = true;
            this.cbTileMapsSort.Location = new System.Drawing.Point(254, 3);
            this.cbTileMapsSort.Name = "cbTileMapsSort";
            this.cbTileMapsSort.Size = new System.Drawing.Size(54, 21);
            this.cbTileMapsSort.TabIndex = 8;
            this.cbTileMapsSort.SelectedIndexChanged += new System.EventHandler(this.cbSort_SelectedIndexChanged);
            // 
            // numTileMapsColumns
            // 
            this.numTileMapsColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numTileMapsColumns.Location = new System.Drawing.Point(376, 3);
            this.numTileMapsColumns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTileMapsColumns.Name = "numTileMapsColumns";
            this.numTileMapsColumns.Size = new System.Drawing.Size(54, 22);
            this.numTileMapsColumns.TabIndex = 3;
            this.numTileMapsColumns.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTileMapsColumns.ValueChanged += new System.EventHandler(this.ctrlTileMap_Changed);
            // 
            // lblTileMapRows
            // 
            this.lblTileMapRows.AutoSize = true;
            this.lblTileMapRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTileMapRows.Location = new System.Drawing.Point(436, 0);
            this.lblTileMapRows.Name = "lblTileMapRows";
            this.lblTileMapRows.Size = new System.Drawing.Size(40, 26);
            this.lblTileMapRows.TabIndex = 4;
            this.lblTileMapRows.Text = "Rows:";
            this.lblTileMapRows.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numTileMapRows
            // 
            this.numTileMapRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numTileMapRows.Location = new System.Drawing.Point(482, 3);
            this.numTileMapRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTileMapRows.Name = "numTileMapRows";
            this.numTileMapRows.Size = new System.Drawing.Size(54, 22);
            this.numTileMapRows.TabIndex = 5;
            this.numTileMapRows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTileMapRows.ValueChanged += new System.EventHandler(this.ctrlTileMap_Changed);
            // 
            // lblTileMapColumns
            // 
            this.lblTileMapColumns.AutoSize = true;
            this.lblTileMapColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTileMapColumns.Location = new System.Drawing.Point(314, 0);
            this.lblTileMapColumns.Name = "lblTileMapColumns";
            this.lblTileMapColumns.Size = new System.Drawing.Size(56, 26);
            this.lblTileMapColumns.TabIndex = 2;
            this.lblTileMapColumns.Text = "Columns:";
            this.lblTileMapColumns.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTileMap
            // 
            this.lblTileMap.AutoSize = true;
            this.lblTileMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTileMap.Location = new System.Drawing.Point(3, 0);
            this.lblTileMap.Name = "lblTileMap";
            this.lblTileMap.Size = new System.Drawing.Size(55, 26);
            this.lblTileMap.TabIndex = 0;
            this.lblTileMap.Text = "Tile Map:";
            this.lblTileMap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTileMaps
            // 
            this.pnlTileMaps.AutoScroll = true;
            this.pnlTileMaps.AutoScrollMinSize = new System.Drawing.Size(738, 441);
            this.pnlTileMaps.BackColor = System.Drawing.Color.White;
            this.pnlTileMaps.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlTileMaps.Centered = true;
            this.tpnlTileMaps.SetColumnSpan(this.pnlTileMaps, 8);
            this.pnlTileMaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTileMaps.Image = null;
            this.pnlTileMaps.ImageScale = 1;
            this.pnlTileMaps.Location = new System.Drawing.Point(3, 29);
            this.pnlTileMaps.Name = "pnlTileMaps";
            this.pnlTileMaps.Size = new System.Drawing.Size(738, 441);
            this.pnlTileMaps.TabIndex = 7;
            // 
            // cbTileMaps
            // 
            this.cbTileMaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTileMaps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTileMaps.FormattingEnabled = true;
            this.cbTileMaps.Location = new System.Drawing.Point(64, 3);
            this.cbTileMaps.Name = "cbTileMaps";
            this.cbTileMaps.Size = new System.Drawing.Size(184, 21);
            this.cbTileMaps.TabIndex = 1;
            this.cbTileMaps.SelectedIndexChanged += new System.EventHandler(this.cbTileMaps_SelectedIndexChanged);
            // 
            // cbIgnoreIdZero
            // 
            this.cbIgnoreIdZero.AutoSize = true;
            this.cbIgnoreIdZero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbIgnoreIdZero.Location = new System.Drawing.Point(542, 5);
            this.cbIgnoreIdZero.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.cbIgnoreIdZero.Name = "cbIgnoreIdZero";
            this.cbIgnoreIdZero.Size = new System.Drawing.Size(199, 18);
            this.cbIgnoreIdZero.TabIndex = 6;
            this.cbIgnoreIdZero.Text = "Ignore Tile ID Zero";
            this.cbIgnoreIdZero.UseVisualStyleBackColor = true;
            this.cbIgnoreIdZero.CheckedChanged += new System.EventHandler(this.ctrlTileMap_Changed);
            // 
            // tabPalettes
            // 
            this.tabPalettes.Controls.Add(this.grdPalettes);
            this.tabPalettes.Location = new System.Drawing.Point(4, 22);
            this.tabPalettes.Name = "tabPalettes";
            this.tabPalettes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPalettes.Size = new System.Drawing.Size(750, 479);
            this.tabPalettes.TabIndex = 6;
            this.tabPalettes.Text = "Palettes";
            this.tabPalettes.UseVisualStyleBackColor = true;
            // 
            // grdPalettes
            // 
            this.grdPalettes.AllowUserToAddRows = false;
            this.grdPalettes.AllowUserToDeleteRows = false;
            this.grdPalettes.AllowUserToResizeColumns = false;
            this.grdPalettes.AllowUserToResizeRows = false;
            this.grdPalettes.BackgroundColor = System.Drawing.Color.White;
            this.grdPalettes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdPalettes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdPalettes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdPalettes.ColumnHeadersHeight = 24;
            this.grdPalettes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdPalettes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPaletteName,
            this.colPaletteImage,
            this.colPaletteDataStart,
            this.colPaletteDataEnd,
            this.colPaletteDataSize});
            this.grdPalettes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPalettes.Location = new System.Drawing.Point(3, 3);
            this.grdPalettes.MultiSelect = false;
            this.grdPalettes.Name = "grdPalettes";
            this.grdPalettes.ReadOnly = true;
            this.grdPalettes.RowHeadersVisible = false;
            this.grdPalettes.RowTemplate.ReadOnly = true;
            this.grdPalettes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPalettes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdPalettes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPalettes.ShowCellErrors = false;
            this.grdPalettes.ShowCellToolTips = false;
            this.grdPalettes.ShowEditingIcon = false;
            this.grdPalettes.ShowRowErrors = false;
            this.grdPalettes.Size = new System.Drawing.Size(744, 473);
            this.grdPalettes.TabIndex = 1;
            // 
            // colPaletteName
            // 
            this.colPaletteName.DataPropertyName = "Name";
            this.colPaletteName.FillWeight = 50F;
            this.colPaletteName.HeaderText = "Palette Name";
            this.colPaletteName.MinimumWidth = 25;
            this.colPaletteName.Name = "colPaletteName";
            this.colPaletteName.ReadOnly = true;
            this.colPaletteName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colPaletteName.Width = 170;
            // 
            // colPaletteImage
            // 
            this.colPaletteImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPaletteImage.DataPropertyName = "PaletteImage";
            dataGridViewCellStyle4.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle4.NullValue")));
            this.colPaletteImage.DefaultCellStyle = dataGridViewCellStyle4;
            this.colPaletteImage.FillWeight = 50F;
            this.colPaletteImage.HeaderText = "Palette";
            this.colPaletteImage.MinimumWidth = 25;
            this.colPaletteImage.Name = "colPaletteImage";
            this.colPaletteImage.ReadOnly = true;
            this.colPaletteImage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colPaletteDataStart
            // 
            this.colPaletteDataStart.DataPropertyName = "DataStartString";
            this.colPaletteDataStart.HeaderText = "Data Start";
            this.colPaletteDataStart.MinimumWidth = 25;
            this.colPaletteDataStart.Name = "colPaletteDataStart";
            this.colPaletteDataStart.ReadOnly = true;
            this.colPaletteDataStart.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colPaletteDataStart.Width = 130;
            // 
            // colPaletteDataEnd
            // 
            this.colPaletteDataEnd.DataPropertyName = "DataEndString";
            this.colPaletteDataEnd.HeaderText = "Data End";
            this.colPaletteDataEnd.MinimumWidth = 25;
            this.colPaletteDataEnd.Name = "colPaletteDataEnd";
            this.colPaletteDataEnd.ReadOnly = true;
            this.colPaletteDataEnd.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colPaletteDataEnd.Width = 130;
            // 
            // colPaletteDataSize
            // 
            this.colPaletteDataSize.DataPropertyName = "Length";
            this.colPaletteDataSize.HeaderText = "Bytes";
            this.colPaletteDataSize.MinimumWidth = 25;
            this.colPaletteDataSize.Name = "colPaletteDataSize";
            this.colPaletteDataSize.ReadOnly = true;
            this.colPaletteDataSize.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colPaletteDataSize.Width = 45;
            // 
            // tabSpriteLab
            // 
            this.tabSpriteLab.Controls.Add(this.tpnlSpriteLab);
            this.tabSpriteLab.Location = new System.Drawing.Point(4, 22);
            this.tabSpriteLab.Name = "tabSpriteLab";
            this.tabSpriteLab.Padding = new System.Windows.Forms.Padding(3);
            this.tabSpriteLab.Size = new System.Drawing.Size(750, 479);
            this.tabSpriteLab.TabIndex = 5;
            this.tabSpriteLab.Text = "Sprite Lab";
            this.tabSpriteLab.UseVisualStyleBackColor = true;
            // 
            // tpnlSpriteLab
            // 
            this.tpnlSpriteLab.ColumnCount = 6;
            this.tpnlSpriteLab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlSpriteLab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tpnlSpriteLab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tpnlSpriteLab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tpnlSpriteLab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tpnlSpriteLab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tpnlSpriteLab.Controls.Add(this.cbSpriteLabSort, 5, 2);
            this.tpnlSpriteLab.Controls.Add(this.cbSpriteLabTilesets5, 2, 8);
            this.tpnlSpriteLab.Controls.Add(this.lblSpriteLabTileset5, 1, 8);
            this.tpnlSpriteLab.Controls.Add(this.cbSpriteLabTilesets4, 2, 7);
            this.tpnlSpriteLab.Controls.Add(this.lblSpriteLabTileset4, 1, 7);
            this.tpnlSpriteLab.Controls.Add(this.cbSpriteLabTilesets3, 2, 6);
            this.tpnlSpriteLab.Controls.Add(this.lblSpriteLabTileset3, 1, 6);
            this.tpnlSpriteLab.Controls.Add(this.cbSpriteLabTilesets2, 2, 5);
            this.tpnlSpriteLab.Controls.Add(this.lblSpriteLabTileset2, 1, 5);
            this.tpnlSpriteLab.Controls.Add(this.cbSpriteLabTilesets1, 2, 4);
            this.tpnlSpriteLab.Controls.Add(this.cbSpriteLabScale, 2, 1);
            this.tpnlSpriteLab.Controls.Add(this.lblSpriteLabScale, 1, 1);
            this.tpnlSpriteLab.Controls.Add(this.numSpriteLabColumns, 2, 0);
            this.tpnlSpriteLab.Controls.Add(this.lblSpriteLabRows, 4, 0);
            this.tpnlSpriteLab.Controls.Add(this.numSpriteLabRows, 5, 0);
            this.tpnlSpriteLab.Controls.Add(this.lblSpriteLabColumns, 1, 0);
            this.tpnlSpriteLab.Controls.Add(this.lblSpriteLabTileMap, 1, 3);
            this.tpnlSpriteLab.Controls.Add(this.pnlSpriteLab, 0, 0);
            this.tpnlSpriteLab.Controls.Add(this.cbSpriteLabTileMaps, 2, 3);
            this.tpnlSpriteLab.Controls.Add(this.chkSpriteLabUseBlackBackground, 3, 1);
            this.tpnlSpriteLab.Controls.Add(this.lblSpriteLabTileset1, 1, 4);
            this.tpnlSpriteLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlSpriteLab.Location = new System.Drawing.Point(3, 3);
            this.tpnlSpriteLab.Name = "tpnlSpriteLab";
            this.tpnlSpriteLab.RowCount = 10;
            this.tpnlSpriteLab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlSpriteLab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlSpriteLab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlSpriteLab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlSpriteLab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlSpriteLab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlSpriteLab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlSpriteLab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlSpriteLab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlSpriteLab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlSpriteLab.Size = new System.Drawing.Size(744, 473);
            this.tpnlSpriteLab.TabIndex = 1;
            // 
            // cbSpriteLabSort
            // 
            this.cbSpriteLabSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSpriteLabSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpriteLabSort.FormattingEnabled = true;
            this.cbSpriteLabSort.Location = new System.Drawing.Point(677, 55);
            this.cbSpriteLabSort.Name = "cbSpriteLabSort";
            this.cbSpriteLabSort.Size = new System.Drawing.Size(64, 21);
            this.cbSpriteLabSort.TabIndex = 21;
            this.cbSpriteLabSort.SelectedIndexChanged += new System.EventHandler(this.cbSort_SelectedIndexChanged);
            // 
            // cbSpriteLabTilesets5
            // 
            this.tpnlSpriteLab.SetColumnSpan(this.cbSpriteLabTilesets5, 4);
            this.cbSpriteLabTilesets5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSpriteLabTilesets5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpriteLabTilesets5.FormattingEnabled = true;
            this.cbSpriteLabTilesets5.Location = new System.Drawing.Point(557, 211);
            this.cbSpriteLabTilesets5.Name = "cbSpriteLabTilesets5";
            this.cbSpriteLabTilesets5.Size = new System.Drawing.Size(184, 21);
            this.cbSpriteLabTilesets5.TabIndex = 20;
            this.cbSpriteLabTilesets5.SelectedIndexChanged += new System.EventHandler(this.ctrlSpriteLab_Changed);
            // 
            // lblSpriteLabTileset5
            // 
            this.lblSpriteLabTileset5.AutoSize = true;
            this.lblSpriteLabTileset5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSpriteLabTileset5.Location = new System.Drawing.Point(495, 208);
            this.lblSpriteLabTileset5.Name = "lblSpriteLabTileset5";
            this.lblSpriteLabTileset5.Size = new System.Drawing.Size(56, 26);
            this.lblSpriteLabTileset5.TabIndex = 19;
            this.lblSpriteLabTileset5.Text = "Tileset 5:";
            this.lblSpriteLabTileset5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbSpriteLabTilesets4
            // 
            this.tpnlSpriteLab.SetColumnSpan(this.cbSpriteLabTilesets4, 4);
            this.cbSpriteLabTilesets4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSpriteLabTilesets4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpriteLabTilesets4.FormattingEnabled = true;
            this.cbSpriteLabTilesets4.Location = new System.Drawing.Point(557, 185);
            this.cbSpriteLabTilesets4.Name = "cbSpriteLabTilesets4";
            this.cbSpriteLabTilesets4.Size = new System.Drawing.Size(184, 21);
            this.cbSpriteLabTilesets4.TabIndex = 18;
            this.cbSpriteLabTilesets4.SelectedIndexChanged += new System.EventHandler(this.ctrlSpriteLab_Changed);
            // 
            // lblSpriteLabTileset4
            // 
            this.lblSpriteLabTileset4.AutoSize = true;
            this.lblSpriteLabTileset4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSpriteLabTileset4.Location = new System.Drawing.Point(495, 182);
            this.lblSpriteLabTileset4.Name = "lblSpriteLabTileset4";
            this.lblSpriteLabTileset4.Size = new System.Drawing.Size(56, 26);
            this.lblSpriteLabTileset4.TabIndex = 17;
            this.lblSpriteLabTileset4.Text = "Tileset 4:";
            this.lblSpriteLabTileset4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbSpriteLabTilesets3
            // 
            this.tpnlSpriteLab.SetColumnSpan(this.cbSpriteLabTilesets3, 4);
            this.cbSpriteLabTilesets3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSpriteLabTilesets3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpriteLabTilesets3.FormattingEnabled = true;
            this.cbSpriteLabTilesets3.Location = new System.Drawing.Point(557, 159);
            this.cbSpriteLabTilesets3.Name = "cbSpriteLabTilesets3";
            this.cbSpriteLabTilesets3.Size = new System.Drawing.Size(184, 21);
            this.cbSpriteLabTilesets3.TabIndex = 16;
            this.cbSpriteLabTilesets3.SelectedIndexChanged += new System.EventHandler(this.ctrlSpriteLab_Changed);
            // 
            // lblSpriteLabTileset3
            // 
            this.lblSpriteLabTileset3.AutoSize = true;
            this.lblSpriteLabTileset3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSpriteLabTileset3.Location = new System.Drawing.Point(495, 156);
            this.lblSpriteLabTileset3.Name = "lblSpriteLabTileset3";
            this.lblSpriteLabTileset3.Size = new System.Drawing.Size(56, 26);
            this.lblSpriteLabTileset3.TabIndex = 15;
            this.lblSpriteLabTileset3.Text = "Tileset 3:";
            this.lblSpriteLabTileset3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbSpriteLabTilesets2
            // 
            this.tpnlSpriteLab.SetColumnSpan(this.cbSpriteLabTilesets2, 4);
            this.cbSpriteLabTilesets2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSpriteLabTilesets2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpriteLabTilesets2.FormattingEnabled = true;
            this.cbSpriteLabTilesets2.Location = new System.Drawing.Point(557, 133);
            this.cbSpriteLabTilesets2.Name = "cbSpriteLabTilesets2";
            this.cbSpriteLabTilesets2.Size = new System.Drawing.Size(184, 21);
            this.cbSpriteLabTilesets2.TabIndex = 14;
            this.cbSpriteLabTilesets2.SelectedIndexChanged += new System.EventHandler(this.ctrlSpriteLab_Changed);
            // 
            // lblSpriteLabTileset2
            // 
            this.lblSpriteLabTileset2.AutoSize = true;
            this.lblSpriteLabTileset2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSpriteLabTileset2.Location = new System.Drawing.Point(495, 130);
            this.lblSpriteLabTileset2.Name = "lblSpriteLabTileset2";
            this.lblSpriteLabTileset2.Size = new System.Drawing.Size(56, 26);
            this.lblSpriteLabTileset2.TabIndex = 13;
            this.lblSpriteLabTileset2.Text = "Tileset 2:";
            this.lblSpriteLabTileset2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbSpriteLabTilesets1
            // 
            this.tpnlSpriteLab.SetColumnSpan(this.cbSpriteLabTilesets1, 4);
            this.cbSpriteLabTilesets1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSpriteLabTilesets1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpriteLabTilesets1.FormattingEnabled = true;
            this.cbSpriteLabTilesets1.Location = new System.Drawing.Point(557, 107);
            this.cbSpriteLabTilesets1.Name = "cbSpriteLabTilesets1";
            this.cbSpriteLabTilesets1.Size = new System.Drawing.Size(184, 21);
            this.cbSpriteLabTilesets1.TabIndex = 12;
            this.cbSpriteLabTilesets1.SelectedIndexChanged += new System.EventHandler(this.ctrlSpriteLab_Changed);
            // 
            // cbSpriteLabScale
            // 
            this.cbSpriteLabScale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSpriteLabScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpriteLabScale.Location = new System.Drawing.Point(557, 29);
            this.cbSpriteLabScale.Name = "cbSpriteLabScale";
            this.cbSpriteLabScale.Size = new System.Drawing.Size(37, 21);
            this.cbSpriteLabScale.TabIndex = 11;
            this.cbSpriteLabScale.SelectedIndexChanged += new System.EventHandler(this.ctrlSpriteLab_Changed);
            // 
            // lblSpriteLabScale
            // 
            this.lblSpriteLabScale.AutoSize = true;
            this.lblSpriteLabScale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSpriteLabScale.Location = new System.Drawing.Point(495, 26);
            this.lblSpriteLabScale.Name = "lblSpriteLabScale";
            this.lblSpriteLabScale.Size = new System.Drawing.Size(56, 26);
            this.lblSpriteLabScale.TabIndex = 10;
            this.lblSpriteLabScale.Text = "Scale:";
            this.lblSpriteLabScale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numSpriteLabColumns
            // 
            this.tpnlSpriteLab.SetColumnSpan(this.numSpriteLabColumns, 2);
            this.numSpriteLabColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numSpriteLabColumns.Location = new System.Drawing.Point(557, 3);
            this.numSpriteLabColumns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSpriteLabColumns.Name = "numSpriteLabColumns";
            this.numSpriteLabColumns.Size = new System.Drawing.Size(64, 22);
            this.numSpriteLabColumns.TabIndex = 3;
            this.numSpriteLabColumns.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSpriteLabColumns.ValueChanged += new System.EventHandler(this.ctrlSpriteLab_Changed);
            // 
            // lblSpriteLabRows
            // 
            this.lblSpriteLabRows.AutoSize = true;
            this.lblSpriteLabRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSpriteLabRows.Location = new System.Drawing.Point(627, 0);
            this.lblSpriteLabRows.Name = "lblSpriteLabRows";
            this.lblSpriteLabRows.Size = new System.Drawing.Size(44, 26);
            this.lblSpriteLabRows.TabIndex = 4;
            this.lblSpriteLabRows.Text = "Rows:";
            this.lblSpriteLabRows.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numSpriteLabRows
            // 
            this.numSpriteLabRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numSpriteLabRows.Location = new System.Drawing.Point(677, 3);
            this.numSpriteLabRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSpriteLabRows.Name = "numSpriteLabRows";
            this.numSpriteLabRows.Size = new System.Drawing.Size(64, 22);
            this.numSpriteLabRows.TabIndex = 5;
            this.numSpriteLabRows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSpriteLabRows.ValueChanged += new System.EventHandler(this.ctrlSpriteLab_Changed);
            // 
            // lblSpriteLabColumns
            // 
            this.lblSpriteLabColumns.AutoSize = true;
            this.lblSpriteLabColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSpriteLabColumns.Location = new System.Drawing.Point(495, 0);
            this.lblSpriteLabColumns.Name = "lblSpriteLabColumns";
            this.lblSpriteLabColumns.Size = new System.Drawing.Size(56, 26);
            this.lblSpriteLabColumns.TabIndex = 2;
            this.lblSpriteLabColumns.Text = "Columns:";
            this.lblSpriteLabColumns.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSpriteLabTileMap
            // 
            this.lblSpriteLabTileMap.AutoSize = true;
            this.lblSpriteLabTileMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSpriteLabTileMap.Location = new System.Drawing.Point(495, 78);
            this.lblSpriteLabTileMap.Name = "lblSpriteLabTileMap";
            this.lblSpriteLabTileMap.Size = new System.Drawing.Size(56, 26);
            this.lblSpriteLabTileMap.TabIndex = 0;
            this.lblSpriteLabTileMap.Text = "Tile Map:";
            this.lblSpriteLabTileMap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSpriteLab
            // 
            this.pnlSpriteLab.AutoScroll = true;
            this.pnlSpriteLab.AutoScrollMinSize = new System.Drawing.Size(486, 467);
            this.pnlSpriteLab.BackColor = System.Drawing.Color.White;
            this.pnlSpriteLab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlSpriteLab.Centered = true;
            this.pnlSpriteLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSpriteLab.Image = null;
            this.pnlSpriteLab.ImageScale = 1;
            this.pnlSpriteLab.Location = new System.Drawing.Point(3, 3);
            this.pnlSpriteLab.Name = "pnlSpriteLab";
            this.tpnlSpriteLab.SetRowSpan(this.pnlSpriteLab, 10);
            this.pnlSpriteLab.Size = new System.Drawing.Size(486, 467);
            this.pnlSpriteLab.TabIndex = 7;
            // 
            // cbSpriteLabTileMaps
            // 
            this.tpnlSpriteLab.SetColumnSpan(this.cbSpriteLabTileMaps, 4);
            this.cbSpriteLabTileMaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSpriteLabTileMaps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpriteLabTileMaps.FormattingEnabled = true;
            this.cbSpriteLabTileMaps.Location = new System.Drawing.Point(557, 81);
            this.cbSpriteLabTileMaps.Name = "cbSpriteLabTileMaps";
            this.cbSpriteLabTileMaps.Size = new System.Drawing.Size(184, 21);
            this.cbSpriteLabTileMaps.TabIndex = 1;
            this.cbSpriteLabTileMaps.SelectedIndexChanged += new System.EventHandler(this.cbLabTileMaps_SelectedIndexChanged);
            // 
            // chkSpriteLabUseBlackBackground
            // 
            this.chkSpriteLabUseBlackBackground.AutoSize = true;
            this.tpnlSpriteLab.SetColumnSpan(this.chkSpriteLabUseBlackBackground, 3);
            this.chkSpriteLabUseBlackBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkSpriteLabUseBlackBackground.Location = new System.Drawing.Point(600, 31);
            this.chkSpriteLabUseBlackBackground.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.chkSpriteLabUseBlackBackground.Name = "chkSpriteLabUseBlackBackground";
            this.chkSpriteLabUseBlackBackground.Size = new System.Drawing.Size(141, 18);
            this.chkSpriteLabUseBlackBackground.TabIndex = 6;
            this.chkSpriteLabUseBlackBackground.Text = "Use Black Background";
            this.chkSpriteLabUseBlackBackground.UseVisualStyleBackColor = true;
            this.chkSpriteLabUseBlackBackground.CheckedChanged += new System.EventHandler(this.ctrlSpriteLab_Changed);
            // 
            // lblSpriteLabTileset1
            // 
            this.lblSpriteLabTileset1.AutoSize = true;
            this.lblSpriteLabTileset1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSpriteLabTileset1.Location = new System.Drawing.Point(495, 104);
            this.lblSpriteLabTileset1.Name = "lblSpriteLabTileset1";
            this.lblSpriteLabTileset1.Size = new System.Drawing.Size(56, 26);
            this.lblSpriteLabTileset1.TabIndex = 9;
            this.lblSpriteLabTileset1.Text = "Tileset 1:";
            this.lblSpriteLabTileset1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(981, 2);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(44, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSave.Location = new System.Drawing.Point(583, 0);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(33, 26);
            this.lblSave.TabIndex = 1;
            this.lblSave.Text = "Save:";
            this.lblSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSprite
            // 
            this.lblSprite.AutoSize = true;
            this.lblSprite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSprite.Location = new System.Drawing.Point(267, 0);
            this.lblSprite.Name = "lblSprite";
            this.lblSprite.Size = new System.Drawing.Size(40, 26);
            this.lblSprite.TabIndex = 7;
            this.lblSprite.Text = "Sprite:";
            this.lblSprite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GraphicsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tpnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GraphicsControl";
            this.Size = new System.Drawing.Size(1028, 537);
            this.tpnlMain.ResumeLayout(false);
            this.tpnlMain.PerformLayout();
            this.grpSpriteSelect.ResumeLayout(false);
            this.tpnlSpriteSelect.ResumeLayout(false);
            this.tpnlSpriteSelect.PerformLayout();
            this.pnlPaletteGroupsBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPaletteGroups)).EndInit();
            this.pnlSpritesBorder.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabSprite.ResumeLayout(false);
            this.tpnlSprite.ResumeLayout(false);
            this.tpnlSprite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpriteRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpriteColumns)).EndInit();
            this.tabSpriteTilesets.ResumeLayout(false);
            this.tpnlSpriteTilesets.ResumeLayout(false);
            this.tpnlSpriteTilesets.PerformLayout();
            this.tabSpriteTileMaps.ResumeLayout(false);
            this.tpnlSpriteTileMaps.ResumeLayout(false);
            this.tpnlSpriteTileMaps.PerformLayout();
            this.tabTilesets.ResumeLayout(false);
            this.tpnlTilesets.ResumeLayout(false);
            this.tpnlTilesets.PerformLayout();
            this.tabTileMaps.ResumeLayout(false);
            this.tpnlTileMaps.ResumeLayout(false);
            this.tpnlTileMaps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTileMapsColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTileMapRows)).EndInit();
            this.tabPalettes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPalettes)).EndInit();
            this.tabSpriteLab.ResumeLayout(false);
            this.tpnlSpriteLab.ResumeLayout(false);
            this.tpnlSpriteLab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpriteLabColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpriteLabRows)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tpnlMain;
        private System.Windows.Forms.ComboBox cbPaletteGroupsSort;
        private System.Windows.Forms.ComboBox cbPaletteGroups;
        private System.Windows.Forms.GroupBox grpSpriteSelect;
        private System.Windows.Forms.TableLayoutPanel tpnlSpriteSelect;
        private System.Windows.Forms.Label lblSprites;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabSprite;
        private System.Windows.Forms.TableLayoutPanel tpnlSprite;
        private System.Windows.Forms.NumericUpDown numSpriteRows;
        private System.Windows.Forms.Label lblTabSpriteRows;
        private System.Windows.Forms.NumericUpDown numSpriteColumns;
        private System.Windows.Forms.Label lblTabSpriteColumns;
        private System.Windows.Forms.ComboBox cbSpriteScale;
        private Rika.Controls.ImagePanel pnlSprite;
        private System.Windows.Forms.Label lblSpriteScale;
        private System.Windows.Forms.TabPage tabSpriteTilesets;
        private System.Windows.Forms.TableLayoutPanel tpnlSpriteTilesets;
        private Rika.Controls.ImagePanel pnlSpriteTilesets;
        private System.Windows.Forms.TabPage tabSpriteTileMaps;
        private System.Windows.Forms.TableLayoutPanel tpnlSpriteTileMaps;
        private Rika.Controls.ImagePanel pnlSpriteTileMaps;
        private System.Windows.Forms.ComboBox cbSpritesSort;
        private System.Windows.Forms.Panel pnlPaletteGroupsBorder;
        private System.Windows.Forms.DataGridView grdPaletteGroups;
        private System.Windows.Forms.DataGridViewImageColumn colPalette;
        private System.Windows.Forms.Label lblPaletteGroups;
        private System.Windows.Forms.ComboBox cbSaveAs;
        private System.Windows.Forms.Label lblSaveAs;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlSpritesBorder;
        private System.Windows.Forms.TreeView trSprites;
        private System.Windows.Forms.TabPage tabTilesets;
        private System.Windows.Forms.TableLayoutPanel tpnlTilesets;
        private System.Windows.Forms.Label lblTileset;
        private System.Windows.Forms.ComboBox cbTilesetScale;
        private ImagePanel pnlTilesets;
        private System.Windows.Forms.Label lblTilesetScale;
        private System.Windows.Forms.TabPage tabTileMaps;
        private System.Windows.Forms.ComboBox cbTilesets;
        private System.Windows.Forms.ComboBox cbSpriteTilesets;
        private System.Windows.Forms.Label lblSpriteTileset;
        private System.Windows.Forms.ComboBox cbSpriteTileMaps;
        private System.Windows.Forms.Label lblSpriteTileMap;
        private System.Windows.Forms.ComboBox cbSave;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.TableLayoutPanel tpnlTileMaps;
        private System.Windows.Forms.NumericUpDown numTileMapsColumns;
        private System.Windows.Forms.Label lblTileMapRows;
        private System.Windows.Forms.NumericUpDown numTileMapRows;
        private System.Windows.Forms.Label lblTileMapColumns;
        private System.Windows.Forms.Label lblTileMap;
        private ImagePanel pnlTileMaps;
        private System.Windows.Forms.ComboBox cbTileMaps;
        private System.Windows.Forms.CheckBox cbIgnoreIdZero;
        private System.Windows.Forms.CheckBox cbSpriteIgnoreIdZero;
        private System.Windows.Forms.CheckBox chkUseBlackBackground;
        private System.Windows.Forms.TabPage tabSpriteLab;
        private System.Windows.Forms.TableLayoutPanel tpnlSpriteLab;
        private System.Windows.Forms.NumericUpDown numSpriteLabColumns;
        private System.Windows.Forms.Label lblSpriteLabRows;
        private System.Windows.Forms.NumericUpDown numSpriteLabRows;
        private System.Windows.Forms.Label lblSpriteLabColumns;
        private System.Windows.Forms.Label lblSpriteLabTileMap;
        private ImagePanel pnlSpriteLab;
        private System.Windows.Forms.ComboBox cbSpriteLabTileMaps;
        private System.Windows.Forms.CheckBox chkSpriteLabUseBlackBackground;
        private System.Windows.Forms.Label lblSpriteLabTileset1;
        private System.Windows.Forms.ComboBox cbSpriteLabScale;
        private System.Windows.Forms.Label lblSpriteLabScale;
        private System.Windows.Forms.ComboBox cbSpriteLabTilesets1;
        private System.Windows.Forms.ComboBox cbSpriteLabTilesets4;
        private System.Windows.Forms.Label lblSpriteLabTileset4;
        private System.Windows.Forms.ComboBox cbSpriteLabTilesets3;
        private System.Windows.Forms.Label lblSpriteLabTileset3;
        private System.Windows.Forms.ComboBox cbSpriteLabTilesets2;
        private System.Windows.Forms.Label lblSpriteLabTileset2;
        private System.Windows.Forms.ComboBox cbSpriteLabTilesets5;
        private System.Windows.Forms.Label lblSpriteLabTileset5;
        private System.Windows.Forms.ComboBox cbSpriteLabSort;
        private System.Windows.Forms.TabPage tabPalettes;
        private System.Windows.Forms.DataGridView grdPalettes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaletteName;
        private System.Windows.Forms.DataGridViewImageColumn colPaletteImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaletteDataStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaletteDataEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaletteDataSize;
        private System.Windows.Forms.Label lblSprite;
        private System.Windows.Forms.Label lblSpriteName;
        private System.Windows.Forms.ComboBox cbTilesetsSort;
        private System.Windows.Forms.ComboBox cbTileMapsSort;
    }
}
