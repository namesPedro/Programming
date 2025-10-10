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
    public partial class CustomersTab : UserControl
    {
        private List<Customer> _customers = new List<Customer>();
        private Customer _selectedCustomer;
        private bool _updatingFields = false;

        public CustomersTab()
        {
            InitializeComponent();
            InitializeListBox();
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

            if (selectedIndex >= 0 && selectedIndex < customersListBox.Items.Count)
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
                selectedCustomerFullNameTextBox.Text = _selectedCustomer.Fullname;
                selectedCustomerAddressTextBox.Text = _selectedCustomer.Address;
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
            selectedCustomerAddressTextBox.Text = string.Empty;
        }

        private void customersAddButton_Click(object sender, EventArgs e)
        {
            var newCustomer = new Customer("New Customer", "New Address");
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