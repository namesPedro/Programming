using ObjectOrientedPractics.Services;
using System;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет покупателя с уникальным идентификатором, полным именем и адресом.
    /// </summary>
    public class Customer
    {
        private readonly int _id;
        private string _fullName;
        private Address _address;

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
            private set
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
            private set
            {
                _address = value ?? throw new ArgumentNullException(nameof(Address));
            }
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
        }

        /// <summary>
        /// Обновляет информацию о покупателе.
        /// </summary>
        /// <param name="fullName">Новое полное имя.</param>
        /// <param name="address">Новый адрес.</param>
        public void Update(string fullName, Address address)
        {
            FullName = fullName;

            // ВАЖНО: вместо присваивания нового объекта, обновляем поля существующего
            Address.Index = address.Index;
            Address.Country = address.Country;
            Address.City = address.City;
            Address.Street = address.Street;
            Address.Building = address.Building;
            Address.Apartment = address.Apartment;
        }

        public override string ToString()
        {
            return FullName;
        }
    }
}