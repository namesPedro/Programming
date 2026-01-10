using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет корзину товаров покупателя.
    /// </summary>
    public class Cart : ICloneable
    {
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
        /// Общая стоимость всех товаров в корзине.
        /// </summary>
        public double Amount => Items?.Sum(item => item.Cost) ?? 0.0;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Cart"/> с пустым списком товаров.
        /// </summary>
        public Cart()
        {
            Items = new List<Item>();
        }

        /// <summary>
        /// Добавляет товар в корзину.
        /// </summary>
        /// <param name="item">Товар для добавления.</param>
        /// <exception cref="ArgumentNullException">Выбрасывается, если <paramref name="item"/> равен <see langword="null"/>.</exception>
        public void AddItem(Item item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));
            Items.Add(item);
        }

        /// <summary>
        /// Удаляет первый найденный экземпляр товара из корзины.
        /// </summary>
        /// <param name="item">Товар для удаления.</param>
        /// <returns><see langword="true"/>, если товар был найден и удалён; иначе <see langword="false"/>.</returns>
        public bool RemoveItem(Item item)
        {
            return Items.Remove(item);
        }

        /// <summary>
        /// Очищает корзину от всех товаров.
        /// </summary>
        public void Clear()
        {
            Items.Clear();
        }

        /// <inheritdoc/>
        public object Clone()
        {
            var newCart = new Cart();
            newCart.Items = new List<Item>(Items);
            return newCart;
        }
    }
}