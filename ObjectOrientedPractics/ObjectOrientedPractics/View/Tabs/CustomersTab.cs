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

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Представляет вкладку для управления списком покупателей.
    /// Обеспечивает функциональность добавления, удаления и редактирования покупателей.
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Текущий выбранный покупатель.
        /// </summary>
        private Customer _selectedCustomer;

        /// <summary>
        /// Флаг, указывающий на обновление полей ввода.
        /// Используется для предотвращения рекурсивных обновлений.
        /// </summary>
        private bool _updatingFields = false;

        /// <summary>
        /// Инициализирует новый экземпляр класса CustomersTab.
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
            InitializeListBox();
        }

        /// <summary>
        /// Инициализирует ListBox для отображения покупателей.
        /// </summary>
        private void InitializeListBox()
        {
            customersListBox.DisplayMember = "FullName";
            customersListBox.ValueMember = "Id";
            RefreshListBox();
        }

        /// <summary>
        /// Обновляет данные в ListBox.
        /// Сохраняет выбранный элемент после обновления.
        /// </summary>
        private void RefreshListBox()
        {
            int selectedIndex = customersListBox.SelectedIndex;

            customersListBox.DataSource = null;
            customersListBox.DataSource = _customers;
            customersListBox.DisplayMember = "FullName";

            if (selectedIndex >= 0 && selectedIndex < customersListBox.Items.Count)
            {
                customersListBox.SelectedIndex = selectedIndex;
            }
        }

        /// <summary>
        /// Обновляет поля ввода данными выбранного покупателя.
        /// </summary>
        private void UpdateSelectedCustomerFields()
        {
            _updatingFields = true;

            if (_selectedCustomer != null)
            {
                selectedCustomerIdTextBox.Text = _selectedCustomer.Id.ToString();
                selectedCustomerFullNameTextBox.Text = _selectedCustomer.Fullname;
                selectedCustomerAddressTextBox.Text = _selectedCustomer.Address;
            }
            else
            {
                ClearInputFields();
            }

            _updatingFields = false;
        }

        /// <summary>
        /// Очищает поля ввода.
        /// </summary>
        private void ClearInputFields()
        {
            selectedCustomerIdTextBox.Text = string.Empty;
            selectedCustomerFullNameTextBox.Text = string.Empty;
            selectedCustomerAddressTextBox.Text = string.Empty;
        }

        /// <summary>
        /// Обрабатывает событие нажатия кнопки добавления покупателя.
        /// </summary>
        private void customersAddButton_Click(object sender, EventArgs e)
        {
            var newCustomer = new Customer("New Customer", "New Address");
            _customers.Add(newCustomer);
            RefreshListBox();

            customersListBox.SelectedItem = newCustomer;
        }

        /// <summary>
        /// Обрабатывает событие нажатия кнопки удаления покупателя.
        /// </summary>
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

        /// <summary>
        /// Обрабатывает событие изменения выбранного элемента в ListBox.
        /// </summary>
        private void customersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedCustomer = customersListBox.SelectedItem as Customer;
            UpdateSelectedCustomerFields();
        }

        /// <summary>
        /// Обрабатывает событие изменения текста в поле полного имени покупателя.
        /// Обновляет данные покупателя и валидирует ввод.
        /// </summary>
        private void selectedCustomerFullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_selectedCustomer != null && !_updatingFields)
            {
                try
                {
                    _selectedCustomer.Update(
                        selectedCustomerFullNameTextBox.Text,
                        _selectedCustomer.Address
                    );
                    RefreshListBox();
                    selectedCustomerFullNameTextBox.BackColor = SystemColors.Window;
                }
                catch (ArgumentException ex)
                {
                    selectedCustomerFullNameTextBox.BackColor = Color.LightPink;
                }
            }
            else
            {
                selectedCustomerFullNameTextBox.BackColor = SystemColors.Window;
            }
        }

        /// <summary>
        /// Обрабатывает событие изменения текста в поле адреса покупателя.
        /// Обновляет данные покупателя и валидирует ввод.
        /// </summary>
        private void selectedCustomerAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_selectedCustomer != null && !_updatingFields)
            {
                try
                {
                    _selectedCustomer.Update(
                        _selectedCustomer.Fullname,
                        selectedCustomerAddressTextBox.Text
                    );
                    selectedCustomerAddressTextBox.BackColor = SystemColors.Window;
                }
                catch (ArgumentException ex)
                {
                    selectedCustomerAddressTextBox.BackColor = Color.LightPink;
                }
            }
            else
            {
                selectedCustomerAddressTextBox.BackColor = SystemColors.Window;
            }
        }
    }
}