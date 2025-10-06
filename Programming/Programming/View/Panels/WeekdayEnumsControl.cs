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
    /// Предоставляет элемент управления для работы с перечислением дней недели.
    /// </summary>
    public partial class WeekdayEnumsControl : UserControl
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="WeekdayEnumsControl"/>.
        /// </summary>
        public WeekdayEnumsControl()
        {
            InitializeComponent();
            LoadEnumTypes();
        }

        /// <summary>
        /// Загружает доступные типы перечислений из текущей сборки.
        /// </summary>
        private void LoadEnumTypes()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            var enumTypes = assembly.GetTypes()
                .Where(t => t.IsEnum)
                .ToList();
        }

        /// <summary>
        /// Обрабатывает введенное значение, проверяя его соответствие дням недели.
        /// При успешном распознавании выводит порядковый номер дня,
        /// в противном случае сообщает об ошибке.
        /// </summary>
        private void ParseButton_Click(object sender, EventArgs e)
        {
            string input = ParsValueTextBox.Text;

            if (Enum.TryParse(input, true, out Weekday parsedDay))
            {
                int dayNumber = (int)parsedDay + 1;
                WeekParsedLabel.Text = $"Это день недели({input} = {dayNumber})";
            }
            else
            {
                WeekParsedLabel.Text = "Нет такого дня недели";
            }
        }
    }
}