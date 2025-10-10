using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет покупателя в системе
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Уникальный идентификатор покупателя
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Полное имя покупателя
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Адрес доставки покупателя
        /// </summary>
        private string _address;

        /// <summary>
        /// Уникальный идентификатор покупателя
        /// </summary>
        public int Id => _id;

        /// <summary>
        /// Полное имя покупателя (не более 200 символов)
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается когда имя пустое или превышает 200 символов</exception>
        public string Fullname
        {
            get => _fullname;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Полное имя не может быть пустым");

                ValueValidator.AssertStringOnLength(value, 200, nameof(Fullname));
                _fullname = value;
            }
        }

        /// <summary>
        /// Адрес доставки покупателя (не более 500 символов)
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается когда адрес пустой или превышает 500 символов</exception>
        public string Address
        {
            get => _address;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Адрес не может быть пустым");

                ValueValidator.AssertStringOnLength(value, 500, nameof(Address));
                _address = value;
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса Customer
        /// </summary>
        /// <param name="fullname">Полное имя покупателя</param>
        /// <param name="address">Адрес доставки покупателя</param>
        public Customer(string fullname, string address)
        {
            _id = IdGenerator.GetNextId();
            Fullname = fullname;
            Address = address;
        }

        /// <summary>
        /// Обновляет информацию о покупателе
        /// </summary>
        /// <param name="fullname">Новое полное имя покупателя</param>
        /// <param name="address">Новый адрес доставки покупателя</param>
        public void Update(string fullname, string address)
        {
            Fullname = fullname;
            Address = address;
        }
    }
}
