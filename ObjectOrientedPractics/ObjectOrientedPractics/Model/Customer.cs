using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using ObjectOrientedPractics.Model.Discounts;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет покупателя с уникальным идентификатором, полным именем, адресом и признаком приоритетности.
    /// </summary>
    [Serializable]
    public class Customer
    {
        private readonly int _id;
        private string _fullName;
        private Address _address;
        private Cart _cart;
        private List<Order> _orders;
        private bool _isPriority = false; // ← Добавлено: по умолчанию false
        private List<IDiscount> _discounts;

        /// <summary>
        /// Уникальный идентификатор покупателя.
        /// </summary>
        public int Id => _id;

        /// <summary>
        /// Полное имя покупателя (до 200 символов).
        /// </summary>
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
        public Address Address
        {
            get => _address;
            set
            {
                _address = value ?? throw new ArgumentNullException(nameof(Address));
            }
        }

        /// <summary>
        /// Корзина покупателя.
        /// </summary>
        public Cart Cart
        {
            get => _cart;
            set => _cart = value;
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
        /// Приоритетные покупатели создают заказы типа <see cref="PriorityOrder"/>.
        /// Значение по умолчанию — <c>false</c>.
        /// </summary>
        public bool IsPriority
        {
            get => _isPriority;
            set => _isPriority = value;
        }

        public List<IDiscount> Discounts
        {
            get => _discounts;
            private set => _discounts = value ?? new List<IDiscount>();
        }

        /// <summary>
        /// Создает новый экземпляр класса Customer.
        /// </summary>
        /// <param name="fullName">Полное имя покупателя.</param>
        /// <param name="address">Адрес доставки.</param>
        public Customer(string fullName, Address address)
        {
            _id = IdGenerator.GetNextId();
            FullName = fullName;
            Address = address;
            Cart = new Cart();
            Orders = new List<Order>();
            // _isPriority остаётся false по умолчанию

            _discounts = new List<IDiscount>
            {
                new PointsDiscount() // обязательная накопительная скидка
            };
        }

        /// <summary>
        /// Обновляет информацию о покупателе.
        /// </summary>
        /// <param name="fullName">Новое полное имя.</param>
        /// <param name="address">Новый адрес.</param>
        public void Update(string fullName, Address address)
        {
            FullName = fullName;
            Address = address;
        }

        public override string ToString()
        {
            return FullName;
        }
    }
}