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

namespace Rika.Forms
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataVerify = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRefactorGraphics = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabMaps = new System.Windows.Forms.TabPage();
            this.ctrlMaps = new Rika.Controls.MapsControl();
            this.tabCharacters = new System.Windows.Forms.TabPage();
            this.ctrlCharacters = new Rika.Controls.CharactersControl();
            this.tabEnemies = new System.Windows.Forms.TabPage();
            this.ctrlEnemies = new Rika.Controls.EnemiesControl();
            this.tabTechniquesSkills = new System.Windows.Forms.TabPage();
            this.ctrlTechniquesSkills = new Rika.Controls.TechniquesSkillsControl();
            this.tabCombinationsFormations = new System.Windows.Forms.TabPage();
            this.ctrlCombinationsFormations = new Rika.Controls.CombinationsFormationsControl();
            this.tabGraphics = new System.Windows.Forms.TabPage();
            this.ctrlGraphics = new Rika.Controls.GraphicsControl();
            this.tabItems = new System.Windows.Forms.TabPage();
            this.ctrlItems = new Rika.Controls.ItemsControl();
            this.tabDialogsShops = new System.Windows.Forms.TabPage();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tssSection = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssData = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssSelected = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssSelectedValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabMaps.SuspendLayout();
            this.tabCharacters.SuspendLayout();
            this.tabEnemies.SuspendLayout();
            this.tabTechniquesSkills.SuspendLayout();
            this.tabCombinationsFormations.SuspendLayout();
            this.tabGraphics.SuspendLayout();
            this.tabItems.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuTools,
            this.mnuAbout});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1084, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(180, 22);
            this.mnuOpen.Text = "Open ROM";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(180, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuTools
            // 
            this.mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDataVerify,
            this.mnuRefactorGraphics});
            this.mnuTools.Name = "mnuTools";
            this.mnuTools.Size = new System.Drawing.Size(48, 20);
            this.mnuTools.Text = "Tools";
            // 
            // mnuDataVerify
            // 
            this.mnuDataVerify.Name = "mnuDataVerify";
            this.mnuDataVerify.Size = new System.Drawing.Size(180, 22);
            this.mnuDataVerify.Text = "Data Verify";
            this.mnuDataVerify.Click += new System.EventHandler(this.mnuDataVerify_Click);
            // 
            // mnuRefactorGraphics
            // 
            this.mnuRefactorGraphics.Name = "mnuRefactorGraphics";
            this.mnuRefactorGraphics.Size = new System.Drawing.Size(180, 22);
            this.mnuRefactorGraphics.Text = "Refactor Sprite IDs";
            this.mnuRefactorGraphics.Click += new System.EventHandler(this.mnuRefactorGraphics_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(52, 20);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabMaps);
            this.tabMain.Controls.Add(this.tabCharacters);
            this.tabMain.Controls.Add(this.tabEnemies);
            this.tabMain.Controls.Add(this.tabTechniquesSkills);
            this.tabMain.Controls.Add(this.tabCombinationsFormations);
            this.tabMain.Controls.Add(this.tabGraphics);
            this.tabMain.Controls.Add(this.tabItems);
            this.tabMain.Controls.Add(this.tabDialogsShops);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(8, 8);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1068, 596);
            this.tabMain.TabIndex = 0;
            this.tabMain.Visible = false;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // tabMaps
            // 
            this.tabMaps.BackColor = System.Drawing.Color.White;
            this.tabMaps.Controls.Add(this.ctrlMaps);
            this.tabMaps.Location = new System.Drawing.Point(4, 22);
            this.tabMaps.Name = "tabMaps";
            this.tabMaps.Padding = new System.Windows.Forms.Padding(14);
            this.tabMaps.Size = new System.Drawing.Size(1060, 570);
            this.tabMaps.TabIndex = 4;
            this.tabMaps.Text = "Maps";
            // 
            // ctrlMaps
            // 
            this.ctrlMaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlMaps.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlMaps.Location = new System.Drawing.Point(14, 14);
            this.ctrlMaps.MainForm = null;
            this.ctrlMaps.Name = "ctrlMaps";
            this.ctrlMaps.Size = new System.Drawing.Size(1032, 542);
            this.ctrlMaps.TabIndex = 0;
            // 
            // tabCharacters
            // 
            this.tabCharacters.BackColor = System.Drawing.Color.White;
            this.tabCharacters.Controls.Add(this.ctrlCharacters);
            this.tabCharacters.Location = new System.Drawing.Point(4, 22);
            this.tabCharacters.Name = "tabCharacters";
            this.tabCharacters.Padding = new System.Windows.Forms.Padding(14);
            this.tabCharacters.Size = new System.Drawing.Size(1060, 570);
            this.tabCharacters.TabIndex = 2;
            this.tabCharacters.Text = "Characters";
            // 
            // ctrlCharacters
            // 
            this.ctrlCharacters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlCharacters.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlCharacters.Location = new System.Drawing.Point(14, 14);
            this.ctrlCharacters.MainForm = null;
            this.ctrlCharacters.Margin = new System.Windows.Forms.Padding(0);
            this.ctrlCharacters.Name = "ctrlCharacters";
            this.ctrlCharacters.Size = new System.Drawing.Size(1032, 542);
            this.ctrlCharacters.TabIndex = 0;
            // 
            // tabEnemies
            // 
            this.tabEnemies.Controls.Add(this.ctrlEnemies);
            this.tabEnemies.Location = new System.Drawing.Point(4, 22);
            this.tabEnemies.Name = "tabEnemies";
            this.tabEnemies.Padding = new System.Windows.Forms.Padding(14);
            this.tabEnemies.Size = new System.Drawing.Size(1060, 570);
            this.tabEnemies.TabIndex = 0;
            this.tabEnemies.Text = "Enemies";
            this.tabEnemies.UseVisualStyleBackColor = true;
            // 
            // ctrlEnemies
            // 
            this.ctrlEnemies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlEnemies.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlEnemies.Location = new System.Drawing.Point(14, 14);
            this.ctrlEnemies.MainForm = null;
            this.ctrlEnemies.Name = "ctrlEnemies";
            this.ctrlEnemies.Size = new System.Drawing.Size(1032, 542);
            this.ctrlEnemies.TabIndex = 0;
            // 
            // tabTechniquesSkills
            // 
            this.tabTechniquesSkills.Controls.Add(this.ctrlTechniquesSkills);
            this.tabTechniquesSkills.Location = new System.Drawing.Point(4, 22);
            this.tabTechniquesSkills.Name = "tabTechniquesSkills";
            this.tabTechniquesSkills.Padding = new System.Windows.Forms.Padding(14);
            this.tabTechniquesSkills.Size = new System.Drawing.Size(1060, 570);
            this.tabTechniquesSkills.TabIndex = 1;
            this.tabTechniquesSkills.Text = "Techniques/Skills";
            this.tabTechniquesSkills.UseVisualStyleBackColor = true;
            // 
            // ctrlTechniquesSkills
            // 
            this.ctrlTechniquesSkills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlTechniquesSkills.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTechniquesSkills.Location = new System.Drawing.Point(14, 14);
            this.ctrlTechniquesSkills.MainForm = null;
            this.ctrlTechniquesSkills.Name = "ctrlTechniquesSkills";
            this.ctrlTechniquesSkills.Size = new System.Drawing.Size(1032, 542);
            this.ctrlTechniquesSkills.TabIndex = 0;
            // 
            // tabCombinationsFormations
            // 
            this.tabCombinationsFormations.Controls.Add(this.ctrlCombinationsFormations);
            this.tabCombinationsFormations.Location = new System.Drawing.Point(4, 22);
            this.tabCombinationsFormations.Name = "tabCombinationsFormations";
            this.tabCombinationsFormations.Padding = new System.Windows.Forms.Padding(14);
            this.tabCombinationsFormations.Size = new System.Drawing.Size(1060, 570);
            this.tabCombinationsFormations.TabIndex = 6;
            this.tabCombinationsFormations.Text = "Combinations/Formations";
            this.tabCombinationsFormations.UseVisualStyleBackColor = true;
            // 
            // ctrlCombinationsFormations
            // 
            this.ctrlCombinationsFormations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlCombinationsFormations.Location = new System.Drawing.Point(14, 14);
            this.ctrlCombinationsFormations.MainForm = null;
            this.ctrlCombinationsFormations.Name = "ctrlCombinationsFormations";
            this.ctrlCombinationsFormations.Size = new System.Drawing.Size(1032, 542);
            this.ctrlCombinationsFormations.TabIndex = 0;
            // 
            // tabGraphics
            // 
            this.tabGraphics.Controls.Add(this.ctrlGraphics);
            this.tabGraphics.Location = new System.Drawing.Point(4, 22);
            this.tabGraphics.Name = "tabGraphics";
            this.tabGraphics.Padding = new System.Windows.Forms.Padding(14);
            this.tabGraphics.Size = new System.Drawing.Size(1060, 570);
            this.tabGraphics.TabIndex = 5;
            this.tabGraphics.Text = "Graphics";
            this.tabGraphics.UseVisualStyleBackColor = true;
            // 
            // ctrlGraphics
            // 
            this.ctrlGraphics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlGraphics.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlGraphics.Location = new System.Drawing.Point(14, 14);
            this.ctrlGraphics.MainForm = null;
            this.ctrlGraphics.Name = "ctrlGraphics";
            this.ctrlGraphics.Size = new System.Drawing.Size(1032, 542);
            this.ctrlGraphics.TabIndex = 0;
            // 
            // tabItems
            // 
            this.tabItems.Controls.Add(this.ctrlItems);
            this.tabItems.Location = new System.Drawing.Point(4, 22);
            this.tabItems.Name = "tabItems";
            this.tabItems.Padding = new System.Windows.Forms.Padding(14);
            this.tabItems.Size = new System.Drawing.Size(1060, 570);
            this.tabItems.TabIndex = 3;
            this.tabItems.Text = "Items";
            this.tabItems.UseVisualStyleBackColor = true;
            // 
            // ctrlItems
            // 
            this.ctrlItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlItems.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlItems.Location = new System.Drawing.Point(14, 14);
            this.ctrlItems.MainForm = null;
            this.ctrlItems.Name = "ctrlItems";
            this.ctrlItems.Size = new System.Drawing.Size(1032, 542);
            this.ctrlItems.TabIndex = 0;
            // 
            // tabDialogsShops
            // 
            this.tabDialogsShops.Location = new System.Drawing.Point(4, 22);
            this.tabDialogsShops.Name = "tabDialogsShops";
            this.tabDialogsShops.Padding = new System.Windows.Forms.Padding(3);
            this.tabDialogsShops.Size = new System.Drawing.Size(1060, 570);
            this.tabDialogsShops.TabIndex = 9;
            this.tabDialogsShops.Text = "Dialogs/Shops";
            this.tabDialogsShops.UseVisualStyleBackColor = true;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tabMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 24);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(8);
            this.pnlMain.Size = new System.Drawing.Size(1084, 612);
            this.pnlMain.TabIndex = 1;
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssSection,
            this.tssData,
            this.tssSelected,
            this.tssSelectedValue});
            this.ssMain.Location = new System.Drawing.Point(0, 636);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(1084, 22);
            this.ssMain.TabIndex = 2;
            this.ssMain.Text = "statusStrip1";
            // 
            // tssSection
            // 
            this.tssSection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssSection.Name = "tssSection";
            this.tssSection.Size = new System.Drawing.Size(67, 17);
            this.tssSection.Text = "Load ROM:";
            // 
            // tssData
            // 
            this.tssData.Name = "tssData";
            this.tssData.Size = new System.Drawing.Size(291, 17);
            this.tssData.Text = "Currently supports the NTSC Phantasy Star IV.bin only";
            // 
            // tssSelected
            // 
            this.tssSelected.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tssSelected.Name = "tssSelected";
            this.tssSelected.Size = new System.Drawing.Size(59, 17);
            this.tssSelected.Text = "Selected:";
            // 
            // tssSelectedValue
            // 
            this.tssSelectedValue.Name = "tssSelectedValue";
            this.tssSelectedValue.Size = new System.Drawing.Size(51, 17);
            this.tssSelectedValue.Text = "Nothing";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 658);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.ssMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mnuMain;
            this.MinimumSize = new System.Drawing.Size(1100, 696);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rika";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tabMaps.ResumeLayout(false);
            this.tabCharacters.ResumeLayout(false);
            this.tabEnemies.ResumeLayout(false);
            this.tabTechniquesSkills.ResumeLayout(false);
            this.tabCombinationsFormations.ResumeLayout(false);
            this.tabGraphics.ResumeLayout(false);
            this.tabItems.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabEnemies;
        private System.Windows.Forms.TabPage tabTechniquesSkills;

        #endregion
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TabPage tabCharacters;
        private System.Windows.Forms.TabPage tabItems;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel tssSection;
        private System.Windows.Forms.ToolStripStatusLabel tssData;
        private System.Windows.Forms.TabPage tabMaps;
        private System.Windows.Forms.TabPage tabGraphics;
        private System.Windows.Forms.TabPage tabCombinationsFormations;
        private System.Windows.Forms.ToolStripMenuItem mnuTools;
        private System.Windows.Forms.ToolStripMenuItem mnuDataVerify;
        private Controls.EnemiesControl ctrlEnemies;
        private Controls.ItemsControl ctrlItems;
        private Controls.CharactersControl ctrlCharacters;
        private Controls.MapsControl ctrlMaps;
        private Controls.TechniquesSkillsControl ctrlTechniquesSkills;
        private Controls.CombinationsFormationsControl ctrlCombinationsFormations;
        private Controls.GraphicsControl ctrlGraphics;
        private System.Windows.Forms.TabPage tabDialogsShops;
        private System.Windows.Forms.ToolStripStatusLabel tssSelected;
        private System.Windows.Forms.ToolStripStatusLabel tssSelectedValue;
        private System.Windows.Forms.ToolStripMenuItem mnuRefactorGraphics;
    }
}