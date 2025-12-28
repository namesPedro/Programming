using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет магазин с товарами и покупателями.
    /// </summary>
    public class Store
    {
        private List<Item> _items;
        private List<Customer> _customers;

        /// <summary>
        /// Список товаров магазина.
        /// </summary>
        public List<Item> Items
        {
            get => _items;
            set => _items = value;
        }

        /// <summary>
        /// Список покупателей магазина.
        /// </summary>
        public List<Customer> Customers
        {
            get => _customers;
            set => _customers = value;
        }

        /// <summary>
        /// Создает новый экземпляр класса Store с пустыми списками.
        /// </summary>
        public Store()
        {
            Items = new List<Item>();
            Customers = new List<Customer>();
        }
    }
}