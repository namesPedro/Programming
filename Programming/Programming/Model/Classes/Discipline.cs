public class Discipline
{
    private string name;
    private string teacher;
    private string semester;
    private int credits;

    public string Name
    {
        get => name;
        set => name = value;
    }

    public string Teacher
    {
        get => teacher;
        set => teacher = value;
    }

    public string Semester
    {
        get => semester;
        set => semester = value;
    }

    public int Credits
    {
        get => credits;
        set => credits = value;
    }

    public Discipline(string name, string teacher, string semester, int credits)
    {
        Name = name;
        Teacher = teacher;
        Semester = semester;
        Credits = credits;
    }

    public Discipline() { }
}