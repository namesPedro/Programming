public class TrialInfo
{
    public string Type { get; set; }

    public string Location { get; set; }

    public string Story { get; set; }

    public TrialInfo(string type, string location, string story)
    {
        Type = type;
        Location = location;
        Story = story;
    }

    public override string ToString()
    {
        return $"[{Type}] {Location} - {Story}";
    }
}