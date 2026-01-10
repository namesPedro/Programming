using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Представляет вкладку для управления списком товаров.
    /// Обеспечивает функциональность добавления, удаления, редактирования,
    /// поиска и сортировки товаров с использованием делегатов.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        private List<Item> _allItems = new List<Item>();
        private List<Item> _displayedItems = new List<Item>();
        private Item _selectedItem;

        public List<Item> Items
        {
            get => _allItems;
            set
            {
                _allItems = value ?? new List<Item>();
                ApplyFilterAndSort();
            }
        }

        public ItemsTab()
        {
            InitializeComponent();

            // Настройка ComboBox категорий
            selectedItemCategoryComboBox.DataSource = Enum.GetValues(typeof(Category));

            // Настройка сортировки
            sortComboBox.Items.AddRange(new[]
            {
                "По имени",
                "По возрастанию стоимости",
                "По убыванию стоимости"
            });
            sortComboBox.SelectedIndex = 0; // По умолчанию — по имени

            // Инициализация отображения
            itemsListBox.DisplayMember = "Name";
            ApplyFilterAndSort();
        }

        /// <summary>
        /// Применяет фильтрацию и сортировку к списку товаров.
        /// </summary>
        private void ApplyFilterAndSort()
        {
            // 1. Фильтрация по поиску
            string searchTerm = searchTextBox.Text.Trim().ToLower();
            var filtered = DataTools.Filter(_allItems, item =>
                string.IsNullOrEmpty(searchTerm) ||
                item.Name.ToLower().Contains(searchTerm));

            // 2. Сортировка
            var sorted = SortItems(filtered);

            // 3. Обновление отображаемого списка
            _displayedItems = sorted;

            // Сохраняем текущий выбранный индекс
            int selectedIndex = itemsListBox.SelectedIndex;

            // Обновляем ListBox
            itemsListBox.DataSource = null;
            itemsListBox.DisplayMember = "Name";
            itemsListBox.DataSource = _displayedItems;

            // Восстанавливаем выделение
            if (_selectedItem != null)
            {
                int newIndex = _displayedItems.IndexOf(_selectedItem);
                if (newIndex >= 0)
                    itemsListBox.SelectedIndex = newIndex;
                else
                    _selectedItem = null; // элемент больше не виден
            }
        }

        private List<Item> SortItems(List<Item> items)
        {
            switch (sortComboBox.SelectedIndex)
            {
                case 0:
                    return DataTools.Sort(items, (a, b) => string.Compare(a.Name, b.Name, StringComparison.OrdinalIgnoreCase));
                case 1:
                    return DataTools.Sort(items, (a, b) => a.Cost.CompareTo(b.Cost));
                case 2:
                    return DataTools.Sort(items, (a, b) => b.Cost.CompareTo(a.Cost));
                default:
                    return items;
            }
        }

        private void UpdateSelectedItemFields()
        {
            if (_selectedItem != null)
            {
                selectedItemIdTextBox.Text = _selectedItem.Id.ToString();
                selectedItemNameTextBox.Text = _selectedItem.Name;
                selectedItemDescriptionTextBox.Text = _selectedItem.Info;
                selectedItemCostTextBox.Text = _selectedItem.Cost.ToString();
                selectedItemCategoryComboBox.SelectedItem = _selectedItem.Category;
            }
            else
            {
                ClearInputFields();
            }
        }

        private void ClearInputFields()
        {
            selectedItemIdTextBox.Clear();
            selectedItemNameTextBox.Clear();
            selectedItemDescriptionTextBox.Clear();
            selectedItemCostTextBox.Clear();
            selectedItemCategoryComboBox.SelectedIndex = -1;
        }

        // === Обработчики редактирования (БЕЗ пересборки списка!) ===

        private void selectedItemNameTextBox_Leave(object sender, EventArgs e)
        {
            if (_selectedItem == null) return;

            try
            {
                _selectedItem.Update(selectedItemNameTextBox.Text, _selectedItem.Info, _selectedItem.Cost);
                // Обновляем только отображение, не трогая фильтрацию
                RefreshListBoxDisplay();
                selectedItemNameTextBox.BackColor = SystemColors.Window;
            }
            catch
            {
                selectedItemNameTextBox.BackColor = Color.LightPink;
            }
        }

        private void selectedItemDescriptionTextBox_Leave(object sender, EventArgs e)
        {
            if (_selectedItem == null) return;

            try
            {
                _selectedItem.Update(_selectedItem.Name, selectedItemDescriptionTextBox.Text, _selectedItem.Cost);
                selectedItemDescriptionTextBox.BackColor = SystemColors.Window;
            }
            catch
            {
                selectedItemDescriptionTextBox.BackColor = Color.LightPink;
            }
        }

        private void selectedItemCostTextBox_Leave(object sender, EventArgs e)
        {
            if (_selectedItem == null) return;

            try
            {
                if (double.TryParse(selectedItemCostTextBox.Text, out double cost))
                {
                    _selectedItem.Update(_selectedItem.Name, _selectedItem.Info, cost);
                    RefreshListBoxDisplay();
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

        private void selectedItemCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_selectedItem != null && selectedItemCategoryComboBox.SelectedItem != null)
            {
                _selectedItem.Category = (Category)selectedItemCategoryComboBox.SelectedItem;
            }
        }

        // === Управление списком ===

        private void itemsAddButton_Click(object sender, EventArgs e)
        {
            var newItem = new Item("New Name", "New Description", 0.0, Category.Electronics);
            _allItems.Add(newItem);
            ApplyFilterAndSort();
            itemsListBox.SelectedItem = newItem;
        }

        private void itemsRemoveButton_Click(object sender, EventArgs e)
        {
            if (_selectedItem != null)
            {
                _allItems.Remove(_selectedItem);
                _selectedItem = null;
                ApplyFilterAndSort();
                ClearInputFields();
            }
        }

        // === Обработка выбора в ListBox ===

        private void itemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedItem = itemsListBox.SelectedItem as Item;
            UpdateSelectedItemFields();
        }

        // === Обработка UI-элементов ===

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilterAndSort();
        }

        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilterAndSort();
        }

        // === Вспомогательные методы ===

        /// <summary>
        /// Обновляет отображение ListBox без изменения фильтрации/сортировки.
        /// </summary>
        private void RefreshListBoxDisplay()
        {
            // Просто перепривязываем тот же список — обновляется отображение Name
            itemsListBox.DataSource = null;
            itemsListBox.DisplayMember = "Name";
            itemsListBox.DataSource = _displayedItems;

            // Восстанавливаем выделение
            if (_selectedItem != null)
            {
                int index = _displayedItems.IndexOf(_selectedItem);
                if (index >= 0)
                    itemsListBox.SelectedIndex = index;
            }
        }

        public void RefreshData()
        {
            ApplyFilterAndSort();
        }
    }
}