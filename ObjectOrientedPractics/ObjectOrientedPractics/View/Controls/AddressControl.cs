using System;
using System.Drawing;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        private Address _address;

        /// <summary>
        /// Событие, возникающее при изменении адреса.
        /// </summary>
        public event EventHandler AddressChanged;

        /// <summary>
        /// Текущий адрес.
        /// </summary>
        public Address Address
        {
            get => _address;
            set
            {
                _address = value;
                UpdateFields();
            }
        }

        public AddressControl()
        {
            InitializeComponent();
            _address = new Address();

            // Подписываемся на события потери фокуса для КАЖДОГО поля отдельно
            postIndexTextBox.Leave += PostIndexTextBox_Leave;
            countryTextBox.Leave += CountryTextBox_Leave;
            cityTextBox.Leave += CityTextBox_Leave;
            streetTextBox.Leave += StreetTextBox_Leave;
            buildingTextBox.Leave += BuildingTextBox_Leave;
            apartmentTextBox.Leave += ApartmentTextBox_Leave;
        }

        /// <summary>
        /// Обновляет поля из объекта адреса.
        /// </summary>
        private void UpdateFields()
        {
            if (_address != null)
            {
                postIndexTextBox.Text = _address.Index;
                countryTextBox.Text = _address.Country;
                cityTextBox.Text = _address.City;
                streetTextBox.Text = _address.Street;
                buildingTextBox.Text = _address.Building;
                apartmentTextBox.Text = _address.Apartment;
            }
        }

        /// <summary>
        /// Обновляет объект адреса из полей ввода.
        /// </summary>
        private void UpdateAddress()
        {
            if (_address != null)
            {
                // Обновляем индекс
                try
                {
                    _address.Index = postIndexTextBox.Text;
                    postIndexTextBox.BackColor = Color.White;
                }
                catch (ArgumentException)
                {
                    postIndexTextBox.BackColor = Color.LightPink;
                }

                // Обновляем страну
                try
                {
                    _address.Country = countryTextBox.Text;
                    countryTextBox.BackColor = Color.White;
                }
                catch (ArgumentException)
                {
                    countryTextBox.BackColor = Color.LightPink;
                }

                // Обновляем город
                try
                {
                    _address.City = cityTextBox.Text;
                    cityTextBox.BackColor = Color.White;
                }
                catch (ArgumentException)
                {
                    cityTextBox.BackColor = Color.LightPink;
                }

                // Обновляем улицу
                try
                {
                    _address.Street = streetTextBox.Text;
                    streetTextBox.BackColor = Color.White;
                }
                catch (ArgumentException)
                {
                    streetTextBox.BackColor = Color.LightPink;
                }

                // Обновляем здание
                try
                {
                    _address.Building = buildingTextBox.Text;
                    buildingTextBox.BackColor = Color.White;
                }
                catch (ArgumentException)
                {
                    buildingTextBox.BackColor = Color.LightPink;
                }

                // Обновляем квартиру
                try
                {
                    _address.Apartment = apartmentTextBox.Text;
                    apartmentTextBox.BackColor = Color.White;
                }
                catch (ArgumentException)
                {
                    apartmentTextBox.BackColor = Color.LightPink;
                }

                // Оповещаем об изменении адреса
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Обработчик выхода из поля индекса.
        /// </summary>
        private void PostIndexTextBox_Leave(object sender, EventArgs e)
        {
            UpdateAddress();
        }

        /// <summary>
        /// Обработчик выхода из поля страны.
        /// </summary>
        private void CountryTextBox_Leave(object sender, EventArgs e)
        {
            UpdateAddress();
        }

        /// <summary>
        /// Обработчик выхода из поля города.
        /// </summary>
        private void CityTextBox_Leave(object sender, EventArgs e)
        {
            UpdateAddress();
        }

        /// <summary>
        /// Обработчик выхода из поля улицы.
        /// </summary>
        private void StreetTextBox_Leave(object sender, EventArgs e)
        {
            UpdateAddress();
        }

        /// <summary>
        /// Обработчик выхода из поля здания.
        /// </summary>
        private void BuildingTextBox_Leave(object sender, EventArgs e)
        {
            UpdateAddress();
        }

        /// <summary>
        /// Обработчик выхода из поля квартиры.
        /// </summary>
        private void ApartmentTextBox_Leave(object sender, EventArgs e)
        {
            UpdateAddress();
        }
    }
}