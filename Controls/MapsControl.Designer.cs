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
    partial class MapsControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapsControl));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabTileMap = new System.Windows.Forms.TabPage();
            this.tabTilesets = new System.Windows.Forms.TabPage();
            this.tpnlTilesets = new System.Windows.Forms.TableLayoutPanel();
            this.tabTransitions = new System.Windows.Forms.TabPage();
            this.tabDialogs = new System.Windows.Forms.TabPage();
            this.txtMapDialog = new System.Windows.Forms.TextBox();
            this.tabObjects = new System.Windows.Forms.TabPage();
            this.grpMaps = new System.Windows.Forms.GroupBox();
            this.pnlMapsBorder = new System.Windows.Forms.Panel();
            this.trMaps = new System.Windows.Forms.TreeView();
            this.pnlTileMap = new Rika.Controls.ImagePanel();
            this.tpnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTileset = new Rika.Controls.ImagePanel();
            this.lblTilesets = new System.Windows.Forms.Label();
            this.lstTilesets = new System.Windows.Forms.ListBox();
            this.pnlTilesetPalettesBorder = new System.Windows.Forms.Panel();
            this.grdTilesetPalettes = new System.Windows.Forms.DataGridView();
            this.colPalette = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblPalettes = new System.Windows.Forms.Label();
            this.cbTilesetScale = new System.Windows.Forms.ComboBox();
            this.lblTilesetScale = new System.Windows.Forms.Label();
            this.chkTilesetUseBlackBackground = new System.Windows.Forms.CheckBox();
            this.tabMain.SuspendLayout();
            this.tabTileMap.SuspendLayout();
            this.tabTilesets.SuspendLayout();
            this.tpnlTilesets.SuspendLayout();
            this.tabDialogs.SuspendLayout();
            this.grpMaps.SuspendLayout();
            this.pnlMapsBorder.SuspendLayout();
            this.tpnlMain.SuspendLayout();
            this.pnlTilesetPalettesBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTilesetPalettes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabTileMap);
            this.tabMain.Controls.Add(this.tabTilesets);
            this.tabMain.Controls.Add(this.tabTransitions);
            this.tabMain.Controls.Add(this.tabDialogs);
            this.tabMain.Controls.Add(this.tabObjects);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(267, 3);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(758, 532);
            this.tabMain.TabIndex = 2;
            // 
            // tabTileMap
            // 
            this.tabTileMap.BackColor = System.Drawing.Color.White;
            this.tabTileMap.Controls.Add(this.pnlTileMap);
            this.tabTileMap.Location = new System.Drawing.Point(4, 22);
            this.tabTileMap.Name = "tabTileMap";
            this.tabTileMap.Padding = new System.Windows.Forms.Padding(3);
            this.tabTileMap.Size = new System.Drawing.Size(750, 506);
            this.tabTileMap.TabIndex = 0;
            this.tabTileMap.Text = "Tile Map";
            // 
            // tabTilesets
            // 
            this.tabTilesets.BackColor = System.Drawing.Color.White;
            this.tabTilesets.Controls.Add(this.tpnlTilesets);
            this.tabTilesets.Location = new System.Drawing.Point(4, 22);
            this.tabTilesets.Name = "tabTilesets";
            this.tabTilesets.Padding = new System.Windows.Forms.Padding(3);
            this.tabTilesets.Size = new System.Drawing.Size(750, 506);
            this.tabTilesets.TabIndex = 1;
            this.tabTilesets.Text = "Tilesets";
            // 
            // tpnlTilesets
            // 
            this.tpnlTilesets.ColumnCount = 4;
            this.tpnlTilesets.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlTilesets.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tpnlTilesets.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tpnlTilesets.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tpnlTilesets.Controls.Add(this.cbTilesetScale, 2, 0);
            this.tpnlTilesets.Controls.Add(this.lblTilesetScale, 1, 0);
            this.tpnlTilesets.Controls.Add(this.chkTilesetUseBlackBackground, 3, 0);
            this.tpnlTilesets.Controls.Add(this.lblPalettes, 1, 1);
            this.tpnlTilesets.Controls.Add(this.pnlTilesetPalettesBorder, 1, 2);
            this.tpnlTilesets.Controls.Add(this.lstTilesets, 1, 4);
            this.tpnlTilesets.Controls.Add(this.lblTilesets, 1, 3);
            this.tpnlTilesets.Controls.Add(this.pnlTileset, 0, 0);
            this.tpnlTilesets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlTilesets.Location = new System.Drawing.Point(3, 3);
            this.tpnlTilesets.Name = "tpnlTilesets";
            this.tpnlTilesets.RowCount = 5;
            this.tpnlTilesets.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlTilesets.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlTilesets.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tpnlTilesets.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlTilesets.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlTilesets.Size = new System.Drawing.Size(744, 500);
            this.tpnlTilesets.TabIndex = 0;
            // 
            // tabTransitions
            // 
            this.tabTransitions.BackColor = System.Drawing.Color.White;
            this.tabTransitions.Location = new System.Drawing.Point(4, 22);
            this.tabTransitions.Name = "tabTransitions";
            this.tabTransitions.Padding = new System.Windows.Forms.Padding(3);
            this.tabTransitions.Size = new System.Drawing.Size(716, 512);
            this.tabTransitions.TabIndex = 3;
            this.tabTransitions.Text = "Transitions";
            // 
            // tabDialogs
            // 
            this.tabDialogs.Controls.Add(this.txtMapDialog);
            this.tabDialogs.Location = new System.Drawing.Point(4, 22);
            this.tabDialogs.Name = "tabDialogs";
            this.tabDialogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabDialogs.Size = new System.Drawing.Size(716, 512);
            this.tabDialogs.TabIndex = 4;
            this.tabDialogs.Text = "Dialog";
            this.tabDialogs.UseVisualStyleBackColor = true;
            // 
            // txtMapDialog
            // 
            this.txtMapDialog.BackColor = System.Drawing.Color.White;
            this.txtMapDialog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMapDialog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMapDialog.Location = new System.Drawing.Point(3, 3);
            this.txtMapDialog.Multiline = true;
            this.txtMapDialog.Name = "txtMapDialog";
            this.txtMapDialog.ReadOnly = true;
            this.txtMapDialog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMapDialog.Size = new System.Drawing.Size(710, 506);
            this.txtMapDialog.TabIndex = 0;
            // 
            // tabObjects
            // 
            this.tabObjects.Location = new System.Drawing.Point(4, 22);
            this.tabObjects.Name = "tabObjects";
            this.tabObjects.Padding = new System.Windows.Forms.Padding(3);
            this.tabObjects.Size = new System.Drawing.Size(716, 512);
            this.tabObjects.TabIndex = 5;
            this.tabObjects.Text = "Objects";
            this.tabObjects.UseVisualStyleBackColor = true;
            // 
            // grpMaps
            // 
            this.grpMaps.BackColor = System.Drawing.Color.White;
            this.grpMaps.Controls.Add(this.pnlMapsBorder);
            this.grpMaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMaps.Location = new System.Drawing.Point(3, 3);
            this.grpMaps.Name = "grpMaps";
            this.grpMaps.Padding = new System.Windows.Forms.Padding(14, 14, 14, 16);
            this.grpMaps.Size = new System.Drawing.Size(258, 532);
            this.grpMaps.TabIndex = 0;
            this.grpMaps.TabStop = false;
            this.grpMaps.Text = "Maps";
            // 
            // pnlMapsBorder
            // 
            this.pnlMapsBorder.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlMapsBorder.Controls.Add(this.trMaps);
            this.pnlMapsBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMapsBorder.Location = new System.Drawing.Point(14, 29);
            this.pnlMapsBorder.Name = "pnlMapsBorder";
            this.pnlMapsBorder.Padding = new System.Windows.Forms.Padding(1);
            this.pnlMapsBorder.Size = new System.Drawing.Size(230, 487);
            this.pnlMapsBorder.TabIndex = 19;
            // 
            // trMaps
            // 
            this.trMaps.BackColor = System.Drawing.Color.White;
            this.trMaps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trMaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trMaps.Location = new System.Drawing.Point(1, 1);
            this.trMaps.Name = "trMaps";
            this.trMaps.Size = new System.Drawing.Size(228, 485);
            this.trMaps.TabIndex = 0;
            this.trMaps.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trMaps_AfterSelect);
            // 
            // pnlTileMap
            // 
            this.pnlTileMap.AutoScroll = true;
            this.pnlTileMap.AutoScrollMinSize = new System.Drawing.Size(744, 500);
            this.pnlTileMap.BackColor = System.Drawing.Color.White;
            this.pnlTileMap.Centered = false;
            this.pnlTileMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTileMap.Image = null;
            this.pnlTileMap.ImageScale = 1;
            this.pnlTileMap.Location = new System.Drawing.Point(3, 3);
            this.pnlTileMap.Name = "pnlTileMap";
            this.pnlTileMap.Size = new System.Drawing.Size(744, 500);
            this.pnlTileMap.TabIndex = 0;
            // 
            // tpnlMain
            // 
            this.tpnlMain.ColumnCount = 2;
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 264F));
            this.tpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlMain.Controls.Add(this.grpMaps, 0, 0);
            this.tpnlMain.Controls.Add(this.tabMain, 1, 0);
            this.tpnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlMain.Location = new System.Drawing.Point(0, 0);
            this.tpnlMain.Name = "tpnlMain";
            this.tpnlMain.RowCount = 1;
            this.tpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlMain.Size = new System.Drawing.Size(1028, 538);
            this.tpnlMain.TabIndex = 3;
            // 
            // pnlTileset
            // 
            this.pnlTileset.AutoScroll = true;
            this.pnlTileset.AutoScrollMinSize = new System.Drawing.Size(484, 494);
            this.pnlTileset.BackColor = System.Drawing.Color.White;
            this.pnlTileset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlTileset.Centered = true;
            this.pnlTileset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTileset.Image = null;
            this.pnlTileset.ImageScale = 1;
            this.pnlTileset.Location = new System.Drawing.Point(3, 3);
            this.pnlTileset.Name = "pnlTileset";
            this.tpnlTilesets.SetRowSpan(this.pnlTileset, 5);
            this.pnlTileset.Size = new System.Drawing.Size(484, 494);
            this.pnlTileset.TabIndex = 2;
            // 
            // lblTilesets
            // 
            this.lblTilesets.AutoSize = true;
            this.tpnlTilesets.SetColumnSpan(this.lblTilesets, 3);
            this.lblTilesets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTilesets.Location = new System.Drawing.Point(493, 232);
            this.lblTilesets.Name = "lblTilesets";
            this.lblTilesets.Size = new System.Drawing.Size(248, 26);
            this.lblTilesets.TabIndex = 5;
            this.lblTilesets.Text = "Tilesets:";
            this.lblTilesets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstTilesets
            // 
            this.tpnlTilesets.SetColumnSpan(this.lstTilesets, 3);
            this.lstTilesets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTilesets.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstTilesets.FormattingEnabled = true;
            this.lstTilesets.IntegralHeight = false;
            this.lstTilesets.ItemHeight = 20;
            this.lstTilesets.Location = new System.Drawing.Point(493, 261);
            this.lstTilesets.Name = "lstTilesets";
            this.lstTilesets.Size = new System.Drawing.Size(248, 236);
            this.lstTilesets.TabIndex = 6;
            this.lstTilesets.SelectedIndexChanged += new System.EventHandler(this.lstMapTilesets_SelectedIndexChanged);
            // 
            // pnlTilesetPalettesBorder
            // 
            this.pnlTilesetPalettesBorder.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tpnlTilesets.SetColumnSpan(this.pnlTilesetPalettesBorder, 3);
            this.pnlTilesetPalettesBorder.Controls.Add(this.grdTilesetPalettes);
            this.pnlTilesetPalettesBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTilesetPalettesBorder.Location = new System.Drawing.Point(493, 55);
            this.pnlTilesetPalettesBorder.Name = "pnlTilesetPalettesBorder";
            this.pnlTilesetPalettesBorder.Padding = new System.Windows.Forms.Padding(1);
            this.pnlTilesetPalettesBorder.Size = new System.Drawing.Size(248, 174);
            this.pnlTilesetPalettesBorder.TabIndex = 7;
            // 
            // grdTilesetPalettes
            // 
            this.grdTilesetPalettes.AllowUserToAddRows = false;
            this.grdTilesetPalettes.AllowUserToDeleteRows = false;
            this.grdTilesetPalettes.AllowUserToResizeColumns = false;
            this.grdTilesetPalettes.AllowUserToResizeRows = false;
            this.grdTilesetPalettes.BackgroundColor = System.Drawing.Color.White;
            this.grdTilesetPalettes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdTilesetPalettes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdTilesetPalettes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdTilesetPalettes.ColumnHeadersHeight = 40;
            this.grdTilesetPalettes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdTilesetPalettes.ColumnHeadersVisible = false;
            this.grdTilesetPalettes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPalette});
            this.grdTilesetPalettes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTilesetPalettes.Location = new System.Drawing.Point(1, 1);
            this.grdTilesetPalettes.Name = "grdTilesetPalettes";
            this.grdTilesetPalettes.ReadOnly = true;
            this.grdTilesetPalettes.RowHeadersVisible = false;
            this.grdTilesetPalettes.RowTemplate.Height = 16;
            this.grdTilesetPalettes.RowTemplate.ReadOnly = true;
            this.grdTilesetPalettes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grdTilesetPalettes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdTilesetPalettes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTilesetPalettes.ShowCellErrors = false;
            this.grdTilesetPalettes.ShowCellToolTips = false;
            this.grdTilesetPalettes.ShowEditingIcon = false;
            this.grdTilesetPalettes.ShowRowErrors = false;
            this.grdTilesetPalettes.Size = new System.Drawing.Size(246, 172);
            this.grdTilesetPalettes.TabIndex = 0;
            this.grdTilesetPalettes.SelectionChanged += new System.EventHandler(this.grdMapPalettes_SelectionChanged);
            // 
            // colPalette
            // 
            this.colPalette.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPalette.DataPropertyName = "PaletteImage";
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            this.colPalette.DefaultCellStyle = dataGridViewCellStyle2;
            this.colPalette.FillWeight = 160F;
            this.colPalette.HeaderText = "Palettes";
            this.colPalette.MinimumWidth = 25;
            this.colPalette.Name = "colPalette";
            this.colPalette.ReadOnly = true;
            this.colPalette.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // lblPalettes
            // 
            this.lblPalettes.AutoSize = true;
            this.tpnlTilesets.SetColumnSpan(this.lblPalettes, 3);
            this.lblPalettes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPalettes.Location = new System.Drawing.Point(493, 26);
            this.lblPalettes.Name = "lblPalettes";
            this.lblPalettes.Size = new System.Drawing.Size(248, 26);
            this.lblPalettes.TabIndex = 8;
            this.lblPalettes.Text = "Palettes:";
            this.lblPalettes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbTilesetScale
            // 
            this.cbTilesetScale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTilesetScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTilesetScale.Location = new System.Drawing.Point(555, 3);
            this.cbTilesetScale.Name = "cbTilesetScale";
            this.cbTilesetScale.Size = new System.Drawing.Size(36, 21);
            this.cbTilesetScale.TabIndex = 14;
            this.cbTilesetScale.SelectedIndexChanged += new System.EventHandler(this.cbScale_SelectedIndexChanged);
            // 
            // lblTilesetScale
            // 
            this.lblTilesetScale.AutoSize = true;
            this.lblTilesetScale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTilesetScale.Location = new System.Drawing.Point(493, 0);
            this.lblTilesetScale.Name = "lblTilesetScale";
            this.lblTilesetScale.Size = new System.Drawing.Size(56, 26);
            this.lblTilesetScale.TabIndex = 13;
            this.lblTilesetScale.Text = "Scale:";
            this.lblTilesetScale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkTilesetUseBlackBackground
            // 
            this.chkTilesetUseBlackBackground.AutoSize = true;
            this.chkTilesetUseBlackBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkTilesetUseBlackBackground.Location = new System.Drawing.Point(597, 5);
            this.chkTilesetUseBlackBackground.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.chkTilesetUseBlackBackground.Name = "chkTilesetUseBlackBackground";
            this.chkTilesetUseBlackBackground.Size = new System.Drawing.Size(144, 18);
            this.chkTilesetUseBlackBackground.TabIndex = 12;
            this.chkTilesetUseBlackBackground.Text = "Use Black Background";
            this.chkTilesetUseBlackBackground.UseVisualStyleBackColor = true;
            // 
            // MapsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tpnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MapsControl";
            this.Size = new System.Drawing.Size(1028, 538);
            this.tabMain.ResumeLayout(false);
            this.tabTileMap.ResumeLayout(false);
            this.tabTilesets.ResumeLayout(false);
            this.tpnlTilesets.ResumeLayout(false);
            this.tpnlTilesets.PerformLayout();
            this.tabDialogs.ResumeLayout(false);
            this.tabDialogs.PerformLayout();
            this.grpMaps.ResumeLayout(false);
            this.pnlMapsBorder.ResumeLayout(false);
            this.tpnlMain.ResumeLayout(false);
            this.pnlTilesetPalettesBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTilesetPalettes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabTileMap;
        private System.Windows.Forms.TabPage tabTilesets;
        private System.Windows.Forms.TableLayoutPanel tpnlTilesets;
        private System.Windows.Forms.TabPage tabTransitions;
        private System.Windows.Forms.TabPage tabDialogs;
        private System.Windows.Forms.TextBox txtMapDialog;
        private System.Windows.Forms.TabPage tabObjects;
        private System.Windows.Forms.GroupBox grpMaps;
        private System.Windows.Forms.Panel pnlMapsBorder;
        private System.Windows.Forms.TreeView trMaps;
        private ImagePanel pnlTileMap;
        private System.Windows.Forms.TableLayoutPanel tpnlMain;
        private ImagePanel pnlTileset;
        private System.Windows.Forms.ListBox lstTilesets;
        private System.Windows.Forms.Label lblTilesets;
        private System.Windows.Forms.Label lblPalettes;
        private System.Windows.Forms.Panel pnlTilesetPalettesBorder;
        private System.Windows.Forms.DataGridView grdTilesetPalettes;
        private System.Windows.Forms.DataGridViewImageColumn colPalette;
        private System.Windows.Forms.ComboBox cbTilesetScale;
        private System.Windows.Forms.Label lblTilesetScale;
        private System.Windows.Forms.CheckBox chkTilesetUseBlackBackground;
    }
}
