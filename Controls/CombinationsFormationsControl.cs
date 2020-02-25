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
    public partial class CombinationsFormationsControl : UserControl
    {
        /// <summary>
        /// Fields
        /// </summary>
        private MainForm _mainForm = null;

        /// <summary>
        /// Properties
        /// </summary>
        public MainForm MainForm { get { return _mainForm; } set { _mainForm = value; LoadData(); } }
        private bool HasData { get { return _mainForm != null && _mainForm.RomData != null; } }

        /// <summary>
        /// Constructors
        /// </summary>
        public CombinationsFormationsControl()
        {
            InitializeComponent();
            lstFormationGroup1.DrawItem += MainForm.ListBoxDrawItem;
            lstFormationGroup2.DrawItem += MainForm.ListBoxDrawItem;
        }

        /// <summary>
        /// Selected formation changed
        /// </summary>
        private void cbFormations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedItem != null)
                SetFormationFields();
        }

        /// <summary>
        /// Sort selection changed
        /// </summary>
        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortType sortType = SortType.None;
            object[] array = null;
            List<object> items = new List<object>();
            array = new object[cbFormations.Items.Count];
            cbFormations.Items.CopyTo(array, 0);
            items.AddRange(array);
            sortType = cbFormationsSort.SelectedIndex == 1 ? SortType.Asc : cbFormationsSort.SelectedIndex == 2 ? SortType.Desc : SortType.None;
            switch (sortType)
            {
                case SortType.Asc: items.Sort((x, y) => string.Compare((x as ObjectID).CustomName, (y as ObjectID).CustomName)); break;
                case SortType.Desc: items.Sort((x, y) => string.Compare((y as ObjectID).CustomName, (x as ObjectID).CustomName)); break;
                default: items.Sort((x, y) => (x as ObjectID).ID.CompareTo((y as ObjectID).ID)); break;
            }
            cbFormations.Items.Clear();
            cbFormations.Items.AddRange(items.ToArray());
            cbFormations.SelectedIndex = cbFormations.Items.Count > 0 ? 0 : -1;
        }

        /// <summary>
        /// Loads combination and formation data
        /// </summary>
        private void LoadData()
        {
            // Load sort types to UI
            foreach (ComboBox cb in new List<ComboBox>() { cbFormationsSort })
            {
                cb.Items.Clear();
                foreach (object value in Enum.GetValues(typeof(SortType)))
                    cb.Items.Add(value.ToString());
            }

            if (HasData)
            {
                // Load formations to UI
                foreach (ComboBox cb in new List<ComboBox>() { cbFormations })
                {
                    cb.Items.Clear();
                    foreach (Formation formation in MainForm.RomData.Formations)
                        cb.Items.Add(new ObjectID(formation.ID, formation.CustomName));
                }

                // Load items to UI
                foreach (ComboBox cb in new List<ComboBox>() { cbItemDrop })
                {
                    cb.Items.Clear();
                    foreach (Item item in MainForm.RomData.Items)
                        cb.Items.Add(new ObjectID(item.ID, item.CustomName));
                }

                // Select first item
                foreach (ComboBox cb in new List<ComboBox>() { cbFormations })
                    if (cb.Items.Count > 0)
                        cb.SelectedIndex = 0;
            }

            // Select second item
            foreach (ComboBox cb in new List<ComboBox>() { cbFormationsSort })
                if (cb.Items.Count > 1)
                    cb.SelectedIndex = 1;
        }

        /// <summary>
        /// Sets formation fields for selected formation
        /// </summary>
        private void SetFormationFields()
        {
            if (!HasData)
                return;

            ObjectID item = cbFormations.SelectedItem as ObjectID;
            Formation formation = MainForm.RomData.Formations.Find(x => x.ID == item.ID);
            numSurpriseRate.Value = formation.SurpriseRate;
            numEscapeRate.Value = formation.EscapeRate;
            numItemDropRate.Value = formation.ItemDropRate;
            cbItemDrop.SelectedIndex = MainForm.GetIndexByValue(cbItemDrop, formation.ItemID);
            pnlFormationGraphics.Image = MainForm.RomData.GetFormationImage(SpriteType.MotaviaGrassBG, formation);
        }

        /// <summary>
        /// 
        /// </summary>
        private void SetFormationImage()
        {

        }
    }
}
