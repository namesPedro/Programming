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
    /// <summary>
    /// Представляет вкладку для управления списком товаров.
    /// Обеспечивает функциональность добавления, удаления и редактирования товаров.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Текущий выбранный товар.
        /// </summary>
        private Item _selectedItem;

        /// <summary>
        /// Флаг, указывающий на обновление полей ввода.
        /// Используется для предотвращения рекурсивных обновлений.
        /// </summary>
        private bool _updatingFields = false;

        /// <summary>
        /// Инициализирует новый экземпляр класса ItemsTab.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
            InitializeListBox();
        }

        /// <summary>
        /// Инициализирует ListBox для отображения товаров.
        /// </summary>
        private void InitializeListBox()
        {
            itemsListBox.DisplayMember = "Name";
            itemsListBox.ValueMember = "Id";
            RefreshListBox();
        }

        /// <summary>
        /// Обновляет данные в ListBox.
        /// Сохраняет выбранный элемент после обновления.
        /// </summary>
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

        /// <summary>
        /// Обновляет поля ввода данными выбранного товара.
        /// </summary>
        private void UpdateSelectedItemFields()
        {
            _updatingFields = true;

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

        /// <summary>
        /// Очищает поля ввода.
        /// </summary>
        private void ClearInputFields()
        {
            selectedItemIdTextBox.Text = string.Empty;
            selectedItemNameTextBox.Text = string.Empty;
            selectedItemDescriptionTextBox.Text = string.Empty;
            selectedItemCostTextBox.Text = string.Empty;
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки добавления товара.
        /// </summary>
        private void itemsAddButton_Click(object sender, EventArgs e)
        {
            var newItem = new Item("New Name", "New Description", 0.0);
            _items.Add(newItem);
            RefreshListBox();

            itemsListBox.SelectedItem = newItem;
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки удаления товара.
        /// </summary>
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

        /// <summary>
        /// Обрабатывает изменение выбранного элемента в ListBox.
        /// </summary>
        private void itemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedItem = itemsListBox.SelectedItem as Item;
            UpdateSelectedItemFields();
        }

        /// <summary>
        /// Обрабатывает изменение текста в поле названия товара.
        /// Обновляет данные товара и валидирует ввод.
        /// </summary>
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
                catch (ArgumentException)
                {
                    selectedItemNameTextBox.BackColor = Color.LightPink;
                }
            }
            else
            {
                selectedItemNameTextBox.BackColor = SystemColors.Window;
            }
        }

        /// <summary>
        /// Обрабатывает изменение текста в поле описания товара.
        /// Обновляет данные товара и валидирует ввод.
        /// </summary>
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
                catch (ArgumentException)
                {
                    selectedItemDescriptionTextBox.BackColor = Color.LightPink;
                }
            }
            else
            {
                selectedItemDescriptionTextBox.BackColor = SystemColors.Window;
            }
        }

        /// <summary>
        /// Обрабатывает изменение текста в поле стоимости товара.
        /// Обновляет данные товара и валидирует ввод.
        /// </summary>
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
                catch (ArgumentException)
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