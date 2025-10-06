using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    /// <summary>
    /// Предоставляет элемент управления для просмотра перечислений и их значений.
    /// </summary>
    public partial class EnumerationsEnumsControl : UserControl
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="EnumerationsEnumsControl"/>.
        /// </summary>
        public EnumerationsEnumsControl()
        {
            InitializeComponent();
            LoadEnumTypes();
        }

        /// <summary>
        /// Загружает все типы перечислений из текущей сборки и отображает их в списке.
        /// </summary>
        private void LoadEnumTypes()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            var enumTypes = assembly.GetTypes()
                .Where(t => t.IsEnum)
                .ToList();

            EnumsListBox.DataSource = enumTypes;
            EnumsListBox.DisplayMember = "Name";

            if (EnumsListBox.Items.Count > 0)
            {
                EnumsListBox.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Обрабатывает изменение выбранного перечисления, загружая его значения в список значений.
        /// </summary>
        private void EnumsListBoxIndexChanged(object sender, EventArgs e)
        {
            if (EnumsListBox.SelectedItem is Type selectedEnum)
            {
                ValuesListBox.DataSource = Enum.GetValues(selectedEnum);
            }
        }

        /// <summary>
        /// Обрабатывает изменение выбранного значения перечисления, отображая его числовой эквивалент.
        /// </summary>
        private void ValuesListBoxIndexChanged(object sender, EventArgs e)
        {
            if (ValuesListBox.SelectedItem != null)
            {
                Type selectedEnum = EnumsListBox.SelectedItem as Type;

                if (selectedEnum != null)
                {
                    Array enumValues = Enum.GetValues(selectedEnum);
                    int selectedIndex = ValuesListBox.SelectedIndex;

                    if (selectedIndex >= 0 && selectedIndex < enumValues.Length)
                    {
                        int ordinalValue = (int)enumValues.GetValue(selectedIndex);
                        IntValueTextBox.Text = ordinalValue.ToString();
                    }
                }
            }
        }
    }
}