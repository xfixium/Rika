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
    public partial class DataForm : Form
    {
        /// <summary>
        /// Fields
        /// </summary>
        private StatType _stat;
        private object _list;

        /// <summary>
        /// Constructors
        /// </summary>
        /// <param name="title">Window title</param>
        /// <param name="list">The list to use</param>
        /// <param name="item">The item that will have focus in the list</param>
        /// <param name="stat">The property to display, and is based on the comparisons</param>
        public DataForm(string title, object list, string item, StatType stat)
        {
            InitializeComponent();
            Text = title;
            _list = list;
            _stat = stat;
            grdMain.AutoGenerateColumns = false;
            foreach (ComboBox cb in new List<ComboBox>() { cbSort })
            {
                cb.Items.Clear();
                foreach (int value in Enum.GetValues(typeof(SortType)))
                    cb.Items.Add(new ObjectID(value, EnumMethods.GetDescription(typeof(SortType), (SortType)value)));
                cb.SelectedIndex = 1;
            }
        }

        /// <summary>
        /// Sort selection changed
        /// </summary>
        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortType sortType = (SortType)(cbSort.SelectedItem as ObjectID).ID;
            if (_list is List<Enemy>)
            {
                switch (sortType)
                {
                    case SortType.Asc:
                        switch (_stat)
                        {
                            case StatType.HP: (_list as List<Enemy>).Sort((a, b) => a.HP.CompareTo(b.HP)); break;
                            case StatType.Exp: (_list as List<Enemy>).Sort((a, b) => a.Exp.CompareTo(b.Exp)); break;
                            case StatType.Meseta: (_list as List<Enemy>).Sort((a, b) => a.Meseta.CompareTo(b.Meseta)); break;
                            case StatType.Attack: (_list as List<Enemy>).Sort((a, b) => a.Attack.CompareTo(b.Attack)); break;
                            case StatType.Defense: (_list as List<Enemy>).Sort((a, b) => a.Defense.CompareTo(b.Defense)); break;
                            case StatType.Strength: (_list as List<Enemy>).Sort((a, b) => a.Strength.CompareTo(b.Strength)); break;
                            case StatType.Mental: (_list as List<Enemy>).Sort((a, b) => a.Mental.CompareTo(b.Mental)); break;
                            case StatType.Agility: (_list as List<Enemy>).Sort((a, b) => a.Agility.CompareTo(b.Agility)); break;
                            case StatType.Dexterity: (_list as List<Enemy>).Sort((a, b) => a.Dexterity.CompareTo(b.Dexterity)); break;
                            case StatType.MagicDefense: (_list as List<Enemy>).Sort((a, b) => a.MagicDefense.CompareTo(b.MagicDefense)); break;
                            case StatType.PhysicalResistance: (_list as List<Enemy>).Sort((a, b) => ((int)b.Resistances[0]).CompareTo((int)a.Resistances[0])); break;
                            case StatType.RadiationResistance: (_list as List<Enemy>).Sort((a, b) => ((int)b.Resistances[1]).CompareTo((int)a.Resistances[1])); break;
                            case StatType.FireResistance: (_list as List<Enemy>).Sort((a, b) => ((int)b.Resistances[2]).CompareTo((int)a.Resistances[2])); break;
                            case StatType.GravityResistance: (_list as List<Enemy>).Sort((a, b) => ((int)b.Resistances[3]).CompareTo((int)a.Resistances[3])); break;
                            case StatType.WaterResistance: (_list as List<Enemy>).Sort((a, b) => ((int)b.Resistances[4]).CompareTo((int)a.Resistances[4])); break;
                            case StatType.EnergyResistance: (_list as List<Enemy>).Sort((a, b) => ((int)b.Resistances[5]).CompareTo((int)a.Resistances[5])); break;
                            case StatType.ElectricResistance: (_list as List<Enemy>).Sort((a, b) => ((int)b.Resistances[6]).CompareTo((int)a.Resistances[6])); break;
                            case StatType.HolyResistance: (_list as List<Enemy>).Sort((a, b) => ((int)b.Resistances[7]).CompareTo((int)a.Resistances[7])); break;
                            case StatType.DeathResistance: (_list as List<Enemy>).Sort((a, b) => ((int)b.Resistances[8]).CompareTo((int)a.Resistances[8])); break;
                            case StatType.BiologicalResistance: (_list as List<Enemy>).Sort((a, b) => ((int)b.Resistances[9]).CompareTo((int)a.Resistances[9])); break;
                            case StatType.PsychicResistance: (_list as List<Enemy>).Sort((a, b) => ((int)b.Resistances[10]).CompareTo((int)a.Resistances[10])); break;
                            case StatType.MechanicalResistance: (_list as List<Enemy>).Sort((a, b) => ((int)b.Resistances[11]).CompareTo((int)a.Resistances[11])); break;
                            case StatType.LightResistance: (_list as List<Enemy>).Sort((a, b) => ((int)b.Resistances[12]).CompareTo((int)a.Resistances[12])); break;
                            case StatType.DestroyResistance: (_list as List<Enemy>).Sort((a, b) => ((int)b.Resistances[13]).CompareTo((int)a.Resistances[13])); break;
                            case StatType.ResistanceGrade: (_list as List<Enemy>).Sort((a, b) => ((int)b.ResistanceScore).CompareTo((int)a.ResistanceScore)); break;
                        }
                        break;
                    case SortType.Desc:
                        switch (_stat)
                        {
                            case StatType.HP: (_list as List<Enemy>).Sort((a, b) => b.HP.CompareTo(a.HP)); break;
                            case StatType.Exp: (_list as List<Enemy>).Sort((a, b) => b.Exp.CompareTo(a.Exp)); break;
                            case StatType.Meseta: (_list as List<Enemy>).Sort((a, b) => b.Meseta.CompareTo(a.Meseta)); break;
                            case StatType.Attack: (_list as List<Enemy>).Sort((a, b) => b.Attack.CompareTo(a.Attack)); break;
                            case StatType.Defense: (_list as List<Enemy>).Sort((a, b) => b.Defense.CompareTo(a.Defense)); break;
                            case StatType.Strength: (_list as List<Enemy>).Sort((a, b) => b.Strength.CompareTo(a.Strength)); break;
                            case StatType.Mental: (_list as List<Enemy>).Sort((a, b) => b.Mental.CompareTo(a.Mental)); break;
                            case StatType.Agility: (_list as List<Enemy>).Sort((a, b) => b.Agility.CompareTo(a.Agility)); break;
                            case StatType.Dexterity: (_list as List<Enemy>).Sort((a, b) => b.Dexterity.CompareTo(a.Dexterity)); break;
                            case StatType.MagicDefense: (_list as List<Enemy>).Sort((a, b) => b.MagicDefense.CompareTo(a.MagicDefense)); break;
                            case StatType.PhysicalResistance: (_list as List<Enemy>).Sort((a, b) => ((int)a.Resistances[0]).CompareTo((int)b.Resistances[0])); break;
                            case StatType.RadiationResistance: (_list as List<Enemy>).Sort((a, b) => ((int)a.Resistances[1]).CompareTo((int)b.Resistances[1])); break;
                            case StatType.FireResistance: (_list as List<Enemy>).Sort((a, b) => ((int)a.Resistances[2]).CompareTo((int)b.Resistances[2])); break;
                            case StatType.GravityResistance: (_list as List<Enemy>).Sort((a, b) => ((int)a.Resistances[3]).CompareTo((int)b.Resistances[3])); break;
                            case StatType.WaterResistance: (_list as List<Enemy>).Sort((a, b) => ((int)a.Resistances[4]).CompareTo((int)b.Resistances[4])); break;
                            case StatType.EnergyResistance: (_list as List<Enemy>).Sort((a, b) => ((int)a.Resistances[5]).CompareTo((int)b.Resistances[5])); break;
                            case StatType.ElectricResistance: (_list as List<Enemy>).Sort((a, b) => ((int)a.Resistances[6]).CompareTo((int)b.Resistances[6])); break;
                            case StatType.HolyResistance: (_list as List<Enemy>).Sort((a, b) => ((int)a.Resistances[7]).CompareTo((int)b.Resistances[7])); break;
                            case StatType.DeathResistance: (_list as List<Enemy>).Sort((a, b) => ((int)a.Resistances[8]).CompareTo((int)b.Resistances[8])); break;
                            case StatType.BiologicalResistance: (_list as List<Enemy>).Sort((a, b) => ((int)a.Resistances[9]).CompareTo((int)b.Resistances[9])); break;
                            case StatType.PsychicResistance: (_list as List<Enemy>).Sort((a, b) => ((int)a.Resistances[10]).CompareTo((int)b.Resistances[10])); break;
                            case StatType.MechanicalResistance: (_list as List<Enemy>).Sort((a, b) => ((int)a.Resistances[11]).CompareTo((int)b.Resistances[11])); break;
                            case StatType.LightResistance: (_list as List<Enemy>).Sort((a, b) => ((int)a.Resistances[12]).CompareTo((int)b.Resistances[12])); break;
                            case StatType.DestroyResistance: (_list as List<Enemy>).Sort((a, b) => ((int)a.Resistances[13]).CompareTo((int)b.Resistances[13])); break;
                            case StatType.ResistanceGrade: (_list as List<Enemy>).Sort((a, b) => ((int)a.ResistanceScore).CompareTo((int)b.ResistanceScore)); break;
                        }
                        break;
                    default:
                        (_list as List<Enemy>).Sort((a, b) => a.CustomName.CompareTo(b.CustomName)); break;
                }
            }
            else if (_list is List<Character>)
            {
                switch (sortType)
                {
                    case SortType.Asc:
                        switch (_stat)
                        {
                            case StatType.PhysicalResistance: (_list as List<Character>).Sort((a, b) => ((int)b.Resistances[0]).CompareTo((int)a.Resistances[0])); break;
                            case StatType.RadiationResistance: (_list as List<Character>).Sort((a, b) => ((int)b.Resistances[1]).CompareTo((int)a.Resistances[1])); break;
                            case StatType.FireResistance: (_list as List<Character>).Sort((a, b) => ((int)b.Resistances[2]).CompareTo((int)a.Resistances[2])); break;
                            case StatType.GravityResistance: (_list as List<Character>).Sort((a, b) => ((int)b.Resistances[3]).CompareTo((int)a.Resistances[3])); break;
                            case StatType.WaterResistance: (_list as List<Character>).Sort((a, b) => ((int)b.Resistances[4]).CompareTo((int)a.Resistances[4])); break;
                            case StatType.EnergyResistance: (_list as List<Character>).Sort((a, b) => ((int)b.Resistances[5]).CompareTo((int)a.Resistances[5])); break;
                            case StatType.ElectricResistance: (_list as List<Character>).Sort((a, b) => ((int)b.Resistances[6]).CompareTo((int)a.Resistances[6])); break;
                            case StatType.HolyResistance: (_list as List<Character>).Sort((a, b) => ((int)b.Resistances[7]).CompareTo((int)a.Resistances[7])); break;
                            case StatType.DeathResistance: (_list as List<Character>).Sort((a, b) => ((int)b.Resistances[8]).CompareTo((int)a.Resistances[8])); break;
                            case StatType.BiologicalResistance: (_list as List<Character>).Sort((a, b) => ((int)b.Resistances[9]).CompareTo((int)a.Resistances[9])); break;
                            case StatType.PsychicResistance: (_list as List<Character>).Sort((a, b) => ((int)b.Resistances[10]).CompareTo((int)a.Resistances[10])); break;
                            case StatType.MechanicalResistance: (_list as List<Character>).Sort((a, b) => ((int)b.Resistances[11]).CompareTo((int)a.Resistances[11])); break;
                            case StatType.LightResistance: (_list as List<Character>).Sort((a, b) => ((int)b.Resistances[12]).CompareTo((int)a.Resistances[12])); break;
                            case StatType.DestroyResistance: (_list as List<Character>).Sort((a, b) => ((int)b.Resistances[13]).CompareTo((int)a.Resistances[13])); break;
                        }
                        break;
                    case SortType.Desc:
                        switch (_stat)
                        {
                            case StatType.PhysicalResistance: (_list as List<Character>).Sort((a, b) => ((int)a.Resistances[0]).CompareTo((int)b.Resistances[0])); break;
                            case StatType.RadiationResistance: (_list as List<Character>).Sort((a, b) => ((int)a.Resistances[1]).CompareTo((int)b.Resistances[1])); break;
                            case StatType.FireResistance: (_list as List<Character>).Sort((a, b) => ((int)a.Resistances[2]).CompareTo((int)b.Resistances[2])); break;
                            case StatType.GravityResistance: (_list as List<Character>).Sort((a, b) => ((int)a.Resistances[3]).CompareTo((int)b.Resistances[3])); break;
                            case StatType.WaterResistance: (_list as List<Character>).Sort((a, b) => ((int)a.Resistances[4]).CompareTo((int)b.Resistances[4])); break;
                            case StatType.EnergyResistance: (_list as List<Character>).Sort((a, b) => ((int)a.Resistances[5]).CompareTo((int)b.Resistances[5])); break;
                            case StatType.ElectricResistance: (_list as List<Character>).Sort((a, b) => ((int)a.Resistances[6]).CompareTo((int)b.Resistances[6])); break;
                            case StatType.HolyResistance: (_list as List<Character>).Sort((a, b) => ((int)a.Resistances[7]).CompareTo((int)b.Resistances[7])); break;
                            case StatType.DeathResistance: (_list as List<Character>).Sort((a, b) => ((int)a.Resistances[8]).CompareTo((int)b.Resistances[8])); break;
                            case StatType.BiologicalResistance: (_list as List<Character>).Sort((a, b) => ((int)a.Resistances[9]).CompareTo((int)b.Resistances[9])); break;
                            case StatType.PsychicResistance: (_list as List<Character>).Sort((a, b) => ((int)a.Resistances[10]).CompareTo((int)b.Resistances[10])); break;
                            case StatType.MechanicalResistance: (_list as List<Character>).Sort((a, b) => ((int)a.Resistances[11]).CompareTo((int)b.Resistances[11])); break;
                            case StatType.LightResistance: (_list as List<Character>).Sort((a, b) => ((int)a.Resistances[12]).CompareTo((int)b.Resistances[12])); break;
                            case StatType.DestroyResistance: (_list as List<Character>).Sort((a, b) => ((int)a.Resistances[13]).CompareTo((int)b.Resistances[13])); break;
                        }
                        break;
                    default:
                        (_list as List<Character>).Sort((a, b) => a.CustomName.CompareTo(b.CustomName)); break;
                }
            }
            SetGrid();
        }

        /// <summary>
        /// OK button click
        /// </summary>
        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Sets the grid data
        /// </summary>
        private void SetGrid()
        {
            colName.DataPropertyName = "CustomName";
            colValue.DataPropertyName = _stat.ToString();
            colValue.HeaderText = EnumMethods.GetDescription(typeof(StatType), _stat);
            BindingSource source = new BindingSource { DataSource = _list };
            grdMain.DataSource = source;
        }
    }
}
