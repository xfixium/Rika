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
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Rika.Data;
using Rika.Forms;

namespace Rika.Controls
{
    public partial class CharactersControl : UserControl
    {
        /// <summary>
        /// Fields
        /// </summary>
        private MainForm _mainForm = null;

        /// <summary>
        /// Properties
        /// </summary>
        public MainForm MainForm { get { return _mainForm; } set { _mainForm = value; LoadData(); } }
        public string SelectedInformation { get { return GetSelectedInfo(); } }
        private bool HasData { get { return _mainForm != null && _mainForm.RomData != null; } }

        /// <summary>
        /// Constructors
        /// </summary>
        public CharactersControl()
        {
            InitializeComponent();
            lstEquipment.DrawItem += MainForm.ListBoxDrawItem;
            lstTechniques.DrawItem += MainForm.ListBoxDrawItem;
            lstSkills.DrawItem += MainForm.ListBoxDrawItem;
        }

        /// <summary>
        /// Selected character changed
        /// </summary>
        private void cbCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCharacters.SelectedItem == null)
                return;

            SetCharacterFields();
            cbEquipmentType.SelectedIndex = 0;
            SetEquipment();
        }

        /// <summary>
        /// Sort selection changed
        /// </summary>
        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender == cbCharacterSort)
            {
                List<object> items = new List<object>();
                object[] array = new object[cbCharacters.Items.Count];
                cbCharacters.Items.CopyTo(array, 0);
                items.AddRange(array);
                switch ((SortType)(cbCharacterSort.SelectedItem as ObjectID).ID)
                {
                    case SortType.Asc: items.Sort((x, y) => string.Compare((x as ObjectID).CustomName, (y as ObjectID).CustomName)); break;
                    case SortType.Desc: items.Sort((x, y) => string.Compare((y as ObjectID).CustomName, (x as ObjectID).CustomName)); break;
                    default: items.Sort((x, y) => (x as ObjectID).ID.CompareTo((y as ObjectID).ID)); break;
                }
                cbCharacters.Items.Clear();
                cbCharacters.Items.AddRange(items.ToArray());
                cbCharacters.SelectedIndex = cbCharacters.Items.Count > 0 ? 0 : -1;
            }
            else if (sender == cbEquipmentSort)
            {
                SetEquipment();
            }
        }

        /// <summary>
        /// Selected equipment type changed
        /// </summary>
        private void cbEquipmentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEquipment();
        }

        /// <summary>
        /// Compare enemy stat button click
        /// </summary>
        private void btnData_Click(object sender, EventArgs e)
        {
            if (!HasData)
                return;

            // Get the stat to compare
            StatType stat = StatType.None;
            string title = (sender as Button).Tag.ToString();
            if (sender == btnPhysicalResistance)
                stat = StatType.PhysicalResistance;
            else if (sender == btnRadiationResistance)
                stat = StatType.RadiationResistance;
            else if (sender == btnFireResistance)
                stat = StatType.FireResistance;
            else if (sender == btnGravityResistance)
                stat = StatType.GravityResistance;
            else if (sender == btnWaterResistance)
                stat = StatType.WaterResistance;
            else if (sender == btnEnergyResistance)
                stat = StatType.EnergyResistance;
            else if (sender == btnElectricResistance)
                stat = StatType.ElectricResistance;
            else if (sender == btnHolyResistance)
                stat = StatType.HolyResistance;
            else if (sender == btnDeathResistance)
                stat = StatType.DeathResistance;
            else if (sender == btnBiologicalResistance)
                stat = StatType.BiologicalResistance;
            else if (sender == btnPsychicResistance)
                stat = StatType.PsychicResistance;
            else if (sender == btnMechanicalResistance)
                stat = StatType.MechanicalResistance;
            else if (sender == btnLightResistance)
                stat = StatType.LightResistance;
            else if (sender == btnDestroyResistance)
                stat = StatType.DestroyResistance;

            if (stat == StatType.None)
                return;

            // Display data comparison form
            using (DataForm form = new DataForm(title, MainForm.RomData.Characters, cbCharacters.SelectedItem.ToString(), stat))
            {
                form.ShowDialog();
            }
        }

        /// <summary>
        /// Loads character data
        /// </summary>
        private void LoadData()
        {
            // Load character types to UI
            foreach (ComboBox cb in new List<ComboBox>() { cbCharacters })
            {
                cb.Items.Clear();
                foreach (int value in Enum.GetValues(typeof(CharacterType)))
                    cb.Items.Add(new ObjectID(value, EnumMethods.GetDescription(typeof(CharacterType), (CharacterType)value)));
            }

            // Load character graphics types to UI
            foreach (ComboBox cb in new List<ComboBox>() { cbGraphics })
            {
                cb.Items.Clear();
                foreach (int value in Enum.GetValues(typeof(CharacterGraphicsType)))
                    cb.Items.Add(new ObjectID(value, EnumMethods.GetDescription(typeof(CharacterGraphicsType), (CharacterGraphicsType)value)));
            }

            // Load sort types to UI
            foreach (ComboBox cb in new List<ComboBox>() { cbCharacterSort, cbEquipmentSort })
            {
                cb.Items.Clear();
                foreach (int value in Enum.GetValues(typeof(SortType)))
                    cb.Items.Add(new ObjectID(value, EnumMethods.GetDescription(typeof(SortType), (SortType)value)));
            }

            // Load resistance types to UI
            foreach (ComboBox cb in new List<ComboBox>() { cbPhysicalResistance, cbRadiationResistance, cbFireResistance, cbGravityResistance, cbWaterResistance,
                cbEnergyResistance, cbElectricResistance, cbHolyResistance, cbDeathResistance, cbBiologicalResistance, cbPsychicResistance, cbMechanicalResistance,
                cbLightResistance, cbDestroyResistance})
            {
                cb.Items.Clear();
                foreach (int value in Enum.GetValues(typeof(ResistanceType)))
                    cb.Items.Add(new ObjectID(value, EnumMethods.GetDescription(typeof(ResistanceType), (ResistanceType)value)));
            }

            // Load equipment types to UI
            foreach (ComboBox cb in new List<ComboBox>() { cbEquipmentType })
            {
                cb.Items.Clear();
                foreach (int value in Enum.GetValues(typeof(CharacterEquipmentType)))
                    cb.Items.Add(new ObjectID(value, EnumMethods.GetDescription(typeof(CharacterEquipmentType), (CharacterEquipmentType)value)));
            }

            // Select second item
            foreach (ComboBox cb in new List<ComboBox>() { cbCharacterSort, cbEquipmentSort })
                if (cb.Items.Count > 1)
                    cb.SelectedIndex = 1;

            // Select first item
            foreach (ComboBox cb in new List<ComboBox>() { cbCharacters, cbGraphics })
                if (cb.Items.Count > 0)
                    cb.SelectedIndex = 0;
        }

        /// <summary>
        /// Sets character fields for selected character
        /// </summary>
        private void SetCharacterFields()
        {
            if (!HasData)
                return;

            // Set UI with selected character values
            Character character = MainForm.RomData.Characters.Find(x => x.ID == (cbCharacters.SelectedItem as ObjectID).ID);
            MainForm.SetSelectedInformation(this, SelectedInformation);
            numCharacterID.Text = character.ID.ToString();
            txtName.Text = character.Name;
            txtProfession.Text = character.Profession.ToString();
            lstTechniques.Items.Clear();
            lstSkills.Items.Clear();
            cbPhysicalResistance.SelectedIndex = MainForm.GetIndexByValue(cbPhysicalResistance, (int)character.Resistances[0]);
            cbRadiationResistance.SelectedIndex = MainForm.GetIndexByValue(cbRadiationResistance, (int)character.Resistances[1]);
            cbFireResistance.SelectedIndex = MainForm.GetIndexByValue(cbGravityResistance, (int)character.Resistances[2]);
            cbGravityResistance.SelectedIndex = MainForm.GetIndexByValue(cbGravityResistance, (int)character.Resistances[3]);
            cbWaterResistance.SelectedIndex = MainForm.GetIndexByValue(cbWaterResistance, (int)character.Resistances[4]);
            cbEnergyResistance.SelectedIndex = MainForm.GetIndexByValue(cbEnergyResistance, (int)character.Resistances[5]);
            cbElectricResistance.SelectedIndex = MainForm.GetIndexByValue(cbElectricResistance, (int)character.Resistances[6]);
            cbHolyResistance.SelectedIndex = MainForm.GetIndexByValue(cbHolyResistance, (int)character.Resistances[7]);
            cbDeathResistance.SelectedIndex = MainForm.GetIndexByValue(cbDeathResistance, (int)character.Resistances[8]);
            cbBiologicalResistance.SelectedIndex = MainForm.GetIndexByValue(cbBiologicalResistance, (int)character.Resistances[9]);
            cbPsychicResistance.SelectedIndex = MainForm.GetIndexByValue(cbPsychicResistance, (int)character.Resistances[10]);
            cbMechanicalResistance.SelectedIndex = MainForm.GetIndexByValue(cbMechanicalResistance, (int)character.Resistances[11]);
            cbLightResistance.SelectedIndex = MainForm.GetIndexByValue(cbLightResistance, (int)character.Resistances[12]);
            cbDestroyResistance.SelectedIndex = MainForm.GetIndexByValue(cbDestroyResistance, (int)character.Resistances[13]);
            foreach (int technique in character.TechniqueIDs)
                if (technique > 0)
                    lstTechniques.Items.Add(MainForm.RomData.Techniques.Find(x => x.ID == technique).CustomName);
            foreach (int skill in character.SkillIDs)
                if (skill > 0)
                    lstSkills.Items.Add(MainForm.RomData.CharacterSkills.Find(x => x.ID == skill).CustomName);
            grdLevels.RowsDefaultCellStyle.BackColor = SystemColors.Control;
            grdLevels.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.Window;
            grdLevels.AutoGenerateColumns = false;
            BindingSource source = new BindingSource { DataSource = character.Levels };
            grdLevels.DataSource = source;
            if (character.ID != (int)CharacterType.Chaz && character.ID != (int)CharacterType.Gryz && character.ID != (int)CharacterType.Rika)
                grdLevels.AutoResizeRow(0);
            pnlGraphics.Image = MainForm.RomData.GetSpriteImageByID(character.SpriteID, 0);
        }

        /// <summary>
        /// Sets the selected equipment UI
        /// </summary>
        private void SetEquipment()
        {
            if (!HasData || cbCharacters.SelectedItem == null || cbEquipmentType.SelectedItem == null || cbEquipmentSort.SelectedItem == null)
                return;

            // Filter item list based on character and equipment type selections
            List<Item> equipment = new List<Item>();
            CharacterType character = (CharacterType)(cbCharacters.SelectedItem as ObjectID).ID;
            CharacterEquipmentType type = (CharacterEquipmentType)(cbEquipmentType.SelectedItem as ObjectID).ID;
            switch (type)
            {
                case CharacterEquipmentType.All:
                    equipment = MainForm.RomData.Items.FindAll(x => x.EligibleCharactersByID.Contains(character) && x.Type != ItemAreaType.NonBattle && x.Type != ItemAreaType.None &&
                        x.Type != ItemAreaType.Story && x.Type != ItemAreaType.Useable);
                    break;
                case CharacterEquipmentType.Weapons:
                    equipment = MainForm.RomData.Items.FindAll(x => x.EligibleCharactersByID.Contains(character) && (x.Type == ItemAreaType.OneHandedMultiTarget || x.Type == ItemAreaType.OneHandedOneTarget ||
                        x.Type == ItemAreaType.TwoHandedMultiTarget || x.Type == ItemAreaType.TwoHandedOneTarget));
                    break;
                case CharacterEquipmentType.Shields: equipment = MainForm.RomData.Items.FindAll(x => x.EligibleCharactersByID.Contains(character) && x.Type == ItemAreaType.Shield); break;
                case CharacterEquipmentType.Head: equipment = MainForm.RomData.Items.FindAll(x => x.EligibleCharactersByID.Contains(character) && x.Type == ItemAreaType.Head); break;
                case CharacterEquipmentType.Body: equipment = MainForm.RomData.Items.FindAll(x => x.EligibleCharactersByID.Contains(character) && x.Type == ItemAreaType.Body); break;
            }
            switch ((SortType)(cbEquipmentSort.SelectedItem as ObjectID).ID)
            {
                case SortType.Asc: equipment.Sort((x, y) => string.Compare(x.CustomName, y.CustomName)); break;
                case SortType.Desc: equipment.Sort((x, y) => string.Compare(y.CustomName, x.CustomName)); break;
                default: equipment.Sort((x, y) => x.ID.CompareTo(y.ID)); break;
            }

            // Load equipment to UI
            foreach (ListBox lb in new List<ListBox>() { lstEquipment })
            {
                lb.Items.Clear();
                foreach (Item item in equipment)
                    lb.Items.Add(new ObjectID(item.ID, item.CustomName));
            }
        }

        /// <summary>
        /// Gets the selected object information
        /// </summary>
        /// <returns>Object information</returns>
        private string GetSelectedInfo()
        {
            if (!HasData || cbCharacters.SelectedItem == null)
                return "None";

            Character character = MainForm.RomData.Characters.Find(x => x.ID == (cbCharacters.SelectedItem as ObjectID).ID);
            if (character == null)
                return "None";

            return MainForm.GetSelectedInformation(character);
        }
    }
}
