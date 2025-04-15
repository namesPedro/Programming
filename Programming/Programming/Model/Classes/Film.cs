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
            Validator.AssertValueInRange(value, 1900, DateTime.Now.Year, nameof(ReleaseYear));

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
            Validator.AssertValueInRange(value, 0, 10, nameof(Rating));

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