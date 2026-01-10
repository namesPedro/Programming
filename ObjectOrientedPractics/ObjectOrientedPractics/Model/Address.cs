using System;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет адрес доставки.
    /// </summary>
    public class Address : ICloneable, IEquatable<Address>
    {
        private string _index;
        private string _country;
        private string _city;
        private string _street;
        private string _building;
        private string _apartment;

        /// <summary>
        /// Возникает при изменении любого поля адреса.
        /// </summary>
        public event EventHandler AddressChanged;

        protected virtual void OnAddressChanged()
        {
            AddressChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Почтовый индекс (ровно 6 цифр).
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается, если индекс не состоит из 6 цифр.</exception>
        public string Index
        {
            get => _index;
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length != 6 || !IsDigitsOnly(value))
                    throw new ArgumentException("Индекс должен состоять из 6 цифр.");
                if (_index != value)
                {
                    _index = value;
                    OnAddressChanged();
                }
            }
        }

        /// <summary>
        /// Страна или регион (не более 50 символов).
        /// </summary>
        public string Country
        {
            get => _country;
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(Country));
                if (_country != value)
                {
                    _country = value;
                    OnAddressChanged();
                }
            }
        }

        /// <summary>
        /// Город (не более 50 символов).
        /// </summary>
        public string City
        {
            get => _city;
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(City));
                if (_city != value)
                {
                    _city = value;
                    OnAddressChanged();
                }
            }
        }

        /// <summary>
        /// Улица (не более 100 символов).
        /// </summary>
        public string Street
        {
            get => _street;
            set
            {
                ValueValidator.AssertStringOnLength(value, 100, nameof(Street));
                if (_street != value)
                {
                    _street = value;
                    OnAddressChanged();
                }
            }
        }

        /// <summary>
        /// Номер дома (не более 10 символов).
        /// </summary>
        public string Building
        {
            get => _building;
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Building));
                if (_building != value)
                {
                    _building = value;
                    OnAddressChanged();
                }
            }
        }

        /// <summary>
        /// Номер квартиры или офиса (не более 10 символов).
        /// </summary>
        public string Apartment
        {
            get => _apartment;
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Apartment));
                if (_apartment != value)
                {
                    _apartment = value;
                    OnAddressChanged();
                }
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Address"/> с пустыми значениями.
        /// Индекс устанавливается в "000000".
        /// </summary>
        public Address()
        {
            _index = "000000";
            _country = string.Empty;
            _city = string.Empty;
            _street = string.Empty;
            _building = string.Empty;
            _apartment = string.Empty;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Address"/> с указанными значениями.
        /// </summary>
        public Address(string index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        private static bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        /// <inheritdoc/>
        public object Clone()
        {
            return new Address(Index, Country, City, Street, Building, Apartment);
        }

        /// <inheritdoc/>
        public bool Equals(Address other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            return Index == other.Index &&
                   Country == other.Country &&
                   City == other.City &&
                   Street == other.Street &&
                   Building == other.Building &&
                   Apartment == other.Apartment;
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            return Equals(obj as Address);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + (Index?.GetHashCode() ?? 0);
            hash = hash * 23 + (Country?.GetHashCode() ?? 0);
            hash = hash * 23 + (City?.GetHashCode() ?? 0);
            hash = hash * 23 + (Street?.GetHashCode() ?? 0);
            hash = hash * 23 + (Building?.GetHashCode() ?? 0);
            hash = hash * 23 + (Apartment?.GetHashCode() ?? 0);
            return hash;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"{Index}, {Country}, {City}, {Street}, {Building}, {Apartment}";
        }
    }
}