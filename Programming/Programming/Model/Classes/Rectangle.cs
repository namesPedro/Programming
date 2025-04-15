using System;

public class Rectangle
{
    private static int allRectanglesCount = 0;
    private readonly int id;

    public static int AllRectanglesCount => allRectanglesCount;

    public int Id => id;

    private double length;
    private double width;
    private string color;
    private Point2D center;

    public double Length
    {
        get => length;
        set
        {
            Validator.AssertOnPositiveValue(value, nameof(Length));

            length = value;
        }
    }

    public double Width
    {
        get => width;
        set
        {
            Validator.AssertOnPositiveValue(value, nameof(Width));

            width = value;
        }
    }

    public string Color
    {
        get => color;
        set => color = value;
    }

    public Point2D Center
    {
        get => center;
        private set => center = value;
    }

    public Rectangle(double length, double width, string color, Point2D center)
    {
        Length = length;
        Width = width;
        Color = color;
        Center = center;

        allRectanglesCount++;
        id = allRectanglesCount;
    }

    public Rectangle() : this(10, 10, "Black", new Point2D(0, 0)) { }
}