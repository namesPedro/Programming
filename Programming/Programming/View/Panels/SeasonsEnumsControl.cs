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
    /// Предоставляет элемент управления для работы с перечислением сезонов года.
    /// </summary>
    public partial class SeasonsEnumsControl : UserControl
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="SeasonsEnumsControl"/>.
        /// </summary>
        public SeasonsEnumsControl()
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
        /// Обрабатывает введенное значение сезона и выполняет соответствующее действие
        /// </summary>
        private void SeasonButton_Click(object sender, EventArgs e)
        {
            string season = SeasonValueTextBox.Text.ToLower();

            switch (season)
            {
                case "summer":
                    MessageBox.Show("Ура! Солнце!");
                    break;

                case "autumn":
                    this.BackColor = System.Drawing.ColorTranslator.FromHtml("#e29c45");
                    break;

                case "winter":
                    MessageBox.Show("Бррр! Холодно!");
                    break;

                case "spring":
                    this.BackColor = System.Drawing.ColorTranslator.FromHtml("#559c45");
                    break;
            }
        }
    }
}