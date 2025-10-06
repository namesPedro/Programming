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
    /// Предоставляет элемент управления для работы с коллекцией прямоугольников с визуализацией и обработкой столкновений.
    /// </summary>
    public partial class RectanglesCollisionControl : UserControl
    {
        private List<Rectangle> _rectangles;
        private Rectangle _currentRectangle;
        private List<Panel> _rectanglePanels = new List<Panel>();

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="RectanglesCollisionControl"/>.
        /// Создает начальную коллекцию из 15 случайных прямоугольников.
        /// </summary>
        public RectanglesCollisionControl()
        {
            InitializeComponent();

            _rectangles = new List<Rectangle>();
            var rand = new Random();

            for (int i = 0; i < 15; i++)
                _rectangles.Add(RectangleFactory.Randomize());

            foreach (Rectangle rectangle in _rectangles)
            {
                Panel panel = new Panel
                {
                    Location = new Point((int)(rectangle.Center.X - rectangle.Width / 2), (int)(rectangle.Center.Y - rectangle.Length / 2)),
                    Width = (int)rectangle.Width,
                    Height = (int)rectangle.Length,
                    BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127),
                    BorderStyle = BorderStyle.FixedSingle
                };

                _rectanglePanels.Add(panel);
                CanvasPanel.Controls.Add(panel);
            }

            rectanglesListBox2.DataSource = _rectangles.Select((r, index) => new { Text = $"{index + 1}: (X={r.Center.X}; Y={r.Center.Y}; W={r.Width}; H={r.Length})", Value = r }).ToList();
            rectanglesListBox2.DisplayMember = "Text";
            rectanglesListBox2.ValueMember = "Value";
            rectanglesListBox2.SelectedIndex = 0;

            FindCollisions();
        }

        /// <summary>
        /// Обрабатывает изменение выбранного прямоугольника в списке.
        /// Обновляет отображаемые параметры прямоугольника.
        /// </summary>
        private void rectanglesListBox2IndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = rectanglesListBox2.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < _rectangles.Count)
            {
                _currentRectangle = _rectangles[selectedIndex];

                selectedRectangleHeightTextBox.Text = _currentRectangle.Length.ToString();
                selectedRectangleWidthTextBox.Text = _currentRectangle.Width.ToString();
                selectedRectangleXTextBox.Text = _currentRectangle.Center.X.ToString();
                selectedRectangleYTextBox.Text = _currentRectangle.Center.Y.ToString();
                selectedRectangleIdTextBox.Text = _currentRectangle.Id.ToString();
            }
            else
            {
                selectedRectangleHeightTextBox.Text = "";
                selectedRectangleWidthTextBox.Text = "";
                selectedRectangleXTextBox.Text = "";
                selectedRectangleYTextBox.Text = "";
                selectedRectangleIdTextBox.Text = "";
            }
        }

        /// <summary>
        /// Добавляет новый случайный прямоугольник в коллекцию.
        /// </summary>
        private void addRectangleButton_Click(object sender, EventArgs e)
        {
            var rectangle = RectangleFactory.Randomize();
            _rectangles.Add(rectangle);

            Panel panel = new Panel
            {
                Location = new Point((int)(rectangle.Center.X - rectangle.Width / 2), (int)(rectangle.Center.Y - rectangle.Length / 2)),
                Width = (int)rectangle.Width,
                Height = (int)rectangle.Length,
                BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127),
                BorderStyle = BorderStyle.FixedSingle
            };

            _rectanglePanels.Add(panel);
            CanvasPanel.Controls.Add(panel);

            FindCollisions();
            UpdateRectanglesList();
        }

        /// <summary>
        /// Удаляет выбранный прямоугольник из коллекции.
        /// </summary>
        private void removeRectangleButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = rectanglesListBox2.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < _rectangles.Count)
            {
                CanvasPanel.Controls.Remove(_rectanglePanels[selectedIndex]);
                _rectanglePanels.RemoveAt(selectedIndex);
                _rectangles.RemoveAt(selectedIndex);

                FindCollisions();
                UpdateRectanglesList();
            }
        }

        /// <summary>
        /// Применяет изменения параметров выбранного прямоугольника.
        /// </summary>
        private void ApplyRectangleChanges(object sender, EventArgs e)
        {
            if (_currentRectangle == null) return;

            try
            {
                int x = int.Parse(selectedRectangleXTextBox.Text);
                int y = int.Parse(selectedRectangleYTextBox.Text);
                double width = double.Parse(selectedRectangleWidthTextBox.Text);
                double height = double.Parse(selectedRectangleHeightTextBox.Text);

                _currentRectangle.Center = new Point2D(x, y);
                _currentRectangle.Width = width;
                _currentRectangle.Length = height;

                int rectIndex = _rectangles.IndexOf(_currentRectangle);

                if (rectIndex >= 0 && rectIndex < _rectanglePanels.Count)
                {
                    var panel = _rectanglePanels[rectIndex];

                    Validator.AssertOnPositiveValue(_currentRectangle.Center.X, nameof(_currentRectangle.Center.X));
                    Validator.AssertOnPositiveValue(_currentRectangle.Center.Y, nameof(_currentRectangle.Center.Y));
                    Validator.AssertOnPositiveValue(_currentRectangle.Width, nameof(_currentRectangle.Width));
                    Validator.AssertOnPositiveValue(_currentRectangle.Length, nameof(_currentRectangle.Length));

                    panel.Location = new Point((int)(_currentRectangle.Center.X - _currentRectangle.Width / 2),
                                            (int)(_currentRectangle.Center.Y - _currentRectangle.Length / 2));
                    panel.Width = (int)_currentRectangle.Width;
                    panel.Height = (int)_currentRectangle.Length;

                    FindCollisions();
                    UpdateRectanglesList();
                }
            }
            catch
            {
                MessageBox.Show("Неверные данные. Введите корректные целые значения.");
            }
        }

        /// <summary>
        /// Обновляет список прямоугольников в ListBox.
        /// </summary>
        private void UpdateRectanglesList()
        {
            int selectedIndex = rectanglesListBox2.SelectedIndex;
            rectanglesListBox2.DataSource = _rectangles.Select((r, index) => new {
                Text = $"{index + 1}: (X={r.Center.X}; Y={r.Center.Y}; W={r.Width}; H={r.Length})",
                Value = r
            }).ToList();
            rectanglesListBox2.SelectedIndex = selectedIndex;
        }

        /// <summary>
        /// Проверяет прямоугольники на столкновения и изменяет их цвет при пересечении.
        /// </summary>
        private void FindCollisions()
        {
            // Сброс цветов всех прямоугольников
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                _rectanglePanels[i].BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
            }

            // Проверка столкновений между всеми парами прямоугольников
            for (int i = 0; i < _rectangles.Count; i++)
            {
                for (int j = i + 1; j < _rectangles.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        _rectanglePanels[i].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
                        _rectanglePanels[j].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
                    }
                }
            }
        }
    }
}