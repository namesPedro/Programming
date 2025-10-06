/// <summary>
/// Представляет музыкальную композицию с основными характеристиками.
/// </summary>
public class Song
{
    private string title;
    private string artist;
    private int durationMinutes;
    private string genre;

    /// <summary>
    /// Возвращает или задает название песни.
    /// </summary>
    public string Title
    {
        get => title;
        set => title = value;
    }

    /// <summary>
    /// Возвращает или задает исполнителя песни.
    /// </summary>
    public string Artist
    {
        get => artist;
        set => artist = value;
    }

    /// <summary>
    /// Возвращает или задает продолжительность песни в минутах.
    /// </summary>
    /// <remarks>
    /// Значение должно быть положительным числом.
    /// </remarks>
    public int DurationMinutes
    {
        get => durationMinutes;
        set => durationMinutes = value;
    }

    /// <summary>
    /// Возвращает или задает жанр песни.
    /// </summary>
    public string Genre
    {
        get => genre;
        set => genre = value;
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="Song"/> с указанными параметрами.
    /// </summary>
    /// <param name="title">Название песни.</param>
    /// <param name="artist">Исполнитель песни.</param>
    /// <param name="durationMinutes">Продолжительность в минутах (положительное число).</param>
    /// <param name="genre">Жанр песни.</param>
    public Song(string title, string artist, int durationMinutes, string genre)
    {
        Title = title;
        Artist = artist;
        DurationMinutes = durationMinutes;
        Genre = genre;
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="Song"/> с пустыми значениями.
    /// </summary>
    public Song() { }
}