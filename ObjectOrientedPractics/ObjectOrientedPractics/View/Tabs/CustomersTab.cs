using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Controls;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        private List<Customer> _customers = new List<Customer>();
        private Customer _selectedCustomer;
        private bool _updatingFields = false;

        public List<Customer> Customers
        {
            get => _customers;
            set
            {
                _customers = value ?? new List<Customer>();
                RefreshListBox();
            }
        }

        public CustomersTab()
        {
            InitializeComponent();
            InitializeListBox();

            // ПОДПИСЫВАЕМСЯ НА СОБЫТИЕ ИЗМЕНЕНИЯ АДРЕСА
            addressControl1.AddressChanged += AddressControl1_AddressChanged;
        }

        /// <summary>
        /// Обрабатывает изменение адреса в AddressControl.
        /// </summary>
        private void AddressControl1_AddressChanged(object sender, EventArgs e)
        {
            UpdateCustomerAddress();
        }

        /// <summary>
        /// Обновляет адрес покупателя.
        /// </summary>
        private void UpdateCustomerAddress()
        {
            if (_selectedCustomer != null && !_updatingFields)
            {
                try
                {
                    Console.WriteLine("=== SAVING ADDRESS CHANGES ===");

                    // Вариант 1: Используем метод Update (рекомендуется)
                    _selectedCustomer.Update(
                        _selectedCustomer.FullName,  // Имя не меняем
                        addressControl1.Address      // Новый адрес
                    );

                    // ИЛИ Вариант 2: Просто присваиваем свойство (еще проще)
                    // _selectedCustomer.Address = addressControl1.Address;

                    Console.WriteLine($"Address after update: {_selectedCustomer.Address}");
                    Console.WriteLine("=== ADDRESS SAVED ===");

                    RefreshListBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка адреса: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void InitializeListBox()
        {
            customersListBox.DisplayMember = "FullName";
            customersListBox.ValueMember = "Id";
            RefreshListBox();
        }

        private void RefreshListBox()
        {
            int selectedIndex = customersListBox.SelectedIndex;

            customersListBox.DataSource = null;
            customersListBox.DataSource = _customers;
            customersListBox.DisplayMember = "FullName";

            if (_customers.Count == 0)
            {
                _selectedCustomer = null;
                ClearInputFields();
                return;
            }

            if (selectedIndex >= 0 && selectedIndex < _customers.Count)
            {
                customersListBox.SelectedIndex = selectedIndex;
            }
        }

        private void UpdateSelectedCustomerFields()
        {
            _updatingFields = true;

            if (_selectedCustomer != null)
            {
                selectedCustomerIdTextBox.Text = _selectedCustomer.Id.ToString();
                selectedCustomerFullNameTextBox.Text = _selectedCustomer.FullName;
                addressControl1.Address = _selectedCustomer.Address;
            }
            else
            {
                ClearInputFields();
            }

            _updatingFields = false;
        }

        private void ClearInputFields()
        {
            selectedCustomerIdTextBox.Text = string.Empty;
            selectedCustomerFullNameTextBox.Text = string.Empty;
            addressControl1.Address = new Address();
        }

        private void customersAddButton_Click(object sender, EventArgs e)
        {
            var address = new Address();
            var newCustomer = new Customer("New Customer", address);
            _customers.Add(newCustomer);
            RefreshListBox();
            customersListBox.SelectedItem = newCustomer;
        }

        private void customersRemoveButton_Click(object sender, EventArgs e)
        {
            if (_selectedCustomer != null)
            {
                _customers.Remove(_selectedCustomer);
                _selectedCustomer = null;
                RefreshListBox();
                ClearInputFields();
            }
        }

        private void customersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedCustomer = customersListBox.SelectedItem as Customer;
            UpdateSelectedCustomerFields();
        }

        private void selectedCustomerFullNameTextBox_Leave(object sender, EventArgs e)
        {
            UpdateCustomerName();
        }

        /// <summary>
        /// Обновляет имя покупателя.
        /// </summary>
        private void UpdateCustomerName()
        {
            if (_selectedCustomer == null) return;

            try
            {
                // Просто присваиваем свойство - валидация произойдет в сеттере
                _selectedCustomer.FullName = selectedCustomerFullNameTextBox.Text;

                RefreshListBox();
                selectedCustomerFullNameTextBox.BackColor = SystemColors.Window;
            }
            catch
            {
                selectedCustomerFullNameTextBox.BackColor = Color.LightPink;
            }
        }
    }
}