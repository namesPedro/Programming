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
    public partial class CartsTab : UserControl
    {
        private List<Item> _items = new List<Item>();
        private List<Customer> _customers = new List<Customer>();
        private Customer _currentCustomer;

        /// <summary>
        /// Список товаров для отображения.
        /// </summary>
        public List<Item> Items
        {
            get => _items;
            set
            {
                _items = value ?? new List<Item>();
                RefreshItemsListBox();
            }
        }

        /// <summary>
        /// Список покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get => _customers;
            set
            {
                _customers = value ?? new List<Customer>();
                RefreshCustomersComboBox();
            }
        }

        /// <summary>
        /// Общая стоимость корзины.
        /// </summary>
        private double CartAmount
        {
            get
            {
                if (_currentCustomer == null || _currentCustomer.Cart == null)
                    return 0.0;
                return _currentCustomer.Cart.Amount;
            }
        }

        public CartsTab()
        {
            InitializeComponent();
            InitializeComponentData();
        }

        private void InitializeComponentData()
        {
            // Настройка ListBox для товаров
            itemsListBox.DisplayMember = "Name";
            itemsListBox.ValueMember = "Id";

            // Настройка ComboBox для покупателей
            customersComboBox.DisplayMember = "FullName";
            customersComboBox.ValueMember = "Id";
            customersComboBox.SelectedIndexChanged += CustomersComboBox_SelectedIndexChanged;

            // Настройка ListBox для корзины
            cartListBox.DisplayMember = "Name";
            cartListBox.ValueMember = "Id";

            // Обновление отображения суммы
            UpdateAmountLabel();
        }

        /// <summary>
        /// Обновляет список товаров.
        /// </summary>
        private void RefreshItemsListBox()
        {
            itemsListBox.DataSource = null;
            itemsListBox.DataSource = _items;
        }

        /// <summary>
        /// Обновляет список покупателей.
        /// </summary>
        private void RefreshCustomersComboBox()
        {
            customersComboBox.DataSource = null;
            customersComboBox.DataSource = _customers;

            if (_customers.Count > 0)
                customersComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Обновляет содержимое корзины текущего покупателя.
        /// </summary>
        private void RefreshCartListBox()
        {
            cartListBox.DataSource = null;

            if (_currentCustomer != null && _currentCustomer.Cart != null)
            {
                cartListBox.DataSource = _currentCustomer.Cart.Items.ToList();
            }

            UpdateAmountLabel();
        }

        /// <summary>
        /// Обновляет отображение общей стоимости.
        /// </summary>
        private void UpdateAmountLabel()
        {
            amountLabel.Text = CartAmount.ToString("F2");
        }

        /// <summary>
        /// Обработчик изменения выбранного покупателя.
        /// </summary>
        private void CustomersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentCustomer = customersComboBox.SelectedItem as Customer;
            RefreshCartListBox();
        }

        /// <summary>
        /// Добавляет выбранный товар в корзину.
        /// </summary>
        private void addToCartButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null || itemsListBox.SelectedItem == null)
                return;

            var selectedItem = itemsListBox.SelectedItem as Item;
            if (selectedItem != null)
            {
                _currentCustomer.Cart.AddItem(selectedItem);
                RefreshCartListBox();
            }
        }

        /// <summary>
        /// Удаляет выбранный товар из корзины.
        /// </summary>
        private void removeItemButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null || cartListBox.SelectedItem == null)
                return;

            var selectedItem = cartListBox.SelectedItem as Item;
            if (selectedItem != null)
            {
                _currentCustomer.Cart.RemoveItem(selectedItem);
                RefreshCartListBox();
            }
        }

        /// <summary>
        /// Очищает корзину.
        /// </summary>
        private void clearCartButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer != null)
            {
                _currentCustomer.Cart.Clear();
                RefreshCartListBox();
            }
        }

        /// <summary>
        /// Создает заказ из текущей корзины.
        /// </summary>
        private void createOrderButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null || _currentCustomer.Cart == null || _currentCustomer.Cart.Items.Count == 0)
            {
                MessageBox.Show("Корзина пуста или покупатель не выбран", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Создаем новый заказ
                var order = new Order(_currentCustomer.Address, _currentCustomer.Cart);

                // Добавляем заказ в список заказов покупателя
                _currentCustomer.Orders.Add(order);

                // Очищаем корзину
                _currentCustomer.Cart.Clear();

                // Обновляем отображение
                RefreshCartListBox();

                MessageBox.Show($"Заказ #{order.Id} успешно создан!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании заказа: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Обновляет данные на вкладке.
        /// </summary>
        public void RefreshData()
        {
            RefreshItemsListBox();
            RefreshCustomersComboBox();
            RefreshCartListBox();
        }
    }
}