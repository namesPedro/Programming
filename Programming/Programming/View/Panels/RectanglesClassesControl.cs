using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    /// <summary>
    /// Предоставляет элемент управления для работы с коллекцией прямоугольников.
    /// </summary>
    public partial class RectanglesClassesControl : UserControl
    {
        private List<Rectangle> _rectangles;
        private Rectangle _currentRectangle;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="RectanglesClassesControl"/>.
        /// Создает коллекцию из 15 случайных прямоугольников.
        /// </summary>
        public RectanglesClassesControl()
        {
            InitializeComponent();

            var colors = new List<string>
            {
                "Red", "Green", "Blue", "Yellow", "Purple", "Orange", "Pink",
                "Brown", "Black", "White", "Cyan", "Magenta", "Gray", "Gold", "Lime"
            };

            _rectangles = new List<Rectangle>();
            var rand = new Random();

            for (int i = 0; i < 15; i++)
                _rectangles.Add(RectangleFactory.Randomize());

            RectanglesListBox.DataSource = _rectangles.Select((r, index) => new { Text = $"Rectangle {index + 1}", Value = r }).ToList();
            RectanglesListBox.DisplayMember = "Text";
            RectanglesListBox.ValueMember = "Value";
            RectanglesListBox.SelectedIndex = 0;
            _currentRectangle = _rectangles[0];
        }

        /// <summary>
        /// Обрабатывает изменение выбранного прямоугольника в списке.
        /// Обновляет отображаемые значения параметров прямоугольника.
        /// </summary>
        private void RectanglesListBoxIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];

            LengthTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color;

            CenterXTextBox.Text = _currentRectangle.Center.X.ToString();
            CenterYTextBox.Text = _currentRectangle.Center.Y.ToString();

            RectangleIdTextBox.Text = _currentRectangle.Id.ToString();
        }

        /// <summary>
        /// Обрабатывает изменение значения длины прямоугольника.
        /// При недопустимом значении подсвечивает поле ввода.
        /// </summary>
        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Length = Convert.ToDouble(LengthTextBox.Text);
                LengthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                LengthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// Обрабатывает изменение значения ширины прямоугольника.
        /// При недопустимом значении подсвечивает поле ввода.
        /// </summary>
        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = Convert.ToDouble(WidthTextBox.Text);
                WidthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// Обрабатывает изменение цвета прямоугольника.
        /// </summary>
        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = ColorTextBox.Text;
        }

        /// <summary>
        /// Находит и выделяет в списке прямоугольник с максимальной шириной.
        /// </summary>
        private void FindButton_Click(object sender, EventArgs e)
        {
            int maxWidthIndex = FindRectangleWithMaxWidth(_rectangles);
            RectanglesListBox.SelectedIndex = maxWidthIndex;
        }

        /// <summary>
        /// Находит индекс прямоугольника с максимальной шириной в коллекции.
        /// </summary>
        /// <param name="rectangles">Коллекция прямоугольников для поиска.</param>
        /// <returns>Индекс прямоугольника с максимальной шириной.</returns>
        private int FindRectangleWithMaxWidth(List<Rectangle> rectangles)
        {
            int maxIndex = 0;

            for (int i = 1; i < rectangles.Count; i++)
            {
                if (rectangles[i].Width > rectangles[maxIndex].Width)
                    maxIndex = i;
            }

            return maxIndex;
        }
    }
}