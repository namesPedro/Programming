using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming
{
    public partial class MainForm : Form
    {

        private List<Rectangle> _rectangles;
        private Rectangle _currentRectangle;

        private List<Film> _films;
        private Film _currentFilm;

        public MainForm()
        {
            InitializeComponent();
            LoadEnumTypes();

            WeekParsedLabel.Text = string.Empty;

            var rand = new Random();

            var colors = new List<string>
            {
                "Red", "Green", "Blue", "Yellow", "Purple", "Orange", "Pink",
                "Brown", "Black", "White", "Cyan", "Magenta", "Gray", "Gold", "Lime"
            };

            _rectangles = new List<Rectangle>();

            for (int i = 0; i < colors.Count; i++)
            {
                double width = rand.Next(10, 100);
                double height = rand.Next(10, 100);
                string color = colors[i];

                var center = new Point2D(rand.Next(0, 500), rand.Next(0, 500));

                var rectangle = new Rectangle(width, height, color, center);
                _rectangles.Add(rectangle);
            }

            RectanglesListBox.DataSource = _rectangles.Select((r, index) => new { Text = $"Rectangle {index + 1}", Value = r }).ToList();

            RectanglesListBox.DisplayMember = "Text";
            RectanglesListBox.ValueMember = "Value";

            RectanglesListBox.SelectedIndex = 0;

            _currentRectangle = _rectangles[0];

            _films = new List<Film>
            {
                new Film("Inception", 148, 2010, "Sci-Fi", 8.8),
                new Film("The Godfather", 175, 1972, "Crime", 9.2),
                new Film("Interstellar", 169, 2014, "Sci-Fi", 8.6),
                new Film("Shrek", 90, 2001, "Comedy", 7.8),
                new Film("Titanic", 195, 1997, "Romance", 7.9),
            };

            FilmsListBox.DataSource = _films.Select((r, index) => new { Text = $"Film {index + 1}", Value = r }).ToList();

            FilmsListBox.DisplayMember = "Text";
            FilmsListBox.ValueMember = "Value";

            FilmsListBox.SelectedIndex = 0;

            _currentFilm = _films[0];
        }

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

        private void EnumsListBoxIndexChanged(object sender, EventArgs e)
        {
            if (EnumsListBox.SelectedItem is Type selectedEnum) ValuesListBox.DataSource = Enum.GetValues(selectedEnum);
        }

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

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = ColorTextBox.Text;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            int maxWidthIndex = FindRectangleWithMaxWidth(_rectangles);

            RectanglesListBox.SelectedIndex = maxWidthIndex;
        }

        private int FindRectangleWithMaxWidth(List<Rectangle> rectangles)
        {
            int maxIndex = 0;

            for (int i = 1; i < rectangles.Count; i++)
            {
                if (rectangles[i].Width > rectangles[maxIndex].Width) maxIndex = i;
            }

            return maxIndex;
        }

        private void FilmsListBoxIndexChanged(object sender, EventArgs e)
        {
            _currentFilm = _films[FilmsListBox.SelectedIndex];

            TitleTextBox.Text = _currentFilm.Title;
            DurationTextBox.Text = _currentFilm.DurationMinutes.ToString();
            ReleaseTextBox.Text = _currentFilm.ReleaseYear.ToString();
            GenreTextBox.Text = _currentFilm.Genre;
            RatingTextBox.Text = _currentFilm.Rating.ToString("0.0");
            
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int duration = int.Parse(DurationTextBox.Text);

                _currentFilm.DurationMinutes = duration;

                DurationTextBox.BackColor = System.Drawing.Color.White;
            }

            catch
            {
                DurationTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int year = int.Parse(ReleaseTextBox.Text);

                _currentFilm.ReleaseYear = year;

                ReleaseTextBox.BackColor = System.Drawing.Color.White;
            }

            catch
            {
                ReleaseTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double rating = double.Parse(RatingTextBox.Text);

                _currentFilm.Rating = rating;

                RatingTextBox.BackColor = System.Drawing.Color.White;
            }

            catch
            {
                RatingTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void FilmFindButton_Click(object sender, EventArgs e)
        {
            int bestIndex = FindBestRatedFilmIndex(_films);

            FilmsListBox.SelectedIndex = bestIndex;
        }

        private int FindBestRatedFilmIndex(List<Film> movies)
        {
            double maxRating = movies.Max(m => m.Rating);

            return movies.FindIndex(m => m.Rating == maxRating);
        }

    }
}
