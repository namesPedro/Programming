public class Song
{
    private string title;
    private string artist;
    private int durationMinutes;
    private string genre;

    public string Title
    {
        get => title;
        set => title = value;
    }

    public string Artist
    {
        get => artist;
        set => artist = value;
    }

    public int DurationMinutes
    {
        get => durationMinutes;
        set => durationMinutes = value;
    }

    public string Genre
    {
        get => genre;
        set => genre = value;
    }

    public Song(string title, string artist, int durationMinutes, string genre)
    {
        Title = title;
        Artist = artist;
        DurationMinutes = durationMinutes;
        Genre = genre;
    }

    public Song() { }
}