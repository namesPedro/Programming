using System;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class AddDiscountForm : Form
    {
        public Category SelectedCategory { get; private set; }

        public AddDiscountForm()
        {
            InitializeComponent();

            // Убираем иконку формы
            this.ShowIcon = false;

            // Заполняем ComboBox категориями
            categoryComboBox.DataSource = Enum.GetValues(typeof(Category));
            categoryComboBox.SelectedIndex = 0;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            SelectedCategory = (Category)categoryComboBox.SelectedItem;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}