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

        /// <summary>
        /// Список покупателей.
        /// </summary>
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

            // Настройка DataGridView
            ConfigureDataGridView();

            // Заполнение ComboBox статусами
            statusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));

            // Отключение редактирования
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
        }

        private void ConfigureDataGridView()
        {
            // Убираем столбец заголовков строк
            dataGridView1.RowHeadersVisible = false;

            // Запрещаем пользователю добавлять/удалять строки
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = false;

            // Разрешаем только одиночный выбор строк
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Автоматическая генерация колонок отключена
            dataGridView1.AutoGenerateColumns = false;

            // Настраиваем ширину столбцов
            ConfigureColumnsWidth();
        }

        private void ConfigureColumnsWidth()
        {
            // ID - фиксированная ширина
            idColumn.Width = 60;
            idColumn.ReadOnly = true;
            idColumn.DataPropertyName = "Id";

            // Дата создания - фиксированная ширина
            createdColumn.Width = 120;
            createdColumn.ReadOnly = true;
            createdColumn.DataPropertyName = "Created";

            // Статус - средняя ширина
            orderStatusColumn.Width = 120;
            orderStatusColumn.ReadOnly = true;
            orderStatusColumn.DataPropertyName = "OrderStatus";

            // ФИО покупателя - занимает всё оставшееся место
            customerFullNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            customerFullNameColumn.ReadOnly = true;
            customerFullNameColumn.DataPropertyName = "CustomerFullName";
        }

        /// <summary>
        /// Обновление списка заказов в DataGridView
        /// </summary>
        private void UpdateOrdersList()
        {
            // Очищаем текущий источник данных
            dataGridView1.DataSource = null;

            // Собираем все заказы из всех покупателей
            var allOrders = new List<OrderDisplayItem>();

            foreach (var customer in _customers)
            {
                if (customer.Orders != null)
                {
                    foreach (var order in customer.Orders)
                    {
                        var displayItem = new OrderDisplayItem
                        {
                            Order = order,
                            Customer = customer,
                            Id = order.Id,
                            Created = order.Date.ToString("dd.MM.yyyy HH:mm"),
                            OrderStatus = order.Status.ToString(),
                            CustomerFullName = customer.FullName
                        };
                        allOrders.Add(displayItem);
                    }
                }
            }

            // Устанавливаем источник данных
            dataGridView1.DataSource = allOrders;

            // Если нет выбранного заказа, очищаем правую панель
            if (_selectedOrder == null)
            {
                ClearOrderDetails();
            }
        }

        /// <summary>
        /// Обновление деталей выбранного заказа
        /// </summary>
        private void UpdateOrderDetails()
        {
            if (_selectedOrder != null)
            {
                idTextBox.Text = _selectedOrder.Id.ToString();
                createdTextBox.Text = _selectedOrder.Date.ToString("dd.MM.yyyy HH:mm");

                statusComboBox.SelectedIndexChanged -= statusComboBox_SelectedIndexChanged;
                statusComboBox.SelectedItem = _selectedOrder.Status;
                statusComboBox.SelectedIndexChanged += statusComboBox_SelectedIndexChanged;

                addressControl1.Address = _selectedOrder.Address ?? new Address();
                amountLabel.Text = _selectedOrder.Amount.ToString("F2");

                orderItemsListBox.DataSource = null;
                orderItemsListBox.DisplayMember = "Name";
                orderItemsListBox.DataSource = _selectedOrder.Items?.ToList() ?? new List<Item>();

                // === НОВОЕ: обработка PriorityOrder ===
                if (_selectedOrder is PriorityOrder priorityOrder)
                {
                    Console.WriteLine("Это PriorityOrder!");
                    _selectedPriorityOrder = priorityOrder;
                    priorityPanel.Visible = true;

                    deliveryDatePicker.Value = priorityOrder.DeliveryDate.Date;
                    deliveryTimeComboBox.SelectedItem = priorityOrder.DeliveryTimeSlot;
                }
                else
                {
                    Console.WriteLine("Обычный Order");
                    _selectedPriorityOrder = null;
                    priorityPanel.Visible = false;
                }
            }
            else
            {
                ClearOrderDetails();
            }
        }

        /// <summary>
        /// Очистка деталей заказа
        /// </summary>
        private void ClearOrderDetails()
        {
            idTextBox.Text = string.Empty;
            createdTextBox.Text = string.Empty;
            statusComboBox.SelectedIndex = -1;
            addressControl1.Address = new Address();
            amountLabel.Text = "0.00";
            orderItemsListBox.DataSource = null;

            // Скрыть панель приоритета
            _selectedPriorityOrder = null;
            priorityPanel.Visible = false;
        }

        /// <summary>
        /// Обработчик выбора строки в DataGridView
        /// </summary>
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var displayItem = selectedRow.DataBoundItem as OrderDisplayItem;

                if (displayItem != null)
                {
                    _selectedOrder = displayItem.Order;
                    UpdateOrderDetails();
                }
            }
            else
            {
                _selectedOrder = null;
                ClearOrderDetails();
            }
        }

        /// <summary>
        /// Обработчик изменения статуса заказа
        /// </summary>
        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_selectedOrder != null && statusComboBox.SelectedItem != null)
            {
                // Обновляем статус заказа
                _selectedOrder.Status = (OrderStatus)statusComboBox.SelectedItem;

                // Обновляем отображение в DataGridView
                UpdateOrdersList();

                // Находим и выделяем обновленный заказ
                SelectOrderInGridView(_selectedOrder.Id);
            }
        }

        /// <summary>
        /// Выделение заказа в DataGridView по ID
        /// </summary>
        private void SelectOrderInGridView(int orderId)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var row = dataGridView1.Rows[i];
                var displayItem = row.DataBoundItem as OrderDisplayItem;

                if (displayItem != null && displayItem.Order.Id == orderId)
                {
                    dataGridView1.ClearSelection();
                    row.Selected = true;
                    break;
                }
            }
        }

        /// <summary>
        /// Публичный метод для обновления данных
        /// </summary>
        public void RefreshData()
        {
            UpdateOrdersList();
        }

        /// <summary>
        /// Вспомогательный класс для отображения в DataGridView
        /// </summary>
        private class OrderDisplayItem
        {
            public Order Order { get; set; }
            public Customer Customer { get; set; }
            public int Id { get; set; }
            public string Created { get; set; }
            public string OrderStatus { get; set; }
            public string CustomerFullName { get; set; }
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