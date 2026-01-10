using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет магазин, содержащий товары и покупателей.
    /// </summary>
    public class Store
    {
        /// <summary>
        /// Список товаров в магазине.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Список зарегистрированных покупателей.
        /// </summary>
        public List<Customer> Customers { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Store"/> с пустыми списками товаров и покупателей.
        /// </summary>
        public Store()
        {
            Items = new List<Item>();
            Customers = new List<Customer>();
        }
    }
}