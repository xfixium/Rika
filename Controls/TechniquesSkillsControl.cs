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
    public partial class TechniquesSkillsControl : UserControl
    {
        /// <summary>
        /// Fields
        /// </summary>
        private MainForm _mainForm = null;
        private ObjectID _selectedObject = null;

        /// <summary>
        /// Properties
        /// </summary>
        public MainForm MainForm { get { return _mainForm; } set { _mainForm = value; LoadData(); } }
        public string SelectedInformation { get { return GetSelectedInfo(); } }
        private bool HasData { get { return _mainForm != null && _mainForm.RomData != null; } }

        /// <summary>
        /// Constructors
        /// </summary>
        public TechniquesSkillsControl()
        {
            InitializeComponent();
            lstCharacterTechniqueAnalyze.DrawItem += MainForm.ListBoxDrawItem;
            lstCharacterSkillAnalyze.DrawItem += MainForm.ListBoxDrawItem;
            lstEnemySkillAnalyze.DrawItem += MainForm.ListBoxDrawItem;
        }

        /// <summary>
        /// Selected haracter Techique changed
        /// </summary>
        private void cbCharacterTechniques_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedItem != null)
                SetTechniqueFields();
        }

        /// <summary>
        /// Selected character Skill changed
        /// </summary>
        private void cbCharacterSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedItem != null)
                SetCharacterSkillFields();
        }

        /// <summary>
        /// Selected enemy techique changed
        /// </summary>
        private void cbEnemySkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedItem != null)
                SetEnemySkillFields();
        }

        /// <summary>
        /// Sort selection changed
        /// </summary>
        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortType sortType = SortType.None;
            object[] array = null;
            List<object> items = new List<object>();
            ComboBox comboBox = null;
            if (sender == cbTechniquesSort)
            {
                array = new object[cbCharacterTechniques.Items.Count];
                comboBox = cbCharacterTechniques;
                sortType = (SortType)(cbTechniquesSort.SelectedItem as ObjectID).ID;
            }
            else if (sender == cbCharacterSkillsSort)
            {
                array = new object[cbCharacterSkills.Items.Count];
                comboBox = cbCharacterSkills;
                sortType = (SortType)(cbCharacterSkillsSort.SelectedItem as ObjectID).ID;
            }
            else if (sender == cbEnemySkillsSort)
            {
                array = new object[cbEnemySkills.Items.Count];
                comboBox = cbEnemySkills;
                sortType = (SortType)(cbEnemySkillsSort.SelectedItem as ObjectID).ID;
            }
            comboBox.Items.CopyTo(array, 0);
            items.AddRange(array);
            switch (sortType)
            {
                case SortType.Asc: items.Sort((x, y) => string.Compare((x as ObjectID).CustomName, (y as ObjectID).CustomName)); break;
                case SortType.Desc: items.Sort((x, y) => string.Compare((y as ObjectID).CustomName, (x as ObjectID).CustomName)); break;
                default: items.Sort((x, y) => (x as ObjectID).ID.CompareTo((y as ObjectID).ID)); break;
            }
            comboBox.Items.Clear();
            comboBox.Items.AddRange(items.ToArray());
            comboBox.SelectedIndex = comboBox.Items.Count > 0 ? 0 : -1;
        }

        /// <summary>
        /// Character technique analyze button click
        /// </summary>
        private void btnCharacterTechniqueAnalyze_Click(object sender, EventArgs e)
        {
            if (sender == btnCharacterTechniqueEffect)
            {
                if (cbCharacterTechniqueEffect.SelectedItem == null)
                    return;
                lstCharacterTechniqueAnalyze.Items.Clear();
                ObjectID item = cbCharacterTechniqueEffect.SelectedItem as ObjectID;
                foreach (Technique technique in MainForm.RomData.Techniques)
                    if (technique.Effect == (EffectType)item.ID && !lstCharacterTechniqueAnalyze.Items.Contains(technique.CustomName))
                        lstCharacterTechniqueAnalyze.Items.Add(technique.CustomName);
                int count = lstCharacterTechniqueAnalyze.Items.Count;
                lblCharacterTechniqueAnalyze.Text = (count < 1 ? "No" : count.ToString()) + " technique" + (count == 1 ? "" : "s") + " use" + (count == 1 ? "s" : "") + " the " + item.CustomName + " Effect:";
            }
            else if (sender == btnCharacterTechniqueEffectArea)
            {
                if (cbCharacterTechniqueEffectArea.SelectedItem == null)
                    return;
                lstCharacterTechniqueAnalyze.Items.Clear();
                ObjectID item = cbCharacterTechniqueEffectArea.SelectedItem as ObjectID;
                foreach (Technique technique in MainForm.RomData.Techniques)
                    if (technique.EffectArea == (EffectAreaType)item.ID && !lstCharacterTechniqueAnalyze.Items.Contains(technique.CustomName))
                        lstCharacterTechniqueAnalyze.Items.Add(technique.CustomName);
                int count = lstCharacterTechniqueAnalyze.Items.Count;
                lblCharacterTechniqueAnalyze.Text = (count < 1 ? "No" : count.ToString()) + " technique" + (count == 1 ? "" : "s") + " use" + (count == 1 ? "s" : "") + " the " + item.CustomName + " Effect Area:";
            }
            else if (sender == btnCharacterTechniqueTargetDefenseStat)
            {
                if (cbCharacterTechniqueTargetDefenseStat.SelectedItem == null)
                    return;
                lstCharacterTechniqueAnalyze.Items.Clear();
                ObjectID item = cbCharacterTechniqueTargetDefenseStat.SelectedItem as ObjectID;
                foreach (Technique technique in MainForm.RomData.Techniques)
                    if (technique.Defense == (EffectStatType)item.ID && !lstCharacterTechniqueAnalyze.Items.Contains(technique.CustomName))
                        lstCharacterTechniqueAnalyze.Items.Add(technique.CustomName);
                int count = lstCharacterTechniqueAnalyze.Items.Count;
                lblCharacterTechniqueAnalyze.Text = (count < 1 ? "No" : count.ToString()) + " technique" + (count == 1 ? "" : "s") + " use" + (count == 1 ? "s" : "") + " the " + item.CustomName + " Target DEF Stat:";
            }
            else if (sender == btnCharacterTechniqueTarget)
            {
                if (cbCharacterTechniqueTarget.SelectedItem == null)
                    return;
                lstCharacterTechniqueAnalyze.Items.Clear();
                ObjectID item = cbCharacterTechniqueTarget.SelectedItem as ObjectID;
                foreach (Technique technique in MainForm.RomData.Techniques)
                    if (technique.Target == (EffectTargetType)item.ID && !lstCharacterTechniqueAnalyze.Items.Contains(technique.CustomName))
                        lstCharacterTechniqueAnalyze.Items.Add(technique.CustomName);
                int count = lstCharacterTechniqueAnalyze.Items.Count;
                lblCharacterTechniqueAnalyze.Text = (count < 1 ? "No" : count.ToString()) + " technique" + (count == 1 ? "" : "s") + " use" + (count == 1 ? "s" : "") + " the " + item.CustomName + " Target:";
            }
            else if (sender == btnCharacterTechniqueElement)
            {
                if (cbCharacterTechniqueElement.SelectedItem == null)
                    return;
                lstCharacterTechniqueAnalyze.Items.Clear();
                ObjectID item = cbCharacterTechniqueElement.SelectedItem as ObjectID;
                foreach (Technique technique in MainForm.RomData.Techniques)
                    if (technique.Element == (ElementType)item.ID && !lstCharacterTechniqueAnalyze.Items.Contains(technique.CustomName))
                        lstCharacterTechniqueAnalyze.Items.Add(technique.CustomName);
                int count = lstCharacterTechniqueAnalyze.Items.Count;
                lblCharacterTechniqueAnalyze.Text = (count < 1 ? "No" : count.ToString()) + " technique" + (count == 1 ? "" : "s") + " use" + (count == 1 ? "s" : "") + " the " + item.CustomName + " Element:";
            }
        }

        /// <summary>
        /// Character skill analyze button click
        /// </summary>
        private void btnCharacterSkillAnalyze_Click(object sender, EventArgs e)
        {
            if (sender == btnCharacterSkillEffect)
            {
                if (cbCharacterSkillEffect.SelectedItem == null)
                    return;
                lstCharacterSkillAnalyze.Items.Clear();
                ObjectID item = cbCharacterSkillEffect.SelectedItem as ObjectID;
                foreach (Skill skill in MainForm.RomData.CharacterSkills)
                    if (skill.Effect == (EffectType)item.ID && !lstCharacterSkillAnalyze.Items.Contains(skill.CustomName))
                        lstCharacterSkillAnalyze.Items.Add(skill.CustomName);
                int count = lstCharacterSkillAnalyze.Items.Count;
                lblCharacterSkillAnalyze.Text = (count < 1 ? "No" : count.ToString()) + " skill" + (count == 1 ? "" : "s") + " use" + (count == 1 ? "s" : "") + " the " + item.CustomName + " Effect:";
            }
            else if (sender == btnCharacterSkillEffectArea)
            {
                if (cbCharacterSkillEffectArea.SelectedItem == null)
                    return;
                lstCharacterSkillAnalyze.Items.Clear();
                ObjectID item = cbCharacterSkillEffectArea.SelectedItem as ObjectID;
                foreach (Skill skill in MainForm.RomData.CharacterSkills)
                    if (skill.EffectArea == (EffectAreaType)item.ID && !lstCharacterSkillAnalyze.Items.Contains(skill.CustomName))
                        lstCharacterSkillAnalyze.Items.Add(skill.CustomName);
                int count = lstCharacterSkillAnalyze.Items.Count;
                lblCharacterSkillAnalyze.Text = (count < 1 ? "No" : count.ToString()) + " skill" + (count == 1 ? "" : "s") + " use" + (count == 1 ? "s" : "") + " the " + item.CustomName + " Effect Area:";
            }
            else if (sender == btnCharacterSkillAtkStat)
            {
                if (cbCharacterSkillAtkStat.SelectedItem == null)
                    return;
                lstCharacterSkillAnalyze.Items.Clear();
                ObjectID item = cbCharacterSkillAtkStat.SelectedItem as ObjectID;
                foreach (Skill skill in MainForm.RomData.CharacterSkills)
                    if (skill.Offense == (EffectStatType)item.ID && !lstCharacterSkillAnalyze.Items.Contains(skill.CustomName))
                        lstCharacterSkillAnalyze.Items.Add(skill.CustomName);
                int count = lstCharacterSkillAnalyze.Items.Count;
                lblCharacterSkillAnalyze.Text = (count < 1 ? "No" : count.ToString()) + " skill" + (count == 1 ? "" : "s") + " use" + (count == 1 ? "s" : "") + " the " + item.CustomName + " ATK Stat:";
            }
            else if (sender == btnCharacterSkillTargetDefenseStat)
            {
                if (cbCharacterSkillTargetDefenseStat.SelectedItem == null)
                    return;
                lstCharacterSkillAnalyze.Items.Clear();
                ObjectID item = cbCharacterSkillTargetDefenseStat.SelectedItem as ObjectID;
                foreach (Skill skill in MainForm.RomData.CharacterSkills)
                    if (skill.Defense == (EffectStatType)item.ID && !lstCharacterSkillAnalyze.Items.Contains(skill.CustomName))
                        lstCharacterSkillAnalyze.Items.Add(skill.CustomName);
                int count = lstCharacterSkillAnalyze.Items.Count;
                lblCharacterSkillAnalyze.Text = (count < 1 ? "No" : count.ToString()) + " skill" + (count == 1 ? "" : "s") + " use" + (count == 1 ? "s" : "") + " the " + item.CustomName + " Target DEF Stat:";
            }
            else if (sender == btnCharacterSkillTarget)
            {
                if (cbCharacterSkillTarget.SelectedItem == null)
                    return;
                lstCharacterSkillAnalyze.Items.Clear();
                ObjectID item = cbCharacterSkillTarget.SelectedItem as ObjectID;
                foreach (Skill skill in MainForm.RomData.CharacterSkills)
                    if (skill.Target == (EffectTargetType)item.ID && !lstCharacterSkillAnalyze.Items.Contains(skill.CustomName))
                        lstCharacterSkillAnalyze.Items.Add(skill.CustomName);
                int count = lstCharacterSkillAnalyze.Items.Count;
                lblCharacterSkillAnalyze.Text = (count < 1 ? "No" : count.ToString()) + " skill" + (count == 1 ? "" : "s") + " use" + (count == 1 ? "s" : "") + " the " + item.CustomName + " Target:";
            }
            else if (sender == btnCharacterSkillElement)
            {
                if (cbCharacterSkillElement.SelectedItem == null)
                    return;
                lstCharacterSkillAnalyze.Items.Clear();
                ObjectID item = cbCharacterSkillElement.SelectedItem as ObjectID;
                foreach (Skill skill in MainForm.RomData.CharacterSkills)
                    if (skill.Element == (ElementType)item.ID && !lstCharacterSkillAnalyze.Items.Contains(skill.CustomName))
                        lstCharacterSkillAnalyze.Items.Add(skill.CustomName);
                int count = lstCharacterSkillAnalyze.Items.Count;
                lblCharacterSkillAnalyze.Text = (count < 1 ? "No" : count.ToString()) + " skill" + (count == 1 ? "" : "s") + " use" + (count == 1 ? "s" : "") + " the " + item.CustomName + " Element:";
            }
        }

        /// <summary>
        /// Enemy skill analyze button click
        /// </summary>
        private void btnEnemySkillAnalyze_Click(object sender, EventArgs e)
        {
            if (sender == btnEnemySkillEffect)
            {
                if (cbEnemySkillEffect.SelectedItem == null)
                    return;
                lstEnemySkillAnalyze.Items.Clear();
                ObjectID item = cbEnemySkillEffect.SelectedItem as ObjectID;
                foreach (Skill skill in MainForm.RomData.EnemySkills)
                    if (skill.Effect == (EffectType)item.ID && !lstEnemySkillAnalyze.Items.Contains(skill.CustomName))
                        lstEnemySkillAnalyze.Items.Add(skill.CustomName);
                int count = lstEnemySkillAnalyze.Items.Count;
                lblEnemySkillAnalyze.Text = (count < 1 ? "No" : count.ToString()) + " skill" + (count == 1 ? "" : "s") + " use" + (count == 1 ? "s" : "") + " the " + item.CustomName + " Effect:";
            }
            else if (sender == btnEnemySkillAtkStat)
            {
                if (cbEnemySkillAtkStat.SelectedItem == null)
                    return;
                lstEnemySkillAnalyze.Items.Clear();
                ObjectID item = cbEnemySkillAtkStat.SelectedItem as ObjectID;
                foreach (Skill skill in MainForm.RomData.EnemySkills)
                    if (skill.Offense == (EffectStatType)item.ID && !lstEnemySkillAnalyze.Items.Contains(skill.CustomName))
                        lstEnemySkillAnalyze.Items.Add(skill.CustomName);
                int count = lstEnemySkillAnalyze.Items.Count;
                lblEnemySkillAnalyze.Text = (count < 1 ? "No" : count.ToString()) + " skill" + (count == 1 ? "" : "s") + " use" + (count == 1 ? "s" : "") + " the " + item.CustomName + " ATK Stat:";
            }
            else if (sender == btnEnemySkillTargetDefenseStat)
            {
                if (cbEnemySkillTargetDefenseStat.SelectedItem == null)
                    return;
                lstEnemySkillAnalyze.Items.Clear();
                ObjectID item = cbEnemySkillTargetDefenseStat.SelectedItem as ObjectID;
                foreach (Skill skill in MainForm.RomData.EnemySkills)
                    if (skill.Defense == (EffectStatType)item.ID && !lstEnemySkillAnalyze.Items.Contains(skill.CustomName))
                        lstEnemySkillAnalyze.Items.Add(skill.CustomName);
                int count = lstEnemySkillAnalyze.Items.Count;
                lblEnemySkillAnalyze.Text = (count < 1 ? "No" : count.ToString()) + " skill" + (count == 1 ? "" : "s") + " use" + (count == 1 ? "s" : "") + " the " + item.CustomName + " Target DEF Stat:";
            }
            else if (sender == btnEnemySkillTarget)
            {
                if (cbEnemySkillTarget.SelectedItem == null)
                    return;
                lstEnemySkillAnalyze.Items.Clear();
                ObjectID item = cbEnemySkillTarget.SelectedItem as ObjectID;
                foreach (Skill skill in MainForm.RomData.EnemySkills)
                    if (skill.Target == (EffectTargetType)item.ID && !lstEnemySkillAnalyze.Items.Contains(skill.CustomName))
                        lstEnemySkillAnalyze.Items.Add(skill.CustomName);
                int count = lstEnemySkillAnalyze.Items.Count;
                lblEnemySkillAnalyze.Text = (count < 1 ? "No" : count.ToString()) + " skill" + (count == 1 ? "" : "s") + " use" + (count == 1 ? "s" : "") + " the " + item.CustomName + " Target:";
            }
            else if (sender == btnEnemySkillElement)
            {
                if (cbEnemySkillElement.SelectedItem == null)
                    return;
                lstEnemySkillAnalyze.Items.Clear();
                ObjectID item = cbEnemySkillElement.SelectedItem as ObjectID;
                foreach (Skill skill in MainForm.RomData.EnemySkills)
                    if (skill.Element == (ElementType)item.ID && !lstEnemySkillAnalyze.Items.Contains(skill.CustomName))
                        lstEnemySkillAnalyze.Items.Add(skill.CustomName);
                int count = lstEnemySkillAnalyze.Items.Count;
                lblEnemySkillAnalyze.Text = (count < 1 ? "No" : count.ToString()) + " skill" + (count == 1 ? "" : "s") + " use" + (count == 1 ? "s" : "") + " the " + item.CustomName + " Element:";
            }
        }

        /// <summary>
        /// Load techniques and skills data
        /// </summary>
        private void LoadData()
        {
            // Load sort type drop downs
            foreach (ComboBox cb in new List<ComboBox>() { cbTechniquesSort, cbCharacterSkillsSort, cbEnemySkillsSort })
            {
                cb.Items.Clear();
                foreach (int value in Enum.GetValues(typeof(SortType)))
                    cb.Items.Add(new ObjectID(value, EnumMethods.GetDescription(typeof(SortType), (SortType)value)));
            }

            // Load element type drop downs
            foreach (ComboBox cb in new List<ComboBox>() { cbCharacterTechniqueElement, cbCharacterSkillElement, cbEnemySkillElement })
            {
                cb.Items.Clear();
                foreach (int value in Enum.GetValues(typeof(ElementType)))
                    cb.Items.Add(new ObjectID(value, EnumMethods.GetDescription(typeof(ElementType), (ElementType)value)));
            }

            // Load target type drop downs
            foreach (ComboBox cb in new List<ComboBox>() { cbCharacterTechniqueTarget, cbCharacterSkillTarget, cbEnemySkillTarget })
            {
                cb.Items.Clear();
                foreach (int value in Enum.GetValues(typeof(EffectTargetType)))
                    cb.Items.Add(new ObjectID(value, EnumMethods.GetDescription(typeof(EffectTargetType), (EffectTargetType)value)));
            }

            // Load effect type drop downs
            foreach (ComboBox cb in new List<ComboBox>() { cbCharacterTechniqueEffect, cbCharacterSkillEffect, cbEnemySkillEffect })
            {
                cb.Items.Clear();
                foreach (int value in Enum.GetValues(typeof(EffectType)))
                    cb.Items.Add(new ObjectID(value, EnumMethods.GetDescription(typeof(EffectType), (EffectType)value)));
            }

            // Load effect area type drop downs
            foreach (ComboBox cb in new List<ComboBox>() { cbCharacterTechniqueEffectArea, cbCharacterSkillEffectArea })
            {
                cb.Items.Clear();
                foreach (int value in Enum.GetValues(typeof(EffectAreaType)))
                    cb.Items.Add(new ObjectID(value, EnumMethods.GetDescription(typeof(EffectAreaType), (EffectAreaType)value)));
            }

            // Load effect stat type drop downs
            foreach (ComboBox cb in new List<ComboBox>() { cbCharacterSkillAtkStat, cbCharacterTechniqueTargetDefenseStat, cbCharacterSkillTargetDefenseStat, cbEnemySkillAtkStat, cbEnemySkillTargetDefenseStat })
            {
                int i = 0;
                cb.Items.Clear();
                foreach (int value in Enum.GetValues(typeof(EffectStatType)))
                {
                    if ((i <= 7 || value == (int)EffectStatType.DisabledIfSealed) && cb != cbCharacterSkillAtkStat)
                        cb.Items.Add(new ObjectID(value, EnumMethods.GetDescription(typeof(EffectStatType), (EffectStatType)value)));

                    if (cb == cbCharacterSkillAtkStat && value != (int)EffectStatType.DisabledIfSealed)
                        cb.Items.Add(new ObjectID(value, EnumMethods.GetDescription(typeof(EffectStatType), (EffectStatType)value)));
                    i++;
                }
            }

            if (HasData)
            {
                // Load character techniques drop down
                foreach (ComboBox cb in new List<ComboBox>() { cbCharacterTechniques })
                {
                    cb.Items.Clear();
                    foreach (Technique technique in MainForm.RomData.Techniques)
                        cb.Items.Add(new ObjectID(technique.ID, technique.CustomName));
                }

                // Load character skills drop down
                foreach (ComboBox cb in new List<ComboBox>() { cbCharacterSkills })
                {
                    cb.Items.Clear();
                    foreach (Skill skill in MainForm.RomData.CharacterSkills)
                        cb.Items.Add(new ObjectID(skill.ID, skill.CustomName));
                }

                // Load action drop drowns with enemy skills
                foreach (ComboBox cb in new List<ComboBox>() { cbEnemySkills })
                {
                    cb.Items.Clear();
                    foreach (Skill skill in MainForm.RomData.EnemySkills)
                        cb.Items.Add(new ObjectID(skill.ID, skill.CustomName));
                }

                foreach (ComboBox cb in new List<ComboBox>() { cbCharacterTechniques, cbCharacterSkills, cbEnemySkills })
                    cb.SelectedIndex = 0;
            }

            // Select Ascending
            foreach (ComboBox cb in new List<ComboBox>() { cbTechniquesSort, cbCharacterSkillsSort, cbEnemySkillsSort })
                cb.SelectedIndex = 1;
        }

        /// <summary>
        /// Sets character technique fields for selected technique
        /// </summary>
        private void SetTechniqueFields()
        {
            if (!HasData)
                return;

            ObjectID item = cbCharacterTechniques.SelectedItem as ObjectID;
            Technique technique = MainForm.RomData.Techniques.Find(x => x.ID == item.ID);
            _selectedObject = (technique as ObjectID);
            MainForm.SetSelectedInformation(this, SelectedInformation);
            txtCharacterTechniqueName.Text = technique.Name;
            cbCharacterTechniqueEffect.SelectedIndex = MainForm.GetIndexByValue(cbCharacterTechniqueEffect, (int)technique.Effect);
            numCharacterTechniqueCost.Text = technique.TPCost.ToString();
            numCharacterTechniqueEffectAmount.Text = technique.EffectAmount.ToString();
            cbCharacterTechniqueTargetDefenseStat.SelectedIndex = MainForm.GetIndexByValue(cbCharacterTechniqueTargetDefenseStat, (int)technique.Defense);
            cbCharacterTechniqueEffectArea.SelectedIndex = MainForm.GetIndexByValue(cbCharacterTechniqueEffectArea, (int)technique.EffectArea);
            cbCharacterTechniqueTarget.SelectedIndex = MainForm.GetIndexByValue(cbCharacterTechniqueTarget, (int)technique.Target);
            cbCharacterTechniqueElement.SelectedIndex = MainForm.GetIndexByValue(cbCharacterTechniqueElement, (int)technique.Element);
            lstCharacterTechniqueAnalyze.Items.Clear();
            foreach (Character character in MainForm.RomData.Characters)
                foreach (int characterTechnique in character.TechniqueIDs)
                    if (characterTechnique == item.ID && !lstCharacterTechniqueAnalyze.Items.Contains(character.CustomName))
                        lstCharacterTechniqueAnalyze.Items.Add(character.CustomName);
            int count = lstCharacterTechniqueAnalyze.Items.Count;
            lblCharacterTechniqueAnalyze.Text = (count < 1 ? "No" : count.ToString()) + " character" + (count == 1 ? "" : "s") + " use" + (count == 1 ? "s" : "") + " this technique:";
        }

        /// <summary>
        /// Sets character skill fields for selected skill
        /// </summary>
        private void SetCharacterSkillFields()
        {
            if (!HasData)
                return;

            ObjectID item = cbCharacterSkills.SelectedItem as ObjectID;
            Skill skill = MainForm.RomData.CharacterSkills.Find(x => x.ID == item.ID);
            _selectedObject = (skill as ObjectID);
            MainForm.SetSelectedInformation(this, SelectedInformation);
            txtCharacterSkillName.Text = skill.Name;
            cbCharacterSkillEffect.SelectedIndex = MainForm.GetIndexByValue(cbCharacterSkillEffect, (int)skill.Effect);
            cbCharacterSkillAtkStat.SelectedIndex = MainForm.GetIndexByValue(cbCharacterSkillAtkStat, (int)skill.Offense);
            numCharacterSkillEffectChance.Text = skill.EffectAmount.ToString();
            cbCharacterSkillTargetDefenseStat.SelectedIndex = MainForm.GetIndexByValue(cbCharacterSkillTargetDefenseStat, (int)skill.Defense);
            cbCharacterSkillEffectArea.SelectedIndex = MainForm.GetIndexByValue(cbCharacterSkillEffectArea, (int)skill.EffectArea);
            cbCharacterSkillTarget.SelectedIndex = MainForm.GetIndexByValue(cbCharacterSkillTarget, (int)skill.Target);
            cbCharacterSkillElement.SelectedIndex = MainForm.GetIndexByValue(cbCharacterSkillElement, (int)skill.Element);
            lstCharacterSkillAnalyze.Items.Clear();
            foreach (Character character in MainForm.RomData.Characters)
                foreach (int characterSkill in character.SkillIDs)
                    if (characterSkill == item.ID && !lstCharacterSkillAnalyze.Items.Contains(character.CustomName))
                        lstCharacterSkillAnalyze.Items.Add(character.CustomName);
            int count = lstCharacterSkillAnalyze.Items.Count;
            lblCharacterSkillAnalyze.Text = (count < 1 ? "No" : count.ToString()) + " character" + (count == 1 ? "" : "s") + " use" + (count == 1 ? "s" : "") + " this skill:";
        }

        /// <summary>
        /// Sets enemy skill fields for selected skill
        /// </summary>
        private void SetEnemySkillFields()
        {
            if (!HasData)
                return;

            ObjectID item = cbEnemySkills.SelectedItem as ObjectID;
            Skill skill = MainForm.RomData.EnemySkills.Find(x => x.ID == item.ID);
            _selectedObject = (skill as ObjectID);
            MainForm.SetSelectedInformation(this, SelectedInformation);
            txtEnemySkillName.Text = skill.Name;
            cbEnemySkillEffect.SelectedIndex = MainForm.GetIndexByValue(cbEnemySkillEffect, (int)skill.Effect);
            cbEnemySkillAtkStat.SelectedIndex = MainForm.GetIndexByValue(cbEnemySkillAtkStat, (int)skill.Offense);
            numEnemySkillEffectChance.Text = skill.EffectAmount.ToString();
            cbEnemySkillTarget.SelectedIndex = MainForm.GetIndexByValue(cbEnemySkillTarget, (int)skill.Target);
            cbEnemySkillTargetDefenseStat.SelectedIndex = MainForm.GetIndexByValue(cbEnemySkillAtkStat, (int)skill.Defense);
            cbEnemySkillElement.SelectedIndex = MainForm.GetIndexByValue(cbEnemySkillElement, (int)skill.Element);
            lstEnemySkillAnalyze.Items.Clear();
            foreach (Enemy enemy in MainForm.RomData.Enemies)
            {
                foreach (int action in enemy.ActionIDs)
                {
                    if (action == item.ID && !lstEnemySkillAnalyze.Items.Contains(enemy.CustomName))
                        lstEnemySkillAnalyze.Items.Add(enemy.CustomName);
                }

                foreach (Condition condition in enemy.Conditions)
                {
                    if (condition.ActionID == item.ID && condition.Trigger != 0 && !lstEnemySkillAnalyze.Items.Contains(enemy.CustomName))
                        lstEnemySkillAnalyze.Items.Add(enemy.CustomName);
                }
            }
            int count = lstEnemySkillAnalyze.Items.Count;
            lblEnemySkillAnalyze.Text = (count < 1 ? "No" : count.ToString()) + (count == 1 ? " enemy" : " enemies") + " use" + (count == 1 ? "s" : "") + " this skill:";
        }

        /// <summary>
        /// Gets the selected object information
        /// </summary>
        /// <returns>Object information</returns>
        private string GetSelectedInfo()
        {
            if (!HasData || _selectedObject == null)
                return "None";

            return MainForm.GetSelectedInformation(_selectedObject);
        }
    }
}
