using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Вкладка для управления списком товаров.
    /// Поддерживает добавление, удаление, редактирование, поиск и сортировку товаров.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        private List<Item> _allItems = new List<Item>();
        private List<Item> _displayedItems = new List<Item>();
        private Item _selectedItem;

        /// <summary>
        /// Возникает при изменении списка товаров (добавление, удаление или редактирование).
        /// </summary>
        public event EventHandler ItemsChanged;

        /// <summary>
        /// Получает или задаёт полный список товаров.
        /// При установке автоматически применяются текущие фильтр и сортировка.
        /// </summary>
        public List<Item> Items
        {
            get => _allItems;
            set
            {
                _allItems = value ?? new List<Item>();
                ApplyFilterAndSort();
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="ItemsTab"/>.
        /// Настраивает элементы управления и привязку данных.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();

            selectedItemCategoryComboBox.DataSource = Enum.GetValues(typeof(Category));

            sortComboBox.Items.AddRange(new[]
            {
                "По имени",
                "По возрастанию стоимости",
                "По убыванию стоимости"
            });
            sortComboBox.SelectedIndex = 0;

            itemsListBox.DisplayMember = "Name";
            ApplyFilterAndSort();
        }

        /// <summary>
        /// Принудительно обновляет отображаемые данные на основе текущего списка товаров.
        /// </summary>
        public void RefreshData()
        {
            ApplyFilterAndSort();
        }

        private void ApplyFilterAndSort()
        {
            string searchTerm = searchTextBox.Text.Trim().ToLower();
            var filtered = DataTools.Filter(_allItems, item =>
                string.IsNullOrEmpty(searchTerm) ||
                item.Name.ToLower().Contains(searchTerm));

            var sorted = SortItems(filtered);
            _displayedItems = sorted;

            // Сохраняем выделение
            Item previouslySelected = _selectedItem;

            itemsListBox.DataSource = null;
            itemsListBox.DisplayMember = "Name";
            itemsListBox.DataSource = _displayedItems;

            if (previouslySelected != null)
            {
                int newIndex = _displayedItems.IndexOf(previouslySelected);
                if (newIndex >= 0)
                {
                    itemsListBox.SelectedIndex = newIndex;
                }
                else
                {
                    _selectedItem = null;
                    ClearInputFields();
                }
            }
        }

        private List<Item> SortItems(List<Item> items)
        {
            switch (sortComboBox.SelectedIndex)
            {
                case 0:
                    return DataTools.Sort(items, (a, b) =>
                        string.Compare(a.Name, b.Name, StringComparison.OrdinalIgnoreCase));
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

        private void RefreshListBoxDisplay()
        {
            // Перепривязка для обновления отображения Name
            itemsListBox.DataSource = null;
            itemsListBox.DisplayMember = "Name";
            itemsListBox.DataSource = _displayedItems;

            if (_selectedItem != null)
            {
                int index = _displayedItems.IndexOf(_selectedItem);
                if (index >= 0)
                {
                    itemsListBox.SelectedIndex = index;
                }
            }
        }

        // ======================
        // Обработчики событий
        // ======================

        private void itemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedItem = itemsListBox.SelectedItem as Item;
            UpdateSelectedItemFields();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilterAndSort();
        }

        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilterAndSort();
        }

        private void itemsAddButton_Click(object sender, EventArgs e)
        {
            var newItem = new Item("New Name", "New Description", 0.0, Category.Electronics);
            _allItems.Add(newItem);
            ApplyFilterAndSort();
            itemsListBox.SelectedItem = newItem;
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        private void itemsRemoveButton_Click(object sender, EventArgs e)
        {
            if (_selectedItem != null)
            {
                _allItems.Remove(_selectedItem);
                _selectedItem = null;
                ApplyFilterAndSort();
                ClearInputFields();
                ItemsChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        private void selectedItemNameTextBox_Leave(object sender, EventArgs e)
        {
            if (_selectedItem == null) return;

            try
            {
                _selectedItem.Update(selectedItemNameTextBox.Text, _selectedItem.Info, _selectedItem.Cost);
                RefreshListBoxDisplay();
                selectedItemNameTextBox.BackColor = SystemColors.Window;
                ItemsChanged?.Invoke(this, EventArgs.Empty);
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
                ItemsChanged?.Invoke(this, EventArgs.Empty);
            }
            catch
            {
                selectedItemDescriptionTextBox.BackColor = Color.LightPink;
            }
        }

        private void selectedItemCostTextBox_Leave(object sender, EventArgs e)
        {
            if (_selectedItem == null) return;

            if (double.TryParse(selectedItemCostTextBox.Text, out double cost))
            {
                try
                {
                    _selectedItem.Update(_selectedItem.Name, _selectedItem.Info, cost);
                    RefreshListBoxDisplay();
                    selectedItemCostTextBox.BackColor = SystemColors.Window;
                    ItemsChanged?.Invoke(this, EventArgs.Empty);
                }
                catch (ArgumentException)
                {
                    selectedItemCostTextBox.BackColor = Color.LightPink;
                }
            }
            else
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
    }
}