using System;

/// <summary>
/// Представляет фильм с основной информацией о нем.
/// </summary>
public class Film
{
    private string title;
    private int durationMinutes;
    private int releaseYear;
    private string genre;
    private double rating;

    /// <summary>
    /// Возвращает или задает название фильма.
    /// </summary>
    /// <exception cref="ArgumentException">
    /// Выбрасывается, если значение null или пустая строка.
    /// </exception>
    public string Title
    {
        get => title;
        set => title = value;
    }

    /// <summary>
    /// Возвращает или задает продолжительность фильма в минутах.
    /// </summary>
    /// <exception cref="ArgumentException">
    /// Выбрасывается, если значение меньше или равно 0 или больше 600 (10 часов).
    /// </exception>
    public int DurationMinutes
    {
        get => durationMinutes;
        set => durationMinutes = value;
    }

    /// <summary>
    /// Возвращает или задает год выпуска фильма.
    /// </summary>
    /// <exception cref="ArgumentException">
    /// Выбрасывается, если значение меньше 1900 или больше текущего года.
    /// </exception>
    public int ReleaseYear
    {
        get => releaseYear;
        set
        {
            Validator.AssertValueInRange(value, 1900, DateTime.Now.Year, nameof(ReleaseYear));
            releaseYear = value;
        }
    }

    /// <summary>
    /// Возвращает или задает жанр фильма.
    /// </summary>
    /// <exception cref="ArgumentException">
    /// Выбрасывается, если значение null или пустая строка.
    /// </exception>
    public string Genre
    {
        get => genre;
        set => genre = value;
    }

    /// <summary>
    /// Возвращает или задает рейтинг фильма.
    /// </summary>
    /// <exception cref="ArgumentException">
    /// Выбрасывается, если значение меньше 0 или больше 10.
    /// </exception>
    public double Rating
    {
        get => rating;
        set
        {
            Validator.AssertValueInRange(value, 0, 10, nameof(Rating));
            rating = Math.Round(value, 1); // Округляем до одного знака после запятой
        }
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="Film"/> с указанными параметрами.
    /// </summary>
    /// <param name="title">Название фильма (не может быть пустым).</param>
    /// <param name="durationMinutes">Продолжительность в минутах (1-600).</param>
    /// <param name="releaseYear">Год выпуска (1900-текущий год).</param>
    /// <param name="genre">Жанр фильма (не может быть пустым).</param>
    /// <param name="rating">Рейтинг (0.0-10.0).</param>
    /// <exception cref="ArgumentException">
    /// Выбрасывается, если параметры не соответствуют требованиям.
    /// </exception>
    public Film(string title, int durationMinutes, int releaseYear, string genre, double rating)
    {
        Title = title;
        DurationMinutes = durationMinutes;
        ReleaseYear = releaseYear;
        Genre = genre;
        Rating = rating;
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="Film"/> с значениями по умолчанию.
    /// </summary>
    public Film() { }

    /// <summary>
    /// Возвращает строковое представление продолжительности фильма в формате "Xh Ym".
    /// </summary>
    /// <returns>Отформатированная строка продолжительности.</returns>
    public string GetFormattedDuration()
    {
        return $"{durationMinutes / 60}h {durationMinutes % 60}m";
    }

    /// <summary>
    /// Возвращает строковое представление информации о фильме.
    /// </summary>
    /// <returns>Форматированная строка с основными данными о фильме.</returns>
    public override string ToString()
    {
        return $"{Title} ({ReleaseYear}), {Genre}, Rating: {Rating}/10, Duration: {GetFormattedDuration()}";
    }
}