using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        private List<Item> _items = new List<Item>();
        private List<Customer> _customers = new List<Customer>();
        private Customer _currentCustomer;

        public OrdersTab OrdersTabRef { get; set; }

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

        public CartsTab()
        {
            InitializeComponent();

            // Настройка привязки данных
            itemsListBox.DisplayMember = "Name";
            cartListBox.DisplayMember = "Name";
            customersComboBox.DisplayMember = "FullName";
        }

        /// <summary>
        /// Обновляет список товаров.
        /// </summary>
        private void RefreshItemsListBox()
        {
            Action refresh = () =>
            {
                itemsListBox.DataSource = null;
                itemsListBox.DisplayMember = "Name"; // ← Убедитесь, что DisplayMember установлен!
                itemsListBox.DataSource = _items;
            };

            if (itemsListBox.InvokeRequired)
                itemsListBox.Invoke(refresh);
            else
                refresh();
        }

        /// <summary>
        /// Обновляет список покупателей.
        /// </summary>
        private void RefreshCustomersComboBox()
        {
            if (customersComboBox.InvokeRequired)
            {
                customersComboBox.Invoke(new Action(() =>
                {
                    customersComboBox.DataSource = null;
                    customersComboBox.DataSource = _customers;

                    if (_customers.Count > 0)
                        customersComboBox.SelectedIndex = 0;
                }));
            }
            else
            {
                customersComboBox.DataSource = null;
                customersComboBox.DataSource = _customers;

                if (_customers.Count > 0)
                    customersComboBox.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Обновляет содержимое корзины текущего покупателя.
        /// </summary>
        private void RefreshCartListBox()
        {
            Action refresh = () =>
            {
                cartListBox.DataSource = null;
                cartListBox.DisplayMember = "Name"; // ← Ключевая строка!
                if (_currentCustomer?.Cart != null)
                {
                    cartListBox.DataSource = _currentCustomer.Cart.Items.ToList();
                }
                else
                {
                    cartListBox.DataSource = new List<Item>();
                }

                UpdateAmountLabel();
            };

            if (cartListBox.InvokeRequired)
                cartListBox.Invoke(refresh);
            else
                refresh();
        }

        /// <summary>
        /// Обновляет отображение общей стоимости.
        /// </summary>
        private void UpdateAmountLabel()
        {
            double amount = 0.0;
            if (_currentCustomer != null && _currentCustomer.Cart != null)
            {
                amount = _currentCustomer.Cart.Amount;
            }

            if (amountLabel.InvokeRequired)
            {
                amountLabel.Invoke(new Action(() =>
                {
                    amountLabel.Text = amount.ToString("F2");
                }));
            }
            else
            {
                amountLabel.Text = amount.ToString("F2");
            }
        }

        /// <summary>
        /// Обработчик изменения выбранного покупателя.
        /// </summary>
        private void customersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentCustomer = customersComboBox.SelectedItem as Customer;
            RefreshCartListBox();
        }

        /// <summary>
        /// Добавляет товар в корзину.
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
        /// Удаляет товар из корзины.
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
            if (_currentCustomer == null ||
                _currentCustomer.Cart == null ||
                _currentCustomer.Cart.Items.Count == 0)
            {
                MessageBox.Show("Корзина пуста или покупатель не выбран",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Order order;

                if (_currentCustomer.IsPriority)
                {
                    // Создаём PriorityOrder
                    var deliveryDate = DateTime.Today.AddDays(1); // завтра
                    var timeSlot = "9:00 – 11:00"; // по умолчанию
                    order = new PriorityOrder(_currentCustomer.Address, _currentCustomer.Cart, deliveryDate, timeSlot);
                }
                else
                {
                    // Обычный Order
                    order = new Order(_currentCustomer.Address, _currentCustomer.Cart);
                }

                _currentCustomer.Orders.Add(order);
                _currentCustomer.Cart.Clear();
                RefreshCartListBox();

                OrdersTabRef?.RefreshData();

                MessageBox.Show($"Заказ #{order.Id} успешно создан!",
                    "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании заказа: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Публичный метод для обновления данных
        /// </summary>
        public void RefreshData()
        {
            RefreshItemsListBox();
            RefreshCustomersComboBox();
            RefreshCartListBox();
        }
    }
}