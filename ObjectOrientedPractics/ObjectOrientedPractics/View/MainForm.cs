using System;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        private Store _store;

        public MainForm()
        {
            InitializeComponent();

            _store = new Store();

            // Инициализация тестовых данных
            InitializeTestData();

            // Передача данных во ВСЕ 4 вкладки
            itemsTab1.Items = _store.Items;
            customersTab1.Customers = _store.Customers;
            cartsTab1.Items = _store.Items;
            cartsTab1.Customers = _store.Customers;
            ordersTab1.Customers = _store.Customers;

            cartsTab1.OrdersTabRef = ordersTab1;

            // Подписка на события переключения вкладок
            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
        }

        private void InitializeTestData()
        {
            try
            {
                // Добавляем тестовые товары
                _store.Items.Add(new Item("Ноутбук", "Мощный ноутбук для работы", 50000, Category.Electronics));
                _store.Items.Add(new Item("Смартфон", "Современный смартфон", 30000, Category.Electronics));
                _store.Items.Add(new Item("Футболка", "Хлопковая футболка", 1500, Category.Clothing));
                _store.Items.Add(new Item("Книга", "Интересная книга", 800, Category.Books));
                _store.Items.Add(new Item("Кофе", "Свежеобжаренный кофе", 500, Category.Food));

                // Добавляем тестовых покупателей
                var address1 = new Address("123456", "Россия", "Москва", "Тверская", "1", "10");
                var address2 = new Address("654321", "Россия", "Санкт-Петербург", "Невский", "5", "25");

                _store.Customers.Add(new Customer("Иванов Иван", address1));
                _store.Customers.Add(new Customer("Петров Петр", address2));

                // Добавляем тестовые товары в корзину первого покупателя
                if (_store.Customers.Count > 0 && _store.Items.Count >= 2)
                {
                    _store.Customers[0].Cart.Items.Add(_store.Items[0]); // Ноутбук
                    _store.Customers[0].Cart.Items.Add(_store.Items[1]); // Смартфон
                }

                // Создаем тестовый заказ
                if (_store.Customers.Count > 0 && _store.Customers[0].Cart.Items.Count > 0)
                {
                    var testOrder = new Order(_store.Customers[0].Address, _store.Customers[0].Cart);
                    _store.Customers[0].Orders.Add(testOrder);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при инициализации тестовых данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Обновляем данные при переключении на вкладки
                if (tabControl1.SelectedIndex == 2) // Carts (третья вкладка, индексы: 0=Items, 1=Customers, 2=Carts, 3=Orders)
                {
                    cartsTab1.RefreshData();
                }
                else if (tabControl1.SelectedIndex == 3) // Orders (четвертая вкладка)
                {
                    ordersTab1.RefreshData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}