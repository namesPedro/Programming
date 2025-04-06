using System;

public class Film
{
    private string title;
    private int durationMinutes;
    private int releaseYear;
    private string genre;
    private double rating;

    public string Title
    {
        get => title;
        set => title = value;
    }

    public int DurationMinutes
    {
        get => durationMinutes;
        set => durationMinutes = value;
    }

    public int ReleaseYear
    {
        get => releaseYear;
        set
        {
            if (value < 1900 || value > DateTime.Now.Year) throw new ArgumentException("Год выпуска должен быть между 1900 и текущим годом.");

            releaseYear = value;
        }
    }

    public string Genre
    {
        get => genre;
        set => genre = value;
    }

    public double Rating
    {
        get => rating;
        set
        {
            if (value < 0 || value > 10) throw new ArgumentException("Рейтинг должен быть от 0 до 10.");

            rating = value;
        }
    }

    public Film(string title, int durationMinutes, int releaseYear, string genre, double rating)
    {
        Title = title;
        DurationMinutes = durationMinutes;
        ReleaseYear = releaseYear;
        Genre = genre;
        Rating = rating;
    }

    public Film() { }
}