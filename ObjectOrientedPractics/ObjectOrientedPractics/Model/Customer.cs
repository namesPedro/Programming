using System;
using System.Collections.Generic;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет покупателя с уникальным идентификатором, именем, адресом, корзиной и заказами.
    /// </summary>
    public class Customer
    {
        private readonly int _id;
        private string _fullName;
        private Address _address;
        private Cart _cart;
        private List<Order> _orders;
        private bool _isPriority;
        private List<IDiscount> _discounts;

        /// <summary>
        /// Уникальный идентификатор покупателя.
        /// </summary>
        public int Id => _id;

        /// <summary>
        /// Полное имя покупателя (до 200 символов).
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается, если имя превышает 200 символов.</exception>
        public string FullName
        {
            get => _fullName;
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(FullName));
                _fullName = value;
            }
        }

        /// <summary>
        /// Адрес доставки.
        /// </summary>
        /// <exception cref="ArgumentNullException">Выбрасывается, если адрес равен <see langword="null"/>.</exception>
        public Address Address
        {
            get => _address;
            set => _address = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Корзина покупателя.
        /// </summary>
        public Cart Cart
        {
            get => _cart;
            set => _cart = value ?? new Cart();
        }

        /// <summary>
        /// Список заказов покупателя.
        /// </summary>
        public List<Order> Orders
        {
            get => _orders;
            set => _orders = value ?? new List<Order>();
        }

        /// <summary>
        /// Указывает, является ли покупатель приоритетным.
        /// Значение по умолчанию — <c>false</c>.
        /// </summary>
        public bool IsPriority
        {
            get => _isPriority;
            set => _isPriority = value;
        }

        /// <summary>
        /// Список скидок, доступных покупателю.
        /// Всегда содержит как минимум одну накопительную скидку.
        /// </summary>
        public List<IDiscount> Discounts => _discounts;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullName">Полное имя покупателя.</param>
        /// <param name="address">Адрес доставки.</param>
        public Customer(string fullName, Address address)
        {
            _id = IdGenerator.GetNextId();
            FullName = fullName;
            Address = address;
            _cart = new Cart();
            _orders = new List<Order>();
            _isPriority = false;
            _discounts = new List<IDiscount> { new PointsDiscount() };
        }

        /// <summary>
        /// Обновляет имя и адрес покупателя.
        /// </summary>
        /// <param name="fullName">Новое полное имя.</param>
        /// <param name="address">Новый адрес.</param>
        public void Update(string fullName, Address address)
        {
            FullName = fullName;
            Address = address;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return FullName;
        }
    }
}