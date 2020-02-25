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
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Rika.Data;
using Rika.Forms;

namespace Rika.Controls
{
    public partial class ItemsControl : UserControl
    {
        /// <summary>
        /// Fields
        /// </summary>
        private MainForm _mainForm = null;

        /// <summary>
        /// Properties
        /// </summary>
        public MainForm MainForm { get { return _mainForm; } set { _mainForm = value; LoadData(); } }
        public int ItemCount { get { return grdItems.Rows.Count; } }
        public string SelectedInformation { get { return GetSelectedInfo(); } }
        private bool HasData { get { return _mainForm != null && _mainForm.RomData != null; } }

        /// <summary>
        /// Constructors
        /// </summary>
        public ItemsControl()
        {
            InitializeComponent();
            grdItems.RowsDefaultCellStyle.BackColor = SystemColors.Control;
            grdItems.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.Window;
            grdItems.AutoGenerateColumns = false;
        }

        /// <summary>
        /// Selected item changed
        /// </summary>
        private void grdItems_SelectionChanged(object sender, EventArgs e)
        {
            MainForm.SetSelectedInformation(this, SelectedInformation);
            SetDescription();
        }

        /// <summary>
        /// Filter control event
        /// </summary>
        private void ctrlFilter_Event(object sender, EventArgs e)
        {
            if (!HasData)
                return;

            if (sender == btnItemFilterClear)
                cbItemCharacterFilter.SelectedIndex = cbItemTypeFilter.SelectedIndex = cbItemElementFilter.SelectedIndex = cbItemEffectFilter.SelectedIndex = 0;

            Item[] array = new Item[MainForm.RomData.Items.Count];
            List<Item> items = new List<Item>();
            MainForm.RomData.Items.CopyTo(array, 0);
            items.AddRange(array);
            switch (cbItemsSort.SelectedIndex)
            {
                case (int)SortType.Asc: items.Sort((x, y) => string.Compare((x as ObjectID).CustomName, (y as ObjectID).CustomName)); break;
                case (int)SortType.Desc: items.Sort((x, y) => string.Compare((y as ObjectID).CustomName, (x as ObjectID).CustomName)); break;
                default: items.Sort((x, y) => (x as ObjectID).ID.CompareTo((y as ObjectID).ID)); break;
            }
            grdItems.AutoGenerateColumns = false;
            grdItems.DataSource = FilterItems(items);
            SetDescription();
            MainForm.SetStatusText(this, "Item Count: ", grdItems.Rows.Count.ToString());
        }

        /// <summary>
        /// Loads item data
        /// </summary>
        private void LoadData()
        {
            // Load item character filter types to UI
            foreach (ComboBox cb in new List<ComboBox>() { cbItemCharacterFilter })
            {
                cb.Items.Clear();
                foreach (int value in Enum.GetValues(typeof(ItemCharacterFilterType)))
                    cb.Items.Add(new ObjectID(value, EnumMethods.GetDescription(typeof(ItemCharacterFilterType), (ItemCharacterFilterType)value)));
            }

            // Load item type filter types to UI
            foreach (ComboBox cb in new List<ComboBox>() { cbItemTypeFilter })
            {
                cb.Items.Clear();
                foreach (int value in Enum.GetValues(typeof(ItemTypeFilterType)))
                    cb.Items.Add(new ObjectID(value, EnumMethods.GetDescription(typeof(ItemTypeFilterType), (ItemTypeFilterType)value)));
            }

            // Load item element filter types to UI
            foreach (ComboBox cb in new List<ComboBox>() { cbItemElementFilter })
            {
                cb.Items.Clear();
                foreach (int value in Enum.GetValues(typeof(ItemElementFilterType)))
                    cb.Items.Add(new ObjectID(value, EnumMethods.GetDescription(typeof(ItemElementFilterType), (ItemElementFilterType)value)));
            }

            // Load item effect filter types to UI
            foreach (ComboBox cb in new List<ComboBox>() { cbItemEffectFilter })
            {
                cb.Items.Clear();
                foreach (int value in Enum.GetValues(typeof(ItemEffectFilterType)))
                    cb.Items.Add(new ObjectID(value, EnumMethods.GetDescription(typeof(ItemEffectFilterType), (ItemEffectFilterType)value)));
            }

            // Load sort types to UI
            foreach (ComboBox cb in new List<ComboBox>() { cbItemsSort })
            {
                cb.Items.Clear();
                foreach (object value in Enum.GetValues(typeof(SortType)))
                    cb.Items.Add(value.ToString());
            }

            // If there is data, add items to item grid
            if (HasData)
            {
                BindingSource source = new BindingSource { DataSource = MainForm.RomData.Items };
                grdItems.DataSource = source;
                grdItems.Rows.RemoveAt(0);
            }

            // Select second item
            foreach (ComboBox cb in new List<ComboBox>() { cbItemsSort })
                if (cb.Items.Count > 1)
                    cb.SelectedIndex = 1;

            // Select first item
            foreach (ComboBox cb in new List<ComboBox>() { cbItemCharacterFilter, cbItemTypeFilter, cbItemElementFilter, cbItemEffectFilter })
                if (cb.Items.Count > 0)
                    cb.SelectedIndex = 0;
        }

        /// <summary>
        /// Filters the given list of items
        /// </summary>
        /// <returns>List of filtered items</returns>
        private List<Item> FilterItems(List<Item> items)
        {
            int[] filter = new int[4];
            filter[0] = cbItemCharacterFilter.SelectedItem == null ? 0 : (cbItemCharacterFilter.SelectedItem as ObjectID).ID;
            filter[1] = cbItemTypeFilter.SelectedItem == null ? 0 : (cbItemTypeFilter.SelectedItem as ObjectID).ID;
            filter[2] = cbItemElementFilter.SelectedItem == null ? 0 : (cbItemElementFilter.SelectedItem as ObjectID).ID;
            filter[3] = cbItemEffectFilter.SelectedItem == null ? 0 : (cbItemEffectFilter.SelectedItem as ObjectID).ID;

            if (filter[0] + filter[1] + filter[2] == 0 + filter[3])
                return items;

            List<Item> filtered = items.ToList();

            // Filter by character or race
            if (filter[0] != 0)
            {
                if (filter[0] == (int)ItemCharacterFilterType.Androids)
                    filtered.RemoveAll(x => !x.EligibleCharactersByID.Contains(CharacterType.Wren) && !x.EligibleCharactersByID.Contains(CharacterType.Demi));
                else if (filter[0] == (int)ItemCharacterFilterType.Humans)
                    filtered.RemoveAll(x => !x.EligibleCharactersByID.Contains(CharacterType.Alys) && !x.EligibleCharactersByID.Contains(CharacterType.Chaz) && !x.EligibleCharactersByID.Contains(CharacterType.Gryz) &&
                        !x.EligibleCharactersByID.Contains(CharacterType.Hahn) && !x.EligibleCharactersByID.Contains(CharacterType.Kyra) && !x.EligibleCharactersByID.Contains(CharacterType.Raja) &&
                        !x.EligibleCharactersByID.Contains(CharacterType.Rika) && !x.EligibleCharactersByID.Contains(CharacterType.Gryz));
                else if (filter[0] > (int)ItemCharacterFilterType.Humans)
                    filtered.RemoveAll(x => !x.EligibleCharactersByID.Contains((CharacterType)(filter[0] - 3)));
            }

            // Filter by item type
            if (filter[1] != 0)
            {
                if (filter[1] == (int)ItemTypeFilterType.Battle)
                    filtered.RemoveAll(x => x.Type == ItemAreaType.None || x.Type == ItemAreaType.NonBattle || x.Type == ItemAreaType.Story || x.Type == ItemAreaType.Useable);
                else if (filter[1] == (int)ItemTypeFilterType.Weapon)
                    filtered.RemoveAll(x => x.Type != ItemAreaType.OneHandedOneTarget && x.Type != ItemAreaType.OneHandedMultiTarget && 
                    x.Type != ItemAreaType.TwoHandedOneTarget && x.Type != ItemAreaType.TwoHandedMultiTarget);
                else if (filter[1] == (int)ItemTypeFilterType.Shield)
                    filtered.RemoveAll(x => x.Type != ItemAreaType.Shield);
                else if (filter[1] == (int)ItemTypeFilterType.Head)
                    filtered.RemoveAll(x => x.Type != ItemAreaType.Head);
                else if (filter[1] == (int)ItemTypeFilterType.Body)
                    filtered.RemoveAll(x => x.Type != ItemAreaType.Body);
                else if (filter[1] == (int)ItemTypeFilterType.Useable)
                    filtered.RemoveAll(x => x.Type != ItemAreaType.Useable);
                else if (filter[1] == (int)ItemTypeFilterType.Story)
                    filtered.RemoveAll(x => x.Type != ItemAreaType.Story);
                else if (filter[1] == (int)ItemTypeFilterType.NonBattle)
                    filtered.RemoveAll(x => x.Type != ItemAreaType.NonBattle);
            }

            // Filter element
            if (filter[2] != 0)
                filtered.RemoveAll(x => (int)x.Element != filter[2]);

            // Filter effect
            if (filter[3] != 0)
                filtered.RemoveAll(x => (int)x.Effect != filter[3] && (int)x.SecondaryEffect != filter[3]);

            return filtered;
        }

        /// <summary>
        /// Sets the item description field
        /// </summary>
        private void SetDescription()
        {
            txtGameName.Text = grdItems.CurrentRow == null ? "None" : (grdItems.CurrentRow.DataBoundItem as Item).Name;
            txtDescription.Text = grdItems.CurrentRow == null ? "" : (grdItems.CurrentRow.DataBoundItem as Item).Description;
        }

        /// <summary>
        /// Gets the selected object information
        /// </summary>
        /// <returns>Object information</returns>
        private string GetSelectedInfo()
        {
            if (!HasData || grdItems.CurrentRow == null)
                return "None";

            Item enemy = MainForm.RomData.Items.Find(x => x.ID == (grdItems.CurrentRow.DataBoundItem as ObjectID).ID);
            if (enemy == null)
                return "None";

            return MainForm.GetSelectedInformation(enemy);
        }
    }
}
