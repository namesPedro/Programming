using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Корзина товаров покупателя.
    /// </summary>
    [Serializable]
    public class Cart
    {
        /// <summary>
        /// Список товаров в корзине.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Список товаров в корзине.
        /// </summary>
        public List<Item> Items
        {
            get => _items;
            set => _items = value ?? new List<Item>();
        }

        /// <summary>
        /// Общая стоимость товаров в корзине.
        /// </summary>
        public double Amount
        {
            get
            {
                if (_items == null || _items.Count == 0)
                    return 0.0;

                return _items.Sum(item => item.Cost);
            }
        }

        /// <summary>
        /// Создает новый экземпляр корзины.
        /// </summary>
        public Cart()
        {
            Items = new List<Item>();
        }

        /// <summary>
        /// Добавляет товар в корзину.
        /// </summary>
        /// <param name="item">Товар для добавления.</param>
        public void AddItem(Item item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            Items.Add(item);
        }

        /// <summary>
        /// Удаляет товар из корзины.
        /// </summary>
        /// <param name="item">Товар для удаления.</param>
        /// <returns>True если товар был удален, иначе false.</returns>
        public bool RemoveItem(Item item)
        {
            return Items.Remove(item);
        }

        /// <summary>
        /// Очищает корзину.
        /// </summary>
        public void Clear()
        {
            Items.Clear();
        }
    }
}