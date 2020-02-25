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

namespace Rika.Forms
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Properties
        /// </summary>
        public RomData RomData = null;

        /// <summary>
        /// Main UI constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            tssSelected.Visible = false;
            tssSelectedValue.Visible = false;
        }

        /// <summary>
        /// Open menu item click
        /// </summary>
        private void mnuOpen_Click(object sender, EventArgs e)
        {
            if (ofdOpenFile.ShowDialog() != DialogResult.OK)
                return;

            // Load rom data
            RomData = new RomData(ofdOpenFile.FileName);
            ctrlMaps.MainForm = this;
            ctrlCharacters.MainForm = this;
            ctrlEnemies.MainForm = this;
            ctrlTechniquesSkills.MainForm = this;
            ctrlCombinationsFormations.MainForm = this;
            ctrlItems.MainForm = this;
            ctrlGraphics.MainForm = this;
            tabMain.Visible = true;
            tssSelected.Visible = true;
            tssSelectedValue.Visible = true;
            tabMain_SelectedIndexChanged(this, EventArgs.Empty);
        }

        /// <summary>
        /// Exit menu item click
        /// </summary>
        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Data verify menu item click
        /// </summary>
        private void mnuDataVerify_Click(object sender, EventArgs e)
        {
            // This tool is a convenience tool to verify what type of compression a range of ROM bytes might be
            if (RomData == null)
            {
                MessageBox.Show("Open up the ROM file first num nuts.", Application.ProductName, MessageBoxButtons.OK);
                return;
            }

            using (DataVerifyForm form = new DataVerifyForm(RomData.Data))
            {
                form.ShowDialog();
            }
        }

        /// <summary>
        /// Refactor graphics menu item click
        /// </summary>
        private void mnuRefactorGraphics_Click(object sender, EventArgs e)
        {
            // Another convenience tool, which refactors the sprite enumeration values, by reincrementing them from zero.
            // Spits it out as code, and then I use that output to replace the SpriteType enum, instead of doing it by hand.
            // Mainly because I'm lazy, and renumbering stuff is a real drag.
            using (SpriteRefactorForm form = new SpriteRefactorForm())
            {
                form.ShowDialog();
            }
        }

        /// <summary>
        /// About menu item click
        /// </summary>
        private void mnuAbout_Click(object sender, EventArgs e)
        {
            using (AboutForm dialog = new AboutForm())
            {
                dialog.ShowDialog();
            }
        }

        /// <summary>
        /// Tab selected index changed
        /// </summary>
        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            tssSection.Text = "";
            tssData.Text = "";
            tssSelectedValue.Text = "Nothing";
            if (tabMain.SelectedTab == tabMaps)
            {
                tssSection.Text = "Map Count:";
                tssData.Text = RomData.Maps.Count.ToString();
                tssSelectedValue.Text = "Nothing";
            }
            else if (tabMain.SelectedTab == tabCharacters)
            {
                tssSection.Text = "Character Count:";
                tssData.Text = RomData.Characters.Count.ToString();
                tssSelectedValue.Text = ctrlCharacters.SelectedInformation;
            }
            else if (tabMain.SelectedTab == tabEnemies)
            {
                tssSection.Text = "Enemy Count:";
                tssData.Text = RomData.Enemies.Count.ToString();
                tssSelectedValue.Text = ctrlEnemies.SelectedInformation;
            }
            else if (tabMain.SelectedTab == tabTechniquesSkills)
            {
                tssSection.Text = "Technique | Character Skill | Enemy Skill Count:";
                tssData.Text = RomData.Techniques.Count + " | " + RomData.CharacterSkills.Count + " | " + RomData.EnemySkills.Count;
                tssSelectedValue.Text = ctrlTechniquesSkills.SelectedInformation;
            }
            else if (tabMain.SelectedTab == tabCombinationsFormations)
            {
                tssSection.Text = "Combination | Formation Count:";
                tssData.Text = RomData.Combinations.Count + " | " + RomData.Formations.Count;
                tssSelectedValue.Text = "Nothing";
            }
            else if (tabMain.SelectedTab == tabGraphics)
            {
                tssSection.Text = "Graphics Count:";
                tssData.Text = RomData.Sprites.Count.ToString();
                tssSelectedValue.Text = ctrlGraphics.SelectedInformation;
            }
            else if (tabMain.SelectedTab == tabItems)
            {
                tssSection.Text = "Item Count:";
                tssData.Text = ctrlItems.ItemCount.ToString();
                tssSelectedValue.Text = ctrlItems.SelectedInformation;
            }
        }

        /// <summary>
        /// Listbox draw item method for owner drawn listboxes
        /// </summary>
        public static void ListBoxDrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;
            e.DrawBackground();
            TextRenderer.DrawText(e.Graphics, (sender as ListBox).Items[e.Index].ToString(), e.Font, e.Bounds, e.ForeColor, TextFormatFlags.VerticalCenter);
            e.DrawFocusRectangle();
        }

        /// <summary>
        /// Gets the item index for the selected item, using its identifier
        /// </summary>
        /// <param name="comboBox">The combobox to search the identifier for</param>
        /// <param name="value">The identifier to get the index of</param>
        /// <returns>The index of the given identifier</returns>
        public int GetIndexByValue(ComboBox comboBox, int value)
        {
            for (int i = 0; i < comboBox.Items.Count; i++)
                if ((comboBox.Items[i] as ObjectID).ID == value)
                    return i;
            return 0;
        }

        /// <summary>
        /// Sets the status strip text from outside thise form
        /// </summary>
        /// <param name="category">The text for the category</param>
        /// <param name="text">The value text</param>
        public void SetStatusText(object sender, string category, string text)
        {
            bool valid = sender == tabMain.SelectedTab.Controls[0];
            tssSection.Text = valid ? category : tssSection.Text;
            tssData.Text = valid ? text : tssData.Text;
        }

        /// <summary>
        /// Sets the selected information status strip label based on the calling control
        /// </summary>
        /// <param name="sender">The control sending the information</param>
        /// <param name="information">The information to display</param>
        public void SetSelectedInformation(object sender, string information)
        {
            tssSelectedValue.Text = sender != tabMain.SelectedTab.Controls[0] ? tssSelectedValue.Text : tssSelectedValue.Text = information;
        }

        /// <summary>
        /// Gets formatted selected information
        /// </summary>
        /// <param name="objectID">The object selected</param>
        public string GetSelectedInformation(ObjectID objectID)
        {
            return GetSelectedInformation(new List<ObjectID> { objectID });
        }

        /// <summary>
        /// Gets formatted selected information string
        /// </summary>
        /// <param name="objectIDs">The objects selected</param>
        /// <returns>A string formated for the selections</returns>
        public string GetSelectedInformation(List<ObjectID> objectIDs)
        {
            string information = string.Empty;
            foreach (ObjectID objectID in objectIDs)
            {
                string name = string.IsNullOrEmpty(objectID.CustomName) ? objectID.Name : objectID.CustomName;
                int start = objectID.DataStart;
                int end = objectID.DataEnd;
                int length = objectID.Length;
                information += name + ": Data Start: " + start.ToString("X") + " (" + start + ") Data End: " + end.ToString("X") + " (" + end + 
                    ") Bytes: " + length + " Compression: " + objectID.Compression + " | ";
            }
            return information.TrimEnd(new char[] { '|', ' ' });
        }
    }
}