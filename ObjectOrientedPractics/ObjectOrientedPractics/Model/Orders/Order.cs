using System;
using System.Collections.Generic;
using System.Linq;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет заказ покупателя.
    /// </summary>
    public class Order : IEquatable<Order>
    {
        private readonly int _id;
        private readonly DateTime _date;
        private Address _address;
        private List<Item> _items;
        private OrderStatus _status;

        /// <summary>
        /// Уникальный идентификатор заказа.
        /// </summary>
        public int Id => _id;

        /// <summary>
        /// Дата и время создания заказа.
        /// </summary>
        public DateTime Date => _date;

        /// <summary>
        /// Адрес доставки.
        /// </summary>
        public Address Address
        {
            get => _address;
            set => _address = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Список товаров в заказе (копия на момент оформления).
        /// </summary>
        public List<Item> Items
        {
            get => _items;
            private set => _items = value ?? new List<Item>();
        }

        /// <summary>
        /// Общая стоимость товаров в заказе (до применения скидок).
        /// </summary>
        public double Amount => Items?.Sum(item => item.Cost) ?? 0.0;

        /// <summary>
        /// Размер применённой скидки в рублях.
        /// </summary>
        public double DiscountAmount { get; set; }

        /// <summary>
        /// Итоговая стоимость заказа с учётом скидки.
        /// </summary>
        public double Total => Math.Max(0, Amount - DiscountAmount);

        /// <summary>
        /// Текущий статус заказа.
        /// </summary>
        public OrderStatus Status
        {
            get => _status;
            set => _status = value;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Order"/> на основе корзины покупателя.
        /// Товары клонируются, чтобы избежать влияния последующих изменений в корзине.
        /// </summary>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="cart">Корзина с товарами.</param>
        /// <exception cref="ArgumentNullException">Выбрасывается, если <paramref name="address"/> или <paramref name="cart"/> равны <see langword="null"/>.</exception>
        public Order(Address address, Cart cart)
        {
            _id = IdGenerator.GetNextId();
            _date = DateTime.Now;
            _status = OrderStatus.New;
            Address = address;

            // Реализация клонирования ломает подсчет Id
            // Items = new List<Item>(cart.Items.Select(item => (Item)item.Clone()));
            Items = new List<Item>(cart.Items);
        }

        public bool Equals(Order other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            return Id == other.Id;
        }

        public override bool Equals(object obj) => Equals(obj as Order);

        public override int GetHashCode() => Id.GetHashCode();

        public override string ToString() => $"Заказ #{Id} от {Date:dd.MM.yyyy HH:mm}";
    }
}