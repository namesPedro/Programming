using System;

/// <summary>
/// Представляет прямоугольник с заданными размерами, цветом и положением центра.
/// </summary>
public class Rectangle
{
    private static int allRectanglesCount = 0;
    private readonly int id;

    /// <summary>
    /// Возвращает общее количество созданных прямоугольников.
    /// </summary>
    public static int AllRectanglesCount => allRectanglesCount;

    /// <summary>
    /// Возвращает уникальный идентификатор прямоугольника.
    /// </summary>
    public int Id => id;

    private double length;
    private double width;
    private string color;
    private Point2D center;

    /// <summary>
    /// Возвращает или задает длину прямоугольника. Должна быть положительным числом.
    /// </summary>
    /// <exception cref="ArgumentException">Выбрасывается, если значение отрицательное или равно нулю.</exception>
    public double Length
    {
        get => length;
        set
        {
            Validator.AssertOnPositiveValue(value, nameof(Length));
            length = value;
        }
    }

    /// <summary>
    /// Возвращает или задает ширину прямоугольника. Должна быть положительным числом.
    /// </summary>
    /// <exception cref="ArgumentException">Выбрасывается, если значение отрицательное или равно нулю.</exception>
    public double Width
    {
        get => width;
        set
        {
            Validator.AssertOnPositiveValue(value, nameof(Width));
            width = value;
        }
    }

    /// <summary>
    /// Возвращает или задает цвет прямоугольника.
    /// </summary>
    public string Color
    {
        get => color;
        set => color = value;
    }

    /// <summary>
    /// Возвращает или задает центральную точку прямоугольника.
    /// </summary>
    public Point2D Center
    {
        get => center;
        set => center = value;
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="Rectangle"/> с заданными параметрами.
    /// </summary>
    /// <param name="length">Длина прямоугольника. Должна быть положительной.</param>
    /// <param name="width">Ширина прямоугольника. Должна быть положительной.</param>
    /// <param name="color">Цвет прямоугольника.</param>
    /// <param name="center">Центральная точка прямоугольника.</param>
    /// <exception cref="ArgumentException">Выбрасывается, если длина или ширина отрицательные или равны нулю.</exception>
    public Rectangle(double length, double width, string color, Point2D center)
    {
        Length = length;
        Width = width;
        Color = color;
        Center = center;

        allRectanglesCount++;
        id = allRectanglesCount;
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="Rectangle"/> со значениями по умолчанию:
    /// длина = 10, ширина = 10, цвет = "Black", центр в точке (0, 0).
    /// </summary>
    public Rectangle() : this(10, 10, "Black", new Point2D(0, 0)) { }
}