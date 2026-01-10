using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Вкладка для управления корзинами покупателей.
    /// Позволяет добавлять/удалять товары, применять скидки и создавать заказы.
    /// </summary>
    public partial class CartsTab : UserControl
    {
        private List<Item> _items = new List<Item>();
        private List<Customer> _customers = new List<Customer>();
        private Customer _currentCustomer;

        /// <summary>
        /// Ссылка на вкладку заказов для обновления после создания нового заказа.
        /// </summary>
        public OrdersTab OrdersTabRef { get; set; }

        /// <summary>
        /// Получает или задаёт список доступных товаров.
        /// При установке обновляется отображение списка товаров.
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
        /// Получает или задаёт список покупателей.
        /// При установке обновляется выпадающий список и выбирается первый покупатель.
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
        /// Инициализирует новый экземпляр класса <see cref="CartsTab"/>.
        /// Настраивает элементы управления.
        /// </summary>
        public CartsTab()
        {
            InitializeComponent();

            itemsListBox.DisplayMember = "Name";
            cartListBox.DisplayMember = "Name";
            customersComboBox.DisplayMember = "FullName";
        }

        /// <summary>
        /// Принудительно обновляет все данные на вкладке.
        /// </summary>
        public void RefreshData()
        {
            RefreshItemsListBox();
            RefreshCustomersComboBox();
            RefreshCartListBox();
        }

        private void RefreshItemsListBox()
        {
            itemsListBox.DataSource = null;
            itemsListBox.DisplayMember = "Name";
            itemsListBox.DataSource = _items;
        }

        private void RefreshCustomersComboBox()
        {
            customersComboBox.DataSource = null;
            customersComboBox.DataSource = _customers;
            if (_customers.Count > 0)
            {
                customersComboBox.SelectedIndex = 0;
            }
        }

        private void RefreshCartListBox()
        {
            cartListBox.DataSource = null;
            cartListBox.DisplayMember = "Name";

            if (_currentCustomer?.Cart != null)
            {
                cartListBox.DataSource = _currentCustomer.Cart.Items.ToList();
            }
            else
            {
                cartListBox.DataSource = new List<Item>();
            }

            UpdateAmountLabel();
            RefreshDiscountsCheckedList();
        }

        private void UpdateAmountLabel()
        {
            double amount = _currentCustomer?.Cart?.Amount ?? 0.0;
            amountLabel.Text = amount.ToString("F2");
        }

        private void RefreshDiscountsCheckedList()
        {
            discountsCheckedListBox.Items.Clear();

            if (_currentCustomer == null || _currentCustomer.Discounts == null)
            {
                discountAmountLabel.Text = "0.00";
                totalLabel.Text = "0.00";
                return;
            }

            discountsCheckedListBox.DisplayMember = "Info";

            foreach (var discount in _currentCustomer.Discounts)
            {
                discountsCheckedListBox.Items.Add(discount, true);
            }

            RecalculateDiscountAndTotal();
        }

        private void RecalculateDiscountAndTotal()
        {
            if (_currentCustomer?.Cart == null)
            {
                discountAmountLabel.Text = "0.00";
                totalLabel.Text = "0.00";
                return;
            }

            double totalDiscount = 0;
            var items = _currentCustomer.Cart.Items.ToList();

            for (int i = 0; i < discountsCheckedListBox.Items.Count; i++)
            {
                if (discountsCheckedListBox.GetItemChecked(i))
                {
                    var discount = (IDiscount)discountsCheckedListBox.Items[i];
                    totalDiscount += discount.Calculate(items);
                }
            }

            double amount = _currentCustomer.Cart.Amount;
            double total = Math.Max(0, amount - totalDiscount);

            discountAmountLabel.Text = totalDiscount.ToString("F2");
            totalLabel.Text = total.ToString("F2");
        }

        // ======================
        // Обработчики событий
        // ======================

        private void customersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentCustomer = customersComboBox.SelectedItem as Customer;
            RefreshCartListBox();
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null || itemsListBox.SelectedItem == null) return;

            var item = itemsListBox.SelectedItem as Item;
            if (item != null)
            {
                _currentCustomer.Cart.AddItem(item);
                RefreshCartListBox();
            }
        }

        private void removeItemButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null || cartListBox.SelectedItem == null) return;

            var item = cartListBox.SelectedItem as Item;
            if (item != null)
            {
                _currentCustomer.Cart.RemoveItem(item);
                RefreshCartListBox();
            }
        }

        private void clearCartButton_Click(object sender, EventArgs e)
        {
            _currentCustomer?.Cart.Clear();
            RefreshCartListBox();
        }

        private void createOrderButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null || _currentCustomer.Cart?.Items?.Count == 0)
            {
                MessageBox.Show(
                    "Корзина пуста или покупатель не выбран",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var cartItems = _currentCustomer.Cart.Items.ToList();
                double appliedDiscount = 0;

                for (int i = 0; i < discountsCheckedListBox.Items.Count; i++)
                {
                    var discount = (IDiscount)discountsCheckedListBox.Items[i];
                    if (discountsCheckedListBox.GetItemChecked(i))
                    {
                        appliedDiscount += discount.Apply(cartItems);
                    }
                }

                foreach (var discount in _currentCustomer.Discounts)
                {
                    discount.Update(cartItems);
                }

                Order order;
                if (_currentCustomer.IsPriority)
                {
                    var deliveryDate = DateTime.Today.AddDays(1);
                    var timeSlot = "9:00 – 11:00";
                    order = new PriorityOrder(_currentCustomer.Address, _currentCustomer.Cart, deliveryDate, timeSlot);
                }
                else
                {
                    order = new Order(_currentCustomer.Address, _currentCustomer.Cart);
                }

                order.DiscountAmount = appliedDiscount;
                _currentCustomer.Orders.Add(order);
                _currentCustomer.Cart.Clear();

                RefreshCartListBox();
                OrdersTabRef?.RefreshData();

                MessageBox.Show(
                    $"Заказ #{order.Id} создан!\nСкидка: {appliedDiscount:F2} руб.\nИтого: {order.Total:F2} руб.",
                    "Успех",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ошибка при создании заказа: {ex.Message}",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void discountsCheckedListBox_ItemCheck(object sender, EventArgs e)
        {
            if (IsHandleCreated && !IsDisposed)
            {
                BeginInvoke(new Action(RecalculateDiscountAndTotal));
            }
        }
    }
}