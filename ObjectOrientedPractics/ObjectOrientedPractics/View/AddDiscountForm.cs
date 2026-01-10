using System;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Форма для выбора категории товара при добавлении скидки.
    /// </summary>
    public partial class AddDiscountForm : Form
    {
        /// <summary>
        /// Получает выбранную пользователем категорию после закрытия формы с результатом <see cref="DialogResult.OK"/>.
        /// </summary>
        public Category SelectedCategory { get; private set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="AddDiscountForm"/>.
        /// Заполняет выпадающий список доступными категориями товаров.
        /// </summary>
        public AddDiscountForm()
        {
            InitializeComponent();

            ShowIcon = false;
            categoryComboBox.DataSource = Enum.GetValues(typeof(Category));
            categoryComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки "OK".
        /// Сохраняет выбранную категорию и закрывает форму с результатом <see cref="DialogResult.OK"/>.
        /// </summary>
        private void okButton_Click(object sender, EventArgs e)
        {
            SelectedCategory = (Category)categoryComboBox.SelectedItem;
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки "Отмена".
        /// Закрывает форму с результатом <see cref="DialogResult.Cancel"/>.
        /// </summary>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}