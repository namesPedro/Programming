using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Заказ покупателя.
    /// </summary>
    [Serializable]
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
        /// Дата создания заказа.
        /// </summary>
        public DateTime Date => _date;

        /// <summary>
        /// Адрес доставки.
        /// </summary>
        public Address Address
        {
            get => _address;
            set => _address = value;
        }

        /// <summary>
        /// Список товаров в заказе.
        /// </summary>
        public List<Item> Items
        {
            get => _items;
            set => _items = value ?? new List<Item>();
        }

        /// <summary>
        /// Общая стоимость заказа.
        /// </summary>
        public double Amount
        {
            get
            {
                if (Items == null || Items.Count == 0) return 0.0;
                return Items.Sum(i => i.Cost);
            }
        }

        /// <summary>
        /// Статус заказа.
        /// </summary>
        public OrderStatus Status
        {
            get => _status;
            set => _status = value;
        }

        public double DiscountAmount { get; set; }

        public double Total => Amount - DiscountAmount;

        public bool Equals(Order other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Order);
        }


        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        /// <summary>
        /// Создает новый заказ на основе корзины.
        /// </summary>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="cart">Корзина с товарами.</param>
        public Order(Address address, Cart cart)
        {
            _id = IdGenerator.GetNextId();
            _date = DateTime.Now;
            _status = OrderStatus.New;
            Address = address;

            // Копируем список товаров, чтобы изменения в корзине не влияли на оформленный заказ
            Items = new List<Item>(cart.Items);
        }

        /// <summary>
        /// Конструктор по умолчанию (для сериализации или пустых заказов).
        /// </summary>
        public Order()
        {
            _id = IdGenerator.GetNextId();
            _date = DateTime.Now;
            _status = OrderStatus.New;
            Items = new List<Item>();
            Address = new Address();
        }
    }
}