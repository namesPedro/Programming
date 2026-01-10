using System;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics
{
    /// <summary>
    /// Главная форма приложения, объединяющая все модули магазина:
    /// управление товарами, покупателями, корзинами и заказами.
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly Store _store;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            _store = new Store();
            InitializeTestData();

            // Привязка данных к вкладкам
            itemsTab1.Items = _store.Items;
            customersTab1.Customers = _store.Customers;
            cartsTab1.Items = _store.Items;
            cartsTab1.Customers = _store.Customers;
            ordersTab1.Customers = _store.Customers;

            cartsTab1.OrdersTabRef = ordersTab1;

            // Подписка на события
            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
            itemsTab1.ItemsChanged += ItemsTab1_ItemsChanged;
        }

        /// <summary>
        /// Инициализирует тестовые данные для демонстрации функциональности приложения.
        /// </summary>
        private void InitializeTestData()
        {
            try
            {
                _store.Items.Add(new Item("Ноутбук", "Мощный ноутбук для работы", 50000, Category.Electronics));
                _store.Items.Add(new Item("Смартфон", "Современный смартфон", 30000, Category.Electronics));
                _store.Items.Add(new Item("Футболка", "Хлопковая футболка", 1500, Category.Clothing));
                _store.Items.Add(new Item("Книга", "Интересная книга", 800, Category.Books));
                _store.Items.Add(new Item("Кофе", "Свежеобжаренный кофе", 500, Category.Food));

                var address1 = new Address("123456", "Россия", "Москва", "Тверская", "1", "10");
                var address2 = new Address("654321", "Россия", "Санкт-Петербург", "Невский", "5", "25");

                _store.Customers.Add(new Customer("Иванов Иван", address1));
                _store.Customers.Add(new Customer("Петров Петр", address2));

                if (_store.Customers.Count > 0 && _store.Items.Count >= 2)
                {
                    _store.Customers[0].Cart.Items.Add(_store.Items[0]);
                    _store.Customers[0].Cart.Items.Add(_store.Items[1]);
                }

                if (_store.Customers.Count > 0 && _store.Customers[0].Cart.Items.Count > 0)
                {
                    var testOrder = new Order(_store.Customers[0].Address, _store.Customers[0].Cart);
                    _store.Customers[0].Orders.Add(testOrder);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ошибка при инициализации тестовых данных: {ex.Message}",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Обрабатывает событие переключения вкладок в <see cref="tabControl1"/>.
        /// Обновляет данные на вкладках "Корзины" и "Заказы" при их активации.
        /// </summary>
        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (tabControl1.SelectedIndex)
                {
                    case 2: // Вкладка "Корзины"
                        cartsTab1.RefreshData();
                        break;
                    case 3: // Вкладка "Заказы"
                        ordersTab1.RefreshData();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ошибка при обновлении данных: {ex.Message}",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Обрабатывает событие изменения списка товаров.
        /// Обновляет данные на всех зависимых вкладках.
        /// </summary>
        private void ItemsTab1_ItemsChanged(object sender, EventArgs e)
        {
            customersTab1.RefreshData();
            cartsTab1.RefreshData();
            ordersTab1.RefreshData();
        }
    }
}