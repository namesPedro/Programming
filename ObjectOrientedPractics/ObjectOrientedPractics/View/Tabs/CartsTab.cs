using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        private List<Item> _items = new List<Item>();
        private List<Customer> _customers = new List<Customer>();
        private Customer _currentCustomer;

        public OrdersTab OrdersTabRef { get; set; }

        public List<Item> Items
        {
            get => _items;
            set
            {
                _items = value ?? new List<Item>();
                RefreshItemsListBox();
            }
        }

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

            itemsListBox.DisplayMember = "Name";
            cartListBox.DisplayMember = "Name";
            customersComboBox.DisplayMember = "FullName";
        }

        private void RefreshItemsListBox()
        {
            Action refresh = () =>
            {
                itemsListBox.DataSource = null;
                itemsListBox.DisplayMember = "Name";
                itemsListBox.DataSource = _items;
            };

            if (itemsListBox.InvokeRequired)
                itemsListBox.Invoke(refresh);
            else
                refresh();
        }

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

        private void RefreshCartListBox()
        {
            Action refresh = () =>
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
                RefreshDiscountsCheckedList(); // ← обновляем скидки при смене корзины
            };

            if (cartListBox.InvokeRequired)
                cartListBox.Invoke(refresh);
            else
                refresh();
        }

        private void UpdateAmountLabel()
        {
            double amount = _currentCustomer?.Cart?.Amount ?? 0.0;
            SetLabel(amountLabel, amount.ToString("F2"));
        }

        private void SetLabel(Label label, string text)
        {
            if (label.InvokeRequired)
                label.Invoke(new Action(() => label.Text = text));
            else
                label.Text = text;
        }

        /// <summary>
        /// Обновляет список скидок в CheckedListBox и пересчитывает Discount/Total.
        /// </summary>
        private void RefreshDiscountsCheckedList()
        {
            Action refresh = () =>
            {
                discountsCheckedListBox.Items.Clear();
                if (_currentCustomer == null || _currentCustomer.Discounts == null)
                {
                    discountAmountLabel.Text = "0.00";
                    totalLabel.Text = "0.00";
                    return;
                }

                // 👇 УСТАНАВЛИВАЕМ DisplayMember ПЕРЕД ДОБАВЛЕНИЕМ ЭЛЕМЕНТОВ
                discountsCheckedListBox.DisplayMember = "Info";

                foreach (var discount in _currentCustomer.Discounts)
                {
                    discountsCheckedListBox.Items.Add(discount, true); // все галочки включены
                }

                RecalculateDiscountAndTotal();
            };

            if (discountsCheckedListBox.InvokeRequired)
                discountsCheckedListBox.Invoke(refresh);
            else
                refresh();
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
            if (_currentCustomer == null ||
                _currentCustomer.Cart?.Items?.Count == 0)
            {
                MessageBox.Show("Корзина пуста или покупатель не выбран",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var cartItems = _currentCustomer.Cart.Items.ToList();
                double appliedDiscount = 0;

                // Применяем выбранные скидки
                for (int i = 0; i < discountsCheckedListBox.Items.Count; i++)
                {
                    var discount = (IDiscount)discountsCheckedListBox.Items[i];
                    if (discountsCheckedListBox.GetItemChecked(i))
                    {
                        appliedDiscount += discount.Apply(cartItems);
                    }
                }

                // Обновляем ВСЕ скидки (начисление баллов/процентов)
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

                RefreshCartListBox(); // обновит и корзину, и скидки (Info изменится!)
                OrdersTabRef?.RefreshData();

                MessageBox.Show($"Заказ #{order.Id} создан!\nСкидка: {appliedDiscount:F2} руб.\nИтого: {order.Total:F2} руб.",
                    "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании заказа: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void discountsCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Проверяем, что дескриптор создан
            if (IsHandleCreated && !IsDisposed)
            {
                BeginInvoke(new Action(RecalculateDiscountAndTotal));
            }
            else
            {
                // Если дескриптор ещё не создан — отложим вызов на чуть позже,
                // например, через таймер или просто игнорируем (обычно это безопасно при инициализации)
                // В большинстве случаев пересчёт не нужен при первоначальной загрузке.
            }
        }

        public void RefreshData()
        {
            RefreshItemsListBox();
            RefreshCustomersComboBox();
            RefreshCartListBox();
        }
    }
}