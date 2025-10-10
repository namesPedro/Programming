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
            selectedItemNameTextBox.Text = string.Empty;
            selectedItemDescriptionTextBox.Text = string.Empty;
            selectedItemCostTextBox.Text = string.Empty;
        }

        private void itemsAddButton_Click(object sender, EventArgs e)
        {
            var newItem = new Item("New Name", "New Description", 0.0);
            _items.Add(newItem);
            RefreshListBox();

            // Выбираем новый товар в списке
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

        // Обработчик выбора товара в ListBox
        private void itemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedItem = itemsListBox.SelectedItem as Item;
            UpdateSelectedItemFields();
        }

        // Обработчики изменения текстовых полей
        private void selectedItemNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_selectedItem != null && !_updatingFields)
            {
                try
                {
                    _selectedItem.Name = selectedItemNameTextBox.Text;
                    RefreshListBox(); // Обновляем отображение имени в ListBox
                }
                catch (ArgumentException ex)
                {
                    // Можно показать подсветку ошибки или просто игнорировать невалидный ввод
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
                    _selectedItem.Info = selectedItemDescriptionTextBox.Text;
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
                        _selectedItem.Cost = cost;
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

        // Обработчик для проверки ввода стоимости (только числа)
        private void selectedItemCostTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешаем цифры, точку, запятую и управляющие символы
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // Разрешаем только одну точку или запятую
            if ((e.KeyChar == '.' || e.KeyChar == ',') &&
                ((sender as TextBox).Text.Contains('.') || (sender as TextBox).Text.Contains(',')))
            {
                e.Handled = true;
            }
        }

        // Восстанавливаем нормальный цвет когда поле получает фокус
        private void selectedItemNameTextBox_Enter(object sender, EventArgs e)
        {
            selectedItemNameTextBox.BackColor = SystemColors.Window;
        }

        private void selectedItemDescriptionTextBox_Enter(object sender, EventArgs e)
        {
            selectedItemDescriptionTextBox.BackColor = SystemColors.Window;
        }

        private void selectedItemCostTextBox_Enter(object sender, EventArgs e)
        {
            selectedItemCostTextBox.BackColor = SystemColors.Window;
        }
    }
}
