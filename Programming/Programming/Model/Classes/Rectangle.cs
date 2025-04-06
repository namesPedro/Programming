using System;

public class Rectangle
{
    private double length;
    private double width;
    private string color;

    public double Length
    {
        get => length;
        set
        {
            if (value < 0) throw new ArgumentException("Длина не может быть отрицательной.");

            length = value;
        }
    }

    public double Width
    {
        get => width;
        set
        {
            if (value < 0) throw new ArgumentException("Ширина не может быть отрицательной.");

            width = value;
        }
    }

    public string Color
    {
        get => color;
        set => color = value;
    }

    public Rectangle(double length, double width, string color)
    {
        Length = length;
        Width = width;
        Color = color;
    }

    public Rectangle() { }
}