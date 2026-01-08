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

            // Отключение редактирования адреса и других полей
            addressControl1.Enabled = false;
            createdTextBox.ReadOnly = true;
            idTextBox.ReadOnly = true;
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

            // Дата создания - фиксированная ширина
            createdColumn.Width = 120;
            createdColumn.ReadOnly = true;

            // Статус - средняя ширина
            orderStatusColumn.Width = 120;
            orderStatusColumn.ReadOnly = true;

            // ФИО покупателя - занимает всё оставшееся место
            customerFullNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            customerFullNameColumn.ReadOnly = true;
        }

        // 1. Обновление списка заказов в DataGridView
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

        // 2. Получение покупателя по заказу
        private Customer GetCustomerByOrder(Order order)
        {
            return _customers.FirstOrDefault(c =>
                c.Orders != null && c.Orders.Contains(order));
        }

        // 3. Обновление деталей выбранного заказа
        private void UpdateOrderDetails()
        {
            if (_selectedOrder != null)
            {
                // Основная информация
                idTextBox.Text = _selectedOrder.Id.ToString();
                createdTextBox.Text = _selectedOrder.Date.ToString("dd.MM.yyyy HH:mm");

                // Статус
                statusComboBox.SelectedItem = _selectedOrder.Status;

                // Адрес
                addressControl1.Address = _selectedOrder.Address;

                // Сумма заказа
                amountLabel.Text = _selectedOrder.Amount.ToString("F2");

                // Товары в заказе
                orderItemsListBox.DataSource = null;
                if (_selectedOrder.Items != null && _selectedOrder.Items.Count > 0)
                {
                    orderItemsListBox.DataSource = _selectedOrder.Items;
                    orderItemsListBox.DisplayMember = "Name";
                }
            }
        }

        // 4. Очистка деталей заказа
        private void ClearOrderDetails()
        {
            idTextBox.Text = string.Empty;
            createdTextBox.Text = string.Empty;
            statusComboBox.SelectedIndex = -1;
            addressControl1.Address = new Address();
            amountLabel.Text = "0.00";
            orderItemsListBox.DataSource = null;
        }

        // 5. Обработчик выбора строки в DataGridView
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

        // 6. Обработчик изменения статуса заказа
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

        // 7. Выделение заказа в DataGridView по ID
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

        // 8. Публичный метод для обновления данных
        public void RefreshData()
        {
            UpdateOrdersList();
        }

        // 9. Вспомогательный класс для отображения в DataGridView
        private class OrderDisplayItem
        {
            public Order Order { get; set; }
            public Customer Customer { get; set; }
            public int Id { get; set; }
            public string Created { get; set; }
            public string OrderStatus { get; set; }
            public string CustomerFullName { get; set; }
        }
    }
}