using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.View.Controls;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Вкладка для управления списком покупателей.
    /// Поддерживает добавление, удаление, редактирование данных покупателя,
    /// включая адрес, приоритетный статус и управление скидками.
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        private List<Customer> _customers = new List<Customer>();
        private Customer _selectedCustomer;
        private bool _updatingFields = false;

        /// <summary>
        /// Получает или задаёт список покупателей.
        /// При установке автоматически обновляется отображение.
        /// </summary>
        public List<Customer> Customers
        {
            get => _customers;
            set
            {
                _customers = value ?? new List<Customer>();
                RefreshListBox();
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="CustomersTab"/>.
        /// Настраивает элементы управления и подписывается на события.
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
            InitializeListBox();
            addressControl1.AddressChanged += AddressControl1_AddressChanged;
        }

        /// <summary>
        /// Принудительно обновляет отображаемые данные на основе текущего списка покупателей.
        /// </summary>
        public void RefreshData()
        {
            RefreshListBox();
            if (_selectedCustomer != null)
            {
                UpdateSelectedCustomerFields();
                RefreshDiscountsList();
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
                isPriorityCheckBox.Checked = _selectedCustomer.IsPriority;
            }
            else
            {
                ClearInputFields();
                isPriorityCheckBox.Checked = false;
            }

            _updatingFields = false;
        }

        private void ClearInputFields()
        {
            selectedCustomerIdTextBox.Text = string.Empty;
            selectedCustomerFullNameTextBox.Text = string.Empty;
            addressControl1.Address = new Address();
        }

        private void RefreshDiscountsList()
        {
            if (_selectedCustomer == null)
            {
                discountsListBox.DataSource = null;
                return;
            }

            discountsListBox.DataSource = null;
            discountsListBox.DataSource = _selectedCustomer.Discounts;
            discountsListBox.DisplayMember = "Info";
        }

        // ======================
        // Обработчики событий
        // ======================

        private void AddressControl1_AddressChanged(object sender, EventArgs e)
        {
            UpdateCustomerAddress();
        }

        private void UpdateCustomerAddress()
        {
            if (_selectedCustomer != null && !_updatingFields)
            {
                try
                {
                    _selectedCustomer.Update(_selectedCustomer.FullName, addressControl1.Address);
                    RefreshListBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Ошибка при обновлении адреса: {ex.Message}",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        private void customersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedCustomer = customersListBox.SelectedItem as Customer;
            UpdateSelectedCustomerFields();
            RefreshDiscountsList();
        }

        private void selectedCustomerFullNameTextBox_Leave(object sender, EventArgs e)
        {
            UpdateCustomerName();
        }

        private void UpdateCustomerName()
        {
            if (_selectedCustomer == null) return;

            try
            {
                _selectedCustomer.FullName = selectedCustomerFullNameTextBox.Text;
                RefreshListBox();
                selectedCustomerFullNameTextBox.BackColor = SystemColors.Window;
            }
            catch
            {
                selectedCustomerFullNameTextBox.BackColor = Color.LightPink;
            }
        }

        private void isPriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (_selectedCustomer != null)
            {
                _selectedCustomer.IsPriority = isPriorityCheckBox.Checked;
            }
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

        private void addDiscountButton_Click(object sender, EventArgs e)
        {
            if (_selectedCustomer == null) return;

            var form = new AddDiscountForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var category = form.SelectedCategory;
                _selectedCustomer.Discounts.Add(new PercentDiscount(category));
                RefreshDiscountsList();
            }
        }

        private void removeDiscountButton_Click(object sender, EventArgs e)
        {
            if (_selectedCustomer == null) return;

            var selected = discountsListBox.SelectedItem as IDiscount;
            if (selected == null) return;

            // Первая скидка — накопительная (PointsDiscount), её нельзя удалить
            if (_selectedCustomer.Discounts.IndexOf(selected) == 0)
            {
                MessageBox.Show("Нельзя удалить накопительную скидку.");
                return;
            }

            _selectedCustomer.Discounts.Remove(selected);
            RefreshDiscountsList();
        }
    }
}