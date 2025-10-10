using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        private List<Item> _items = new List<Item>();
        private Item _selectedItem;
        private bool _updatingFields = false;

        public ItemsTab()
        {
            InitializeComponent();
            InitializeListBox();
        }

        private void InitializeListBox()
        {
            itemsListBox.DisplayMember = "Name";
            itemsListBox.ValueMember = "Id";
            RefreshListBox();
        }

        private void RefreshListBox()
        {
            int selectedIndex = itemsListBox.SelectedIndex;

            itemsListBox.DataSource = null;
            itemsListBox.DataSource = _items;
            itemsListBox.DisplayMember = "Name";

            if (selectedIndex >= 0 && selectedIndex < itemsListBox.Items.Count)
            {
                itemsListBox.SelectedIndex = selectedIndex;
            }
        }

        private void UpdateSelectedItemFields()
        {
            _updatingFields = true; // Блокируем обновления чтобы избежать рекурсии

            if (_selectedItem != null)
            {
                selectedItemIdTextBox.Text = _selectedItem.Id.ToString();
                selectedItemNameTextBox.Text = _selectedItem.Name;
                selectedItemDescriptionTextBox.Text = _selectedItem.Info;
                selectedItemCostTextBox.Text = _selectedItem.Cost.ToString();
            }
            else
            {
                ClearInputFields();
            }

            _updatingFields = false;
        }

        private void ClearInputFields()
        {
            selectedItemIdTextBox.Text = string.Empty;
            selectedItemNameTextBox.Text = string.Empty;
            selectedItemDescriptionTextBox.Text = string.Empty;
            selectedItemCostTextBox.Text = string.Empty;
        }

        private void itemsAddButton_Click(object sender, EventArgs e)
        {
            var newItem = new Item("New Name", "New Description", 0.0);
            _items.Add(newItem);
            RefreshListBox();

            itemsListBox.SelectedItem = newItem;
        }

        private void itemsRemoveButton_Click(object sender, EventArgs e)
        {
            if (_selectedItem != null)
            {
                _items.Remove(_selectedItem);
                _selectedItem = null;
                RefreshListBox();
                ClearInputFields();
            }
        }

        private void itemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedItem = itemsListBox.SelectedItem as Item;
            UpdateSelectedItemFields();
        }

        private void selectedItemNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_selectedItem != null && !_updatingFields)
            {
                try
                {
                    _selectedItem.Update(
                        selectedItemNameTextBox.Text,
                        _selectedItem.Info,
                        _selectedItem.Cost
                    );
                    RefreshListBox();
                    selectedItemNameTextBox.BackColor = SystemColors.Window;
                }
                catch (ArgumentException ex)
                {
                    selectedItemNameTextBox.BackColor = Color.LightPink;
                }
            }
            else
            {
                selectedItemNameTextBox.BackColor = SystemColors.Window;
            }
        }

        private void selectedItemDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_selectedItem != null && !_updatingFields)
            {
                try
                {
                    _selectedItem.Update(
                        _selectedItem.Name,
                        selectedItemDescriptionTextBox.Text,
                        _selectedItem.Cost
                    );
                    selectedItemDescriptionTextBox.BackColor = SystemColors.Window;
                }
                catch (ArgumentException ex)
                {
                    selectedItemDescriptionTextBox.BackColor = Color.LightPink;
                }
            }
            else
            {
                selectedItemDescriptionTextBox.BackColor = SystemColors.Window;
            }
        }

        private void selectedItemCostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_selectedItem != null && !_updatingFields)
            {
                try
                {
                    if (double.TryParse(selectedItemCostTextBox.Text, out double cost))
                    {
                        if (Math.Abs(_selectedItem.Cost - cost) > 0.01)
                        {
                            _selectedItem.Update(_selectedItem.Name, _selectedItem.Info, cost);
                        }
                        selectedItemCostTextBox.BackColor = SystemColors.Window;
                    }
                    else
                    {
                        selectedItemCostTextBox.BackColor = Color.LightPink;
                    }
                }
                catch (ArgumentException ex)
                {
                    selectedItemCostTextBox.BackColor = Color.LightPink;
                }
            }
            else
            {
                selectedItemCostTextBox.BackColor = SystemColors.Window;
            }
        }
    }
}
