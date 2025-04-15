using System;

public class Ring
{
    private Point2D center;
    private double outerRadius;
    private double innerRadius;

    public Point2D Center
    {
        get => center;
        set => center = value;
    }

    public double OuterRadius
    {
        get => outerRadius;
        set
        {
            Validator.AssertOnPositiveValue(value, nameof(OuterRadius));
            if (value < InnerRadius)
            {
                throw new ArgumentException("OuterRadius cannot be less than InnerRadius.");
            }
            outerRadius = value;
        }
    }

    public double InnerRadius
    {
        get => innerRadius;
        set
        {
            Validator.AssertOnPositiveValue(value, nameof(InnerRadius));
            if (value > OuterRadius)
            {
                throw new ArgumentException("InnerRadius cannot be greater than OuterRadius.");
            }
            innerRadius = value;
        }
    }

    public double Area
    {
        get => Math.PI * (OuterRadius * OuterRadius - InnerRadius * InnerRadius);
    }

    public Ring(Point2D center, double outerRadius, double innerRadius)
    {
        Center = center;
        OuterRadius = outerRadius;
        InnerRadius = innerRadius;
    }

    public Ring() : this(new Point2D(0, 0), 1.0, 0.5) { }
}