using System;
using System.Drawing;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Controls
{
    /// <summary>
    /// Пользовательский элемент управления для редактирования адреса.
    /// Поддерживает валидацию полей и генерирует событие при любом изменении.
    /// </summary>
    public partial class AddressControl : UserControl
    {
        private Address _address;

        /// <summary>
        /// Возникает при изменении любого поля адреса.
        /// </summary>
        public event EventHandler AddressChanged;

        /// <summary>
        /// Получает или задаёт текущий адрес.
        /// При установке поля управления автоматически обновляются.
        /// </summary>
        public Address Address
        {
            get => _address;
            set
            {
                _address = value ?? new Address();
                UpdateFields();
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="AddressControl"/>.
        /// Настраивает привязку событий потери фокуса для всех текстовых полей.
        /// </summary>
        public AddressControl()
        {
            InitializeComponent();
            _address = new Address();
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

        private void OnFieldLeave(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            string propertyName = GetPropertyName(textBox);

            try
            {
                switch (propertyName)
                {
                    case nameof(Address.Index):
                        _address.Index = textBox.Text;
                        break;
                    case nameof(Address.Country):
                        _address.Country = textBox.Text;
                        break;
                    case nameof(Address.City):
                        _address.City = textBox.Text;
                        break;
                    case nameof(Address.Street):
                        _address.Street = textBox.Text;
                        break;
                    case nameof(Address.Building):
                        _address.Building = textBox.Text;
                        break;
                    case nameof(Address.Apartment):
                        _address.Apartment = textBox.Text;
                        break;
                }

                textBox.BackColor = Color.White;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
            catch (ArgumentException)
            {
                textBox.BackColor = Color.LightPink;
            }
        }

        private string GetPropertyName(TextBox textBox)
        {
            if (textBox == postIndexTextBox) return nameof(Address.Index);
            if (textBox == countryTextBox) return nameof(Address.Country);
            if (textBox == cityTextBox) return nameof(Address.City);
            if (textBox == streetTextBox) return nameof(Address.Street);
            if (textBox == buildingTextBox) return nameof(Address.Building);
            if (textBox == apartmentTextBox) return nameof(Address.Apartment);
            throw new InvalidOperationException("Неизвестное текстовое поле.");
        }
    }
}