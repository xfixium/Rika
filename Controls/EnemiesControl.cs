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
    public partial class EnemiesControl : UserControl
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
        public EnemiesControl()
        {
            InitializeComponent();
            lstDamageAnalyze.DrawItem += MainForm.ListBoxDrawItem;
        }

        /// <summary>
        /// Selected enemy changed
        /// </summary>
        private void cbEnemies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedItem != null)
                SetEnemyFields();
        }

        /// <summary>
        /// Enemy sort selection changed
        /// </summary>
        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            object[] array = null;
            List<object> items = new List<object>();
            array = new object[cbEnemies.Items.Count];
            cbEnemies.Items.CopyTo(array, 0);
            items.AddRange(array);
            switch ((SortType)(cbEnemiesSort.SelectedItem as ObjectID).ID)
            {
                case SortType.Asc: items.Sort((x, y) => string.Compare((x as ObjectID).CustomName, (y as ObjectID).CustomName)); break;
                case SortType.Desc: items.Sort((x, y) => string.Compare((y as ObjectID).CustomName, (x as ObjectID).CustomName)); break;
                default: items.Sort((x, y) => (x as ObjectID).ID.CompareTo((y as ObjectID).ID)); break;
            }
            cbEnemies.Items.Clear();
            cbEnemies.Items.AddRange(items.ToArray());
            cbEnemies.SelectedIndex = cbEnemies.Items.Count > 0 ? 0 : -1;
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
            if (sender == btnHP)
                stat = StatType.HP;
            else if (sender == btnEXP)
                stat = StatType.Exp;
            else if (sender == btnMeseta)
                stat = StatType.Meseta;
            else if (sender == btnAttack)
                stat = StatType.Attack;
            else if (sender == btnDefense)
                stat = StatType.Defense;
            else if (sender == btnStrength)
                stat = StatType.Strength;
            else if (sender == btnMental)
                stat = StatType.Mental;
            else if (sender == btnAgility)
                stat = StatType.Agility;
            else if (sender == btnDexterity)
                stat = StatType.Dexterity;
            else if (sender == btnMagicDefense)
                stat = StatType.MagicDefense;
            else if (sender == btnPhysicalResistance)
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
            else if (sender == btnResistanceScore)
                stat = StatType.ResistanceGrade;

            if (stat == StatType.None)
                return;

            using (DataForm form = new DataForm(title, MainForm.RomData.Enemies, cbEnemies.SelectedItem.ToString(), stat))
            {
                form.ShowDialog();
            }
        }

        /// <summary>
        /// Analyze button click
        /// </summary>
        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            if (sender == btnElementAnalyze)
            {
                if (cbElement.SelectedItem == null)
                    return;
                lstDamageAnalyze.Items.Clear();
                ObjectID item = cbElement.SelectedItem as ObjectID;
                foreach (Enemy enemy in MainForm.RomData.Enemies)
                    if (enemy.AttackElement == (ElementType)item.ID && !lstDamageAnalyze.Items.Contains(enemy.CustomName))
                        lstDamageAnalyze.Items.Add(enemy.CustomName);
                string elementName = EnumMethods.GetDescription(typeof(ElementType), item);
                int count = lstDamageAnalyze.Items.Count;
                lblDamageAnalyze.Text = (count < 1 ? "No" : count.ToString()) + (count == 1 ? " enemy" : " enemies") + " use" + (count == 1 ? "s" : "") + " the " + elementName + " damage element:";
            }
            else if (sender == btnStatusAnalyze)
            {
                lstDamageAnalyze.Items.Clear();
                ObjectID item = cbStatus.SelectedItem as ObjectID;
                foreach (Enemy enemy in MainForm.RomData.Enemies)
                    if (enemy.StatusEffect == (StatusEffectType)item.ID && !lstDamageAnalyze.Items.Contains(enemy.CustomName))
                        lstDamageAnalyze.Items.Add(enemy.CustomName);
                string elementName = EnumMethods.GetDescription(typeof(StatusEffectType), item);
                int count = lstDamageAnalyze.Items.Count;
                lblDamageAnalyze.Text = (count < 1 ? "No" : count.ToString()) + (count == 1 ? " enemy" : " enemies") + " use" + (count == 1 ? "s" : "") + " the " + elementName + " status effect:";
            }
        }

        /// <summary>
        /// Selected graphics scale changed
        /// </summary>
        private void cbScale_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlGraphics.ImageScale = cbScale.SelectedItem == null ? 1 : (cbScale.SelectedItem as ObjectID).ID;
        }

        /// <summary>
        /// Loads enemy data
        /// </summary>
        private void LoadData()
        {
            // Load sort types to UI
            foreach (ComboBox cb in new List<ComboBox>() { cbEnemiesSort })
            {
                cb.Items.Clear();
                foreach (int value in Enum.GetValues(typeof(SortType)))
                    cb.Items.Add(new ObjectID(value, EnumMethods.GetDescription(typeof(SortType), (SortType)value)));
            }

            // Load enemy graphic types to UI
            foreach (ComboBox cb in new List<ComboBox>() { cbGraphics })
            {
                cb.Items.Clear();
                foreach (int value in Enum.GetValues(typeof(EnemyGraphicsType)))
                    cb.Items.Add(new ObjectID(value, EnumMethods.GetDescription(typeof(EnemyGraphicsType), (EnemyGraphicsType)value)));
            }
            
            // Load scale types to UI
            foreach (ComboBox cb in new List<ComboBox>() { cbScale })
            {
                cb.Items.Clear();
                foreach (int value in Enum.GetValues(typeof(ScaleType)))
                    cb.Items.Add(new ObjectID(value, EnumMethods.GetDescription(typeof(ScaleType), (ScaleType)value)));
            }

            // Load damage element types to UI
            foreach (ComboBox cb in new List<ComboBox>() { cbElement })
            {
                cb.Items.Clear();
                foreach (int value in Enum.GetValues(typeof(ElementType)))
                    cb.Items.Add(new ObjectID(value, EnumMethods.GetDescription(typeof(ElementType), (ElementType)value)));
            }

            // Load status effect types to UI
            foreach (ComboBox cb in new List<ComboBox>() { cbStatus })
            {
                cb.Items.Clear();
                foreach (int value in Enum.GetValues(typeof(StatusEffectType)))
                    cb.Items.Add(new ObjectID(value, EnumMethods.GetDescription(typeof(StatusEffectType), (StatusEffectType)value)));
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

            // Load condition types to UI
            foreach (ComboBox cb in new List<ComboBox>() { cbTrigger1, cbTrigger2, cbTrigger3, cbTrigger4 })
            {
                cb.Items.Clear();
                foreach (int value in Enum.GetValues(typeof(TriggerType)))
                    cb.Items.Add(new ObjectID(value, EnumMethods.GetDescription(typeof(TriggerType), (TriggerType)value)));
            }

            // Load enemy data
            if (HasData)
            {
                foreach (ComboBox cb in new List<ComboBox>() { cbAction1, cbAction2, cbAction3, cbAction4, cbAction5, cbAction6, cbAction7,
                    cbAction8, cbTriggerAction1, cbTriggerAction2, cbTriggerAction3, cbTriggerAction4 })
                {
                    cb.Items.Clear();
                    foreach (Skill skill in MainForm.RomData.EnemySkills)
                        cb.Items.Add(new ObjectID(skill.ID, skill.CustomName));
                }

                cbEnemies.Items.Clear();
                foreach (Enemy enemy in MainForm.RomData.Enemies)
                    cbEnemies.Items.Add(new ObjectID(enemy.ID, enemy.CustomName));

                foreach (ComboBox cb in new List<ComboBox>() { cbEnemies })
                    if (cb.Items.Count > 0)
                        cb.SelectedIndex = 0;
            }

            // Select first item
            foreach (ComboBox cb in new List<ComboBox>() { cbGraphics, cbScale })
                if (cb.Items.Count > 0)
                    cb.SelectedIndex = 0;

            // Select second item
            foreach (ComboBox cb in new List<ComboBox>() { cbEnemiesSort })
                if (cb.Items.Count > 1)
                    cb.SelectedIndex = 1;
        }

        /// <summary>
        /// Sets enemy fields for selected enemy
        /// </summary>
        private void SetEnemyFields()
        {
            if (!HasData)
                return;

            Enemy enemy = MainForm.RomData.Enemies.Find(x => x.ID == (cbEnemies.SelectedItem as ObjectID).ID);
            MainForm.SetSelectedInformation(this, SelectedInformation);
            txtName.Text = enemy.Name;
            numEnemyID.Text = enemy.ID.ToString();
            txtResistanceScore.Text = enemy.ResistanceGrade;
            numHP.Value = enemy.HP;
            numEXP.Value = enemy.Exp;
            numMeseta.Value = enemy.Meseta;
            numAttack.Value = enemy.Attack;
            numDefense.Value = enemy.Defense;
            numAgility.Value = enemy.Agility;
            numStrength.Value = enemy.Strength;
            numMental.Value = enemy.Mental;
            numDexterity.Value = enemy.Dexterity;
            numMagicDefense.Value = enemy.MagicDefense;
            cbElement.SelectedIndex = MainForm.GetIndexByValue(cbElement, (int)enemy.AttackElement);
            cbStatus.SelectedIndex = MainForm.GetIndexByValue(cbStatus, (int)enemy.StatusEffect);
            cbPhysicalResistance.SelectedIndex = MainForm.GetIndexByValue(cbPhysicalResistance, (int)enemy.Resistances[0]);
            cbRadiationResistance.SelectedIndex = MainForm.GetIndexByValue(cbRadiationResistance, (int)enemy.Resistances[1]);
            cbFireResistance.SelectedIndex = MainForm.GetIndexByValue(cbGravityResistance, (int)enemy.Resistances[2]);
            cbGravityResistance.SelectedIndex = MainForm.GetIndexByValue(cbGravityResistance, (int)enemy.Resistances[3]);
            cbWaterResistance.SelectedIndex = MainForm.GetIndexByValue(cbWaterResistance, (int)enemy.Resistances[4]);
            cbEnergyResistance.SelectedIndex = MainForm.GetIndexByValue(cbEnergyResistance, (int)enemy.Resistances[5]);
            cbElectricResistance.SelectedIndex = MainForm.GetIndexByValue(cbElectricResistance, (int)enemy.Resistances[6]);
            cbHolyResistance.SelectedIndex = MainForm.GetIndexByValue(cbHolyResistance, (int)enemy.Resistances[7]);
            cbDeathResistance.SelectedIndex = MainForm.GetIndexByValue(cbDeathResistance, (int)enemy.Resistances[8]);
            cbBiologicalResistance.SelectedIndex = MainForm.GetIndexByValue(cbBiologicalResistance, (int)enemy.Resistances[9]);
            cbPsychicResistance.SelectedIndex = MainForm.GetIndexByValue(cbPsychicResistance, (int)enemy.Resistances[10]);
            cbMechanicalResistance.SelectedIndex = MainForm.GetIndexByValue(cbMechanicalResistance, (int)enemy.Resistances[11]);
            cbLightResistance.SelectedIndex = MainForm.GetIndexByValue(cbLightResistance, (int)enemy.Resistances[12]);
            cbDestroyResistance.SelectedIndex = MainForm.GetIndexByValue(cbDestroyResistance, (int)enemy.Resistances[13]);
            cbAction1.SelectedIndex = MainForm.GetIndexByValue(cbAction1, enemy.ActionIDs[0]);
            cbAction2.SelectedIndex = MainForm.GetIndexByValue(cbAction2, enemy.ActionIDs[1]);
            cbAction3.SelectedIndex = MainForm.GetIndexByValue(cbAction3, enemy.ActionIDs[2]);
            cbAction4.SelectedIndex = MainForm.GetIndexByValue(cbAction4, enemy.ActionIDs[3]);
            cbAction5.SelectedIndex = MainForm.GetIndexByValue(cbAction5, enemy.ActionIDs[4]);
            cbAction6.SelectedIndex = MainForm.GetIndexByValue(cbAction6, enemy.ActionIDs[5]);
            cbAction7.SelectedIndex = MainForm.GetIndexByValue(cbAction7, enemy.ActionIDs[6]);
            cbAction8.SelectedIndex = MainForm.GetIndexByValue(cbAction8, enemy.ActionIDs[7]);
            cbTrigger1.SelectedIndex = MainForm.GetIndexByValue(cbTrigger1, (int)enemy.Conditions[0].Trigger);
            cbTrigger2.SelectedIndex = MainForm.GetIndexByValue(cbTrigger2, (int)enemy.Conditions[1].Trigger);
            cbTrigger3.SelectedIndex = MainForm.GetIndexByValue(cbTrigger3, (int)enemy.Conditions[2].Trigger);
            cbTrigger4.SelectedIndex = MainForm.GetIndexByValue(cbTrigger4, (int)enemy.Conditions[3].Trigger);
            cbTriggerAction1.SelectedIndex = MainForm.GetIndexByValue(cbTriggerAction1, enemy.Conditions[0].ActionID);
            cbTriggerAction2.SelectedIndex = MainForm.GetIndexByValue(cbTriggerAction2, enemy.Conditions[1].ActionID);
            cbTriggerAction3.SelectedIndex = MainForm.GetIndexByValue(cbTriggerAction3, enemy.Conditions[2].ActionID);
            cbTriggerAction4.SelectedIndex = MainForm.GetIndexByValue(cbTriggerAction4, enemy.Conditions[3].ActionID);
            pnlGraphics.Image = MainForm.RomData.GetSpriteImageByID(enemy.SpriteID, 0);
            btnAnalyze_Click(btnElementAnalyze, EventArgs.Empty);
        }

        /// <summary>
        /// Gets the selected object information
        /// </summary>
        /// <returns>Object information</returns>
        private string GetSelectedInfo()
        {
            if (!HasData || cbEnemies.SelectedItem == null)
                return "None";

            Enemy enemy = MainForm.RomData.Enemies.Find(x => x.ID == (cbEnemies.SelectedItem as ObjectID).ID);
            if (enemy == null)
                return "None";

            return MainForm.GetSelectedInformation(enemy);
        }
    }
}
