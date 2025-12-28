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

            // ПОДПИСЫВАЕМСЯ НА СОБЫТИЯ ПОТЕРИ ФОКУСА ДЛЯ КАЖДОГО ПОЛЯ
            postIndexTextBox.Leave += TextBox_Leave;
            countryTextBox.Leave += TextBox_Leave;
            cityTextBox.Leave += TextBox_Leave;
            streetTextBox.Leave += TextBox_Leave;
            buildingTextBox.Leave += TextBox_Leave;
            apartmentTextBox.Leave += TextBox_Leave;
        }

        /// <summary>
        /// Обрабатывает потерю фокуса любым TextBox.
        /// </summary>
        private void TextBox_Leave(object sender, EventArgs e)
        {
            // Вызываем событие при потере фокуса любым полем адреса
            AddressChanged?.Invoke(this, EventArgs.Empty);
        }

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

        private void UpdateAddress()
        {
            if (_address != null)
            {
                try
                {
                    _address.Index = postIndexTextBox.Text;
                    postIndexTextBox.BackColor = Color.White;
                }
                catch (ArgumentException)
                {
                    postIndexTextBox.BackColor = Color.LightPink;
                }

                try
                {
                    _address.Country = countryTextBox.Text;
                    countryTextBox.BackColor = Color.White;
                }
                catch (ArgumentException)
                {
                    countryTextBox.BackColor = Color.LightPink;
                }

                try
                {
                    _address.City = cityTextBox.Text;
                    cityTextBox.BackColor = Color.White;
                }
                catch (ArgumentException)
                {
                    cityTextBox.BackColor = Color.LightPink;
                }

                try
                {
                    _address.Street = streetTextBox.Text;
                    streetTextBox.BackColor = Color.White;
                }
                catch (ArgumentException)
                {
                    streetTextBox.BackColor = Color.LightPink;
                }

                try
                {
                    _address.Building = buildingTextBox.Text;
                    buildingTextBox.BackColor = Color.White;
                }
                catch (ArgumentException)
                {
                    buildingTextBox.BackColor = Color.LightPink;
                }

                try
                {
                    _address.Apartment = apartmentTextBox.Text;
                    apartmentTextBox.BackColor = Color.White;
                }
                catch (ArgumentException)
                {
                    apartmentTextBox.BackColor = Color.LightPink;
                }
            }
        }

        // Обработчики изменений текста
        private void postIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateAddress();
        }

        private void countryTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateAddress();
        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateAddress();
        }

        private void streetTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateAddress();
        }

        private void buildingTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateAddress();
        }

        private void apartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateAddress();
        }
    }
}