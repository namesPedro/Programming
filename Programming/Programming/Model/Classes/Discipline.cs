/// <summary>
/// Представляет учебную дисциплину в образовательном учреждении.
/// </summary>
public class Discipline
{
    private string name;
    private string teacher;
    private string semester;
    private int credits;

    /// <summary>
    /// Получает или задает название учебной дисциплины.
    /// </summary>
    public string Name
    {
        get => name;
        set => name = value;
    }

    /// <summary>
    /// Получает или задает имя преподавателя, ведущего дисциплину.
    /// </summary>
    public string Teacher
    {
        get => teacher;
        set => teacher = value;
    }

    /// <summary>
    /// Получает или задает семестр, в котором преподается дисциплина.
    /// </summary>
    /// <remarks>
    /// Обычно указывается в формате "Осень 2023" или "Весна 2024".
    /// </remarks>
    public string Semester
    {
        get => semester;
        set => semester = value;
    }

    /// <summary>
    /// Получает или задает количество кредитных единиц по дисциплине.
    /// </summary>
    public int Credits
    {
        get => credits;
        set => credits = value;
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="Discipline"/> с указанными параметрами.
    /// </summary>
    /// <param name="name">Название дисциплины.</param>
    /// <param name="teacher">Преподаватель дисциплины.</param>
    /// <param name="semester">Семестр проведения.</param>
    /// <param name="credits">Количество кредитов.</param>
    public Discipline(string name, string teacher, string semester, int credits)
    {
        Name = name;
        Teacher = teacher;
        Semester = semester;
        Credits = credits;
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="Discipline"/> с значениями по умолчанию.
    /// </summary>
    public Discipline() { }
}