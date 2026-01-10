using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Controls;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        private List<Customer> _customers = new List<Customer>();
        private Order _selectedOrder;
        private PriorityOrder _selectedPriorityOrder;

        public List<Customer> Customers
        {
            get => _customers;
            set
            {
                _customers = value ?? new List<Customer>();
                UpdateOrdersList();
            }
        }

        public OrdersTab()
        {
            InitializeComponent();

            statusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));

            addressControl1.Enabled = false;
            createdTextBox.ReadOnly = true;
            idTextBox.ReadOnly = true;

            orderItemsListBox.DataSource = null;
            orderItemsListBox.DisplayMember = "Name";

            var timeSlots = new[]
            {
                "9:00 – 11:00",
                "11:00 – 13:00",
                "13:00 – 15:00",
                "15:00 – 17:00",
                "17:00 – 19:00",
                "19:00 – 21:00"
            };

            deliveryTimeComboBox.Items.AddRange(timeSlots);

            dataGridView1.AutoGenerateColumns = false;

            idColumn.DataPropertyName = "Id";
            createdColumn.DataPropertyName = "Created";
            orderStatusColumn.DataPropertyName = "OrderStatus";
            customerFullNameColumn.DataPropertyName = "CustomerFullName";
            totalColumn.DataPropertyName = "Total";
        }

        private void UpdateOrdersList()
        {
            // ❗ НЕ МЕНЯЕМ СТРУКТУРУ DATAGRIDVIEW — оставляем как есть
            dataGridView1.DataSource = null;

            var allOrders = new List<OrderDisplayItem>();

            foreach (var customer in _customers)
            {
                if (customer?.Orders != null)
                {
                    foreach (var order in customer.Orders)
                    {
                        // Отображаем Amount в таблице (как раньше), НЕ Total
                        allOrders.Add(new OrderDisplayItem
                        {
                            Order = order,
                            Customer = customer,
                            Id = order.Id,
                            Created = order.Date.ToString("dd.MM.yyyy HH:mm"),
                            OrderStatus = order.Status.ToString(),
                            CustomerFullName = customer.FullName,
                            Total = order.Total.ToString("F2") // ← ДОБАВЬ ЭТО
                        });
                    }
                }
            }

            dataGridView1.DataSource = allOrders;

            if (_selectedOrder == null)
            {
                ClearOrderDetails();
            }
        }

        private void UpdateOrderDetails()
        {
            if (_selectedOrder == null) return;

            idTextBox.Text = _selectedOrder.Id.ToString();
            createdTextBox.Text = _selectedOrder.Date.ToString("dd.MM.yyyy HH:mm");

            statusComboBox.SelectedIndexChanged -= statusComboBox_SelectedIndexChanged;
            statusComboBox.SelectedItem = _selectedOrder.Status;
            statusComboBox.SelectedIndexChanged += statusComboBox_SelectedIndexChanged;

            addressControl1.Address = _selectedOrder.Address ?? new Address();

            // ✅ КЛЮЧЕВОЕ ИЗМЕНЕНИЕ:
            // Вместо Amount показываем Total (итоговую сумму с учётом скидки)
            totalAmountLabel.Text = _selectedOrder.Total.ToString("F2"); // ← было Amount, стало Total

            orderItemsListBox.DataSource = null;
            orderItemsListBox.DisplayMember = "Name";
            orderItemsListBox.DataSource = _selectedOrder.Items?.ToList() ?? new List<Item>();

            if (_selectedOrder is PriorityOrder priorityOrder)
            {
                _selectedPriorityOrder = priorityOrder;
                priorityPanel.Visible = true;
                deliveryDatePicker.Value = priorityOrder.DeliveryDate.Date;
                deliveryTimeComboBox.SelectedItem = priorityOrder.DeliveryTimeSlot;
            }
            else
            {
                _selectedPriorityOrder = null;
                priorityPanel.Visible = false;
            }
        }

        private void ClearOrderDetails()
        {
            idTextBox.Clear();
            createdTextBox.Clear();
            statusComboBox.SelectedIndex = -1;
            addressControl1.Address = new Address();
            totalAmountLabel.Text = "0.00"; // ← достаточно одного сброса
            orderItemsListBox.DataSource = null;
            _selectedPriorityOrder = null;
            priorityPanel.Visible = false;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var displayItem = dataGridView1.SelectedRows[0].DataBoundItem as OrderDisplayItem;
                _selectedOrder = displayItem?.Order;
                UpdateOrderDetails();
            }
            else
            {
                _selectedOrder = null;
                ClearOrderDetails();
            }
        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_selectedOrder != null && statusComboBox.SelectedItem != null)
            {
                _selectedOrder.Status = (OrderStatus)statusComboBox.SelectedItem;
                UpdateOrdersList();
                SelectOrderInGridView(_selectedOrder.Id);
            }
        }

        private void SelectOrderInGridView(int orderId)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var row = dataGridView1.Rows[i];
                var item = row.DataBoundItem as OrderDisplayItem;
                if (item?.Order.Id == orderId)
                {
                    dataGridView1.ClearSelection();
                    row.Selected = true;
                    break;
                }
            }
        }

        public void RefreshData()
        {
            UpdateOrdersList();
        }

        // 👇 ВСПОМОГАТЕЛЬНЫЙ КЛАСС — БЕЗ TOTAL
        private class OrderDisplayItem
        {
            public Order Order { get; set; }
            public Customer Customer { get; set; }
            public int Id { get; set; }
            public string Created { get; set; }
            public string OrderStatus { get; set; }
            public string CustomerFullName { get; set; }
            public string Total { get; set; } // ← ДОБАВЬ ЭТО
        }

        private void DeliveryDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (_selectedPriorityOrder != null)
            {
                _selectedPriorityOrder.DeliveryDate = deliveryDatePicker.Value.Date;
            }
        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_selectedPriorityOrder != null && deliveryTimeComboBox.SelectedItem != null)
            {
                _selectedPriorityOrder.DeliveryTimeSlot = deliveryTimeComboBox.SelectedItem.ToString();
            }
        }
    }
}