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
    /// Предоставляет элемент управления для работы с коллекцией фильмов.
    /// </summary>
    public partial class MoviesClassesControl : UserControl
    {
        private List<Film> _films;
        private Film _currentFilm;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="MoviesClassesControl"/>.
        /// Создает предустановленную коллекцию фильмов.
        /// </summary>
        public MoviesClassesControl()
        {
            InitializeComponent();

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

        /// <summary>
        /// Обрабатывает изменение выбранного фильма в списке.
        /// Обновляет отображаемые данные о фильме.
        /// </summary>
        private void FilmsListBoxIndexChanged(object sender, EventArgs e)
        {
            _currentFilm = _films[FilmsListBox.SelectedIndex];

            TitleTextBox.Text = _currentFilm.Title;
            DurationTextBox.Text = _currentFilm.DurationMinutes.ToString();
            ReleaseTextBox.Text = _currentFilm.ReleaseYear.ToString();
            GenreTextBox.Text = _currentFilm.Genre;
            RatingTextBox.Text = _currentFilm.Rating.ToString("0.0");
        }

        /// <summary>
        /// Обрабатывает изменение длительности фильма.
        /// При недопустимом значении подсвечивает поле ввода.
        /// </summary>
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

        /// <summary>
        /// Обрабатывает изменение года выпуска фильма.
        /// При недопустимом значении подсвечивает поле ввода.
        /// </summary>
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

        /// <summary>
        /// Обрабатывает изменение рейтинга фильма.
        /// При недопустимом значении подсвечивает поле ввода.
        /// </summary>
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

        /// <summary>
        /// Находит и выделяет в списке фильм с наивысшим рейтингом.
        /// </summary>
        private void FilmFindButton_Click(object sender, EventArgs e)
        {
            int bestIndex = FindBestRatedFilmIndex(_films);
            FilmsListBox.SelectedIndex = bestIndex;
        }

        /// <summary>
        /// Находит индекс фильма с наивысшим рейтингом в коллекции.
        /// </summary>
        /// <param name="movies">Коллекция фильмов для поиска.</param>
        /// <returns>Индекс фильма с максимальным рейтингом.</returns>
        private int FindBestRatedFilmIndex(List<Film> movies)
        {
            double maxRating = movies.Max(m => m.Rating);
            return movies.FindIndex(m => m.Rating == maxRating);
        }
    }
}