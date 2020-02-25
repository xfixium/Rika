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
    partial class ItemsControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemsControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpItems = new System.Windows.Forms.GroupBox();
            this.tpnlItems = new System.Windows.Forms.TableLayoutPanel();
            this.txtGameName = new System.Windows.Forms.TextBox();
            this.lblGameName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.cbItemElementFilter = new System.Windows.Forms.ComboBox();
            this.cbItemTypeFilter = new System.Windows.Forms.ComboBox();
            this.cbItemCharacterFilter = new System.Windows.Forms.ComboBox();
            this.pnlItemsBorder = new System.Windows.Forms.Panel();
            this.grdItems = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEligibleCharacters = new System.Windows.Forms.DataGridViewImageColumn();
            this.colMeseta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDefense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMagicDefense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStrength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMental = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAgility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDexterity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colElement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEffect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTarget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHitChance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblItemCharacterFilter = new System.Windows.Forms.Label();
            this.lblItemTypeFilter = new System.Windows.Forms.Label();
            this.btnItemFilterClear = new System.Windows.Forms.Button();
            this.cbItemsSort = new System.Windows.Forms.ComboBox();
            this.cbItemEffectFilter = new System.Windows.Forms.ComboBox();
            this.lblItemEffectFilter = new System.Windows.Forms.Label();
            this.lblItemElementFilter = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.grpItems.SuspendLayout();
            this.tpnlItems.SuspendLayout();
            this.pnlItemsBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdItems)).BeginInit();
            this.SuspendLayout();
            // 
            // grpItems
            // 
            this.grpItems.Controls.Add(this.tpnlItems);
            this.grpItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpItems.Location = new System.Drawing.Point(0, 0);
            this.grpItems.Name = "grpItems";
            this.grpItems.Padding = new System.Windows.Forms.Padding(14, 6, 14, 16);
            this.grpItems.Size = new System.Drawing.Size(1028, 538);
            this.grpItems.TabIndex = 0;
            this.grpItems.TabStop = false;
            this.grpItems.Text = "Items";
            // 
            // tpnlItems
            // 
            this.tpnlItems.ColumnCount = 10;
            this.tpnlItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tpnlItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tpnlItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tpnlItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tpnlItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tpnlItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tpnlItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tpnlItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tpnlItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tpnlItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tpnlItems.Controls.Add(this.txtGameName, 1, 0);
            this.tpnlItems.Controls.Add(this.lblGameName, 0, 0);
            this.tpnlItems.Controls.Add(this.lblDescription, 2, 0);
            this.tpnlItems.Controls.Add(this.cbItemElementFilter, 5, 1);
            this.tpnlItems.Controls.Add(this.cbItemTypeFilter, 3, 1);
            this.tpnlItems.Controls.Add(this.cbItemCharacterFilter, 1, 1);
            this.tpnlItems.Controls.Add(this.pnlItemsBorder, 0, 2);
            this.tpnlItems.Controls.Add(this.lblItemCharacterFilter, 0, 1);
            this.tpnlItems.Controls.Add(this.lblItemTypeFilter, 2, 1);
            this.tpnlItems.Controls.Add(this.btnItemFilterClear, 8, 1);
            this.tpnlItems.Controls.Add(this.cbItemsSort, 9, 1);
            this.tpnlItems.Controls.Add(this.cbItemEffectFilter, 7, 1);
            this.tpnlItems.Controls.Add(this.lblItemEffectFilter, 6, 1);
            this.tpnlItems.Controls.Add(this.lblItemElementFilter, 4, 1);
            this.tpnlItems.Controls.Add(this.txtDescription, 3, 0);
            this.tpnlItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnlItems.Location = new System.Drawing.Point(14, 21);
            this.tpnlItems.Name = "tpnlItems";
            this.tpnlItems.RowCount = 3;
            this.tpnlItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tpnlItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlItems.Size = new System.Drawing.Size(1000, 501);
            this.tpnlItems.TabIndex = 0;
            // 
            // txtGameName
            // 
            this.txtGameName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGameName.Location = new System.Drawing.Point(80, 3);
            this.txtGameName.Name = "txtGameName";
            this.txtGameName.Size = new System.Drawing.Size(142, 22);
            this.txtGameName.TabIndex = 1;
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGameName.Location = new System.Drawing.Point(3, 0);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(71, 26);
            this.lblGameName.TabIndex = 0;
            this.lblGameName.Text = "Game Name:";
            this.lblGameName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Location = new System.Drawing.Point(228, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(76, 26);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description:";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbItemElementFilter
            // 
            this.cbItemElementFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbItemElementFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItemElementFilter.Location = new System.Drawing.Point(518, 29);
            this.cbItemElementFilter.Name = "cbItemElementFilter";
            this.cbItemElementFilter.Size = new System.Drawing.Size(142, 21);
            this.cbItemElementFilter.TabIndex = 9;
            this.cbItemElementFilter.SelectedIndexChanged += new System.EventHandler(this.ctrlFilter_Event);
            // 
            // cbItemTypeFilter
            // 
            this.cbItemTypeFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbItemTypeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItemTypeFilter.Location = new System.Drawing.Point(310, 29);
            this.cbItemTypeFilter.Name = "cbItemTypeFilter";
            this.cbItemTypeFilter.Size = new System.Drawing.Size(142, 21);
            this.cbItemTypeFilter.TabIndex = 7;
            this.cbItemTypeFilter.SelectedIndexChanged += new System.EventHandler(this.ctrlFilter_Event);
            // 
            // cbItemCharacterFilter
            // 
            this.cbItemCharacterFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbItemCharacterFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItemCharacterFilter.Location = new System.Drawing.Point(80, 29);
            this.cbItemCharacterFilter.Name = "cbItemCharacterFilter";
            this.cbItemCharacterFilter.Size = new System.Drawing.Size(142, 21);
            this.cbItemCharacterFilter.TabIndex = 5;
            this.cbItemCharacterFilter.SelectedIndexChanged += new System.EventHandler(this.ctrlFilter_Event);
            // 
            // pnlItemsBorder
            // 
            this.pnlItemsBorder.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tpnlItems.SetColumnSpan(this.pnlItemsBorder, 10);
            this.pnlItemsBorder.Controls.Add(this.grdItems);
            this.pnlItemsBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlItemsBorder.Location = new System.Drawing.Point(3, 55);
            this.pnlItemsBorder.Name = "pnlItemsBorder";
            this.pnlItemsBorder.Padding = new System.Windows.Forms.Padding(1);
            this.pnlItemsBorder.Size = new System.Drawing.Size(994, 443);
            this.pnlItemsBorder.TabIndex = 14;
            // 
            // grdItems
            // 
            this.grdItems.AllowUserToAddRows = false;
            this.grdItems.AllowUserToDeleteRows = false;
            this.grdItems.AllowUserToResizeColumns = false;
            this.grdItems.AllowUserToResizeRows = false;
            this.grdItems.BackgroundColor = System.Drawing.Color.White;
            this.grdItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdItems.ColumnHeadersHeight = 40;
            this.grdItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colEligibleCharacters,
            this.colMeseta,
            this.colType,
            this.colAttack,
            this.colDefense,
            this.colMagicDefense,
            this.colStrength,
            this.colMental,
            this.colAgility,
            this.colDexterity,
            this.colElement,
            this.colEffect,
            this.colTarget,
            this.colHitChance,
            this.colPower});
            this.grdItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdItems.Location = new System.Drawing.Point(1, 1);
            this.grdItems.Name = "grdItems";
            this.grdItems.ReadOnly = true;
            this.grdItems.RowHeadersVisible = false;
            this.grdItems.RowTemplate.ReadOnly = true;
            this.grdItems.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grdItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdItems.ShowCellErrors = false;
            this.grdItems.ShowCellToolTips = false;
            this.grdItems.ShowEditingIcon = false;
            this.grdItems.ShowRowErrors = false;
            this.grdItems.Size = new System.Drawing.Size(992, 441);
            this.grdItems.TabIndex = 0;
            this.grdItems.SelectionChanged += new System.EventHandler(this.grdItems_SelectionChanged);
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.DataPropertyName = "CustomName";
            this.colName.FillWeight = 145F;
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 22;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colEligibleCharacters
            // 
            this.colEligibleCharacters.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEligibleCharacters.DataPropertyName = "EligibleCharactersImage";
            dataGridViewCellStyle22.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle22.NullValue")));
            this.colEligibleCharacters.DefaultCellStyle = dataGridViewCellStyle22;
            this.colEligibleCharacters.FillWeight = 160F;
            this.colEligibleCharacters.HeaderText = "Characters";
            this.colEligibleCharacters.MinimumWidth = 25;
            this.colEligibleCharacters.Name = "colEligibleCharacters";
            this.colEligibleCharacters.ReadOnly = true;
            this.colEligibleCharacters.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colMeseta
            // 
            this.colMeseta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMeseta.DataPropertyName = "Meseta";
            this.colMeseta.FillWeight = 73.47598F;
            this.colMeseta.HeaderText = "Meseta";
            this.colMeseta.Name = "colMeseta";
            this.colMeseta.ReadOnly = true;
            this.colMeseta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colType
            // 
            this.colType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colType.DataPropertyName = "TypeName";
            this.colType.FillWeight = 186.2559F;
            this.colType.HeaderText = "Type";
            this.colType.MinimumWidth = 28;
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            this.colType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colAttack
            // 
            this.colAttack.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAttack.DataPropertyName = "Attack";
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Red;
            this.colAttack.DefaultCellStyle = dataGridViewCellStyle23;
            this.colAttack.FillWeight = 50F;
            this.colAttack.HeaderText = "ATK";
            this.colAttack.Name = "colAttack";
            this.colAttack.ReadOnly = true;
            this.colAttack.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colDefense
            // 
            this.colDefense.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDefense.DataPropertyName = "Defense";
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Blue;
            this.colDefense.DefaultCellStyle = dataGridViewCellStyle24;
            this.colDefense.FillWeight = 50F;
            this.colDefense.HeaderText = "DEF";
            this.colDefense.Name = "colDefense";
            this.colDefense.ReadOnly = true;
            this.colDefense.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colMagicDefense
            // 
            this.colMagicDefense.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMagicDefense.DataPropertyName = "MagicDefense";
            this.colMagicDefense.FillWeight = 50F;
            this.colMagicDefense.HeaderText = "MAG DEF";
            this.colMagicDefense.Name = "colMagicDefense";
            this.colMagicDefense.ReadOnly = true;
            this.colMagicDefense.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colStrength
            // 
            this.colStrength.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStrength.DataPropertyName = "Strength";
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.Red;
            this.colStrength.DefaultCellStyle = dataGridViewCellStyle25;
            this.colStrength.FillWeight = 50F;
            this.colStrength.HeaderText = "STR";
            this.colStrength.Name = "colStrength";
            this.colStrength.ReadOnly = true;
            this.colStrength.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colMental
            // 
            this.colMental.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMental.DataPropertyName = "Mental";
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Blue;
            this.colMental.DefaultCellStyle = dataGridViewCellStyle26;
            this.colMental.FillWeight = 50F;
            this.colMental.HeaderText = "MEN";
            this.colMental.Name = "colMental";
            this.colMental.ReadOnly = true;
            this.colMental.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colAgility
            // 
            this.colAgility.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAgility.DataPropertyName = "Agility";
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Purple;
            this.colAgility.DefaultCellStyle = dataGridViewCellStyle27;
            this.colAgility.FillWeight = 50F;
            this.colAgility.HeaderText = "AGL";
            this.colAgility.Name = "colAgility";
            this.colAgility.ReadOnly = true;
            this.colAgility.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colDexterity
            // 
            this.colDexterity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDexterity.DataPropertyName = "Dexterity";
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.colDexterity.DefaultCellStyle = dataGridViewCellStyle28;
            this.colDexterity.FillWeight = 50F;
            this.colDexterity.HeaderText = "DEX";
            this.colDexterity.Name = "colDexterity";
            this.colDexterity.ReadOnly = true;
            this.colDexterity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colElement
            // 
            this.colElement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colElement.DataPropertyName = "ElementName";
            this.colElement.FillWeight = 60F;
            this.colElement.HeaderText = "Element";
            this.colElement.MinimumWidth = 60;
            this.colElement.Name = "colElement";
            this.colElement.ReadOnly = true;
            this.colElement.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colEffect
            // 
            this.colEffect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEffect.DataPropertyName = "EffectName";
            this.colEffect.FillWeight = 140F;
            this.colEffect.HeaderText = "Effect";
            this.colEffect.MinimumWidth = 20;
            this.colEffect.Name = "colEffect";
            this.colEffect.ReadOnly = true;
            this.colEffect.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colTarget
            // 
            this.colTarget.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTarget.DataPropertyName = "EffectTargetName";
            this.colTarget.FillWeight = 140F;
            this.colTarget.HeaderText = "Effect Target";
            this.colTarget.MinimumWidth = 20;
            this.colTarget.Name = "colTarget";
            this.colTarget.ReadOnly = true;
            this.colTarget.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colHitChance
            // 
            this.colHitChance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colHitChance.DataPropertyName = "EffectChance";
            this.colHitChance.FillWeight = 73.47598F;
            this.colHitChance.HeaderText = "Effect Chance";
            this.colHitChance.Name = "colHitChance";
            this.colHitChance.ReadOnly = true;
            this.colHitChance.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colPower
            // 
            this.colPower.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPower.DataPropertyName = "EffectAmount";
            this.colPower.FillWeight = 73.47598F;
            this.colPower.HeaderText = "Effect Amount";
            this.colPower.Name = "colPower";
            this.colPower.ReadOnly = true;
            this.colPower.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // lblItemCharacterFilter
            // 
            this.lblItemCharacterFilter.AutoSize = true;
            this.lblItemCharacterFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblItemCharacterFilter.Location = new System.Drawing.Point(3, 26);
            this.lblItemCharacterFilter.Name = "lblItemCharacterFilter";
            this.lblItemCharacterFilter.Size = new System.Drawing.Size(71, 26);
            this.lblItemCharacterFilter.TabIndex = 4;
            this.lblItemCharacterFilter.Text = "Character:";
            this.lblItemCharacterFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblItemTypeFilter
            // 
            this.lblItemTypeFilter.AutoSize = true;
            this.lblItemTypeFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblItemTypeFilter.Location = new System.Drawing.Point(228, 26);
            this.lblItemTypeFilter.Name = "lblItemTypeFilter";
            this.lblItemTypeFilter.Size = new System.Drawing.Size(76, 26);
            this.lblItemTypeFilter.TabIndex = 6;
            this.lblItemTypeFilter.Text = "Type:";
            this.lblItemTypeFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnItemFilterClear
            // 
            this.btnItemFilterClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnItemFilterClear.Location = new System.Drawing.Point(873, 28);
            this.btnItemFilterClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 1);
            this.btnItemFilterClear.Name = "btnItemFilterClear";
            this.btnItemFilterClear.Size = new System.Drawing.Size(27, 23);
            this.btnItemFilterClear.TabIndex = 12;
            this.btnItemFilterClear.Text = "X";
            this.btnItemFilterClear.UseVisualStyleBackColor = true;
            this.btnItemFilterClear.Click += new System.EventHandler(this.ctrlFilter_Event);
            // 
            // cbItemsSort
            // 
            this.cbItemsSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbItemsSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItemsSort.FormattingEnabled = true;
            this.cbItemsSort.Location = new System.Drawing.Point(905, 29);
            this.cbItemsSort.Name = "cbItemsSort";
            this.cbItemsSort.Size = new System.Drawing.Size(92, 21);
            this.cbItemsSort.TabIndex = 13;
            this.cbItemsSort.SelectedIndexChanged += new System.EventHandler(this.ctrlFilter_Event);
            // 
            // cbItemEffectFilter
            // 
            this.cbItemEffectFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbItemEffectFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItemEffectFilter.Location = new System.Drawing.Point(726, 29);
            this.cbItemEffectFilter.Name = "cbItemEffectFilter";
            this.cbItemEffectFilter.Size = new System.Drawing.Size(142, 21);
            this.cbItemEffectFilter.TabIndex = 11;
            this.cbItemEffectFilter.SelectedIndexChanged += new System.EventHandler(this.ctrlFilter_Event);
            // 
            // lblItemEffectFilter
            // 
            this.lblItemEffectFilter.AutoSize = true;
            this.lblItemEffectFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblItemEffectFilter.Location = new System.Drawing.Point(666, 26);
            this.lblItemEffectFilter.Name = "lblItemEffectFilter";
            this.lblItemEffectFilter.Size = new System.Drawing.Size(54, 26);
            this.lblItemEffectFilter.TabIndex = 10;
            this.lblItemEffectFilter.Text = "Effect:";
            this.lblItemEffectFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblItemElementFilter
            // 
            this.lblItemElementFilter.AutoSize = true;
            this.lblItemElementFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblItemElementFilter.Location = new System.Drawing.Point(458, 26);
            this.lblItemElementFilter.Name = "lblItemElementFilter";
            this.lblItemElementFilter.Size = new System.Drawing.Size(54, 26);
            this.lblItemElementFilter.TabIndex = 8;
            this.lblItemElementFilter.Text = "Element:";
            this.lblItemElementFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescription
            // 
            this.tpnlItems.SetColumnSpan(this.txtDescription, 7);
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.Location = new System.Drawing.Point(310, 3);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(687, 22);
            this.txtDescription.TabIndex = 3;
            // 
            // ItemsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpItems);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ItemsControl";
            this.Size = new System.Drawing.Size(1028, 538);
            this.grpItems.ResumeLayout(false);
            this.tpnlItems.ResumeLayout(false);
            this.tpnlItems.PerformLayout();
            this.pnlItemsBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpItems;
        private System.Windows.Forms.TableLayoutPanel tpnlItems;
        private System.Windows.Forms.ComboBox cbItemElementFilter;
        private System.Windows.Forms.ComboBox cbItemTypeFilter;
        private System.Windows.Forms.ComboBox cbItemCharacterFilter;
        private System.Windows.Forms.Panel pnlItemsBorder;
        private System.Windows.Forms.DataGridView grdItems;
        private System.Windows.Forms.Label lblItemCharacterFilter;
        private System.Windows.Forms.Label lblItemTypeFilter;
        private System.Windows.Forms.Button btnItemFilterClear;
        private System.Windows.Forms.ComboBox cbItemsSort;
        private System.Windows.Forms.ComboBox cbItemEffectFilter;
        private System.Windows.Forms.Label lblItemEffectFilter;
        private System.Windows.Forms.Label lblItemElementFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewImageColumn colEligibleCharacters;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMeseta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttack;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDefense;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMagicDefense;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStrength;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMental;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAgility;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDexterity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colElement;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEffect;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarget;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHitChance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPower;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtGameName;
        private System.Windows.Forms.Label lblGameName;
    }
}
