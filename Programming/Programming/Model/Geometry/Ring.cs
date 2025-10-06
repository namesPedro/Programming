using System;

/// <summary>
/// Представляет геометрическую фигуру кольца с заданным центром, внешним и внутренним радиусами.
/// </summary>
public class Ring
{
    private Point2D center;
    private double outerRadius;
    private double innerRadius;

    /// <summary>
    /// Возвращает или задает центр кольца.
    /// </summary>
    public Point2D Center
    {
        get => center;
        set => center = value;
    }

    /// <summary>
    /// Возвращает или задает внешний радиус кольца.
    /// Должен быть положительным числом и не меньше внутреннего радиуса.
    /// </summary>
    /// <exception cref="ArgumentException">
    /// Выбрасывается, если значение отрицательное, равно нулю или меньше внутреннего радиуса.
    /// </exception>
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

    /// <summary>
    /// Возвращает или задает внутренний радиус кольца.
    /// Должен быть положительным числом и не больше внешнего радиуса.
    /// </summary>
    /// <exception cref="ArgumentException">
    /// Выбрасывается, если значение отрицательное, равно нулю или больше внешнего радиуса.
    /// </exception>
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

    /// <summary>
    /// Возвращает площадь кольца, вычисляемую как разность площадей внешнего и внутреннего кругов.
    /// </summary>
    public double Area
    {
        get => Math.PI * (OuterRadius * OuterRadius - InnerRadius * InnerRadius);
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="Ring"/> с указанными параметрами.
    /// </summary>
    /// <param name="center">Центр кольца.</param>
    /// <param name="outerRadius">Внешний радиус кольца. Должен быть больше внутреннего радиуса.</param>
    /// <param name="innerRadius">Внутренний радиус кольца. Должен быть меньше внешнего радиуса.</param>
    /// <exception cref="ArgumentException">
    /// Выбрасывается, если радиусы не соответствуют требованиям.
    /// </exception>
    public Ring(Point2D center, double outerRadius, double innerRadius)
    {
        Center = center;
        OuterRadius = outerRadius;
        InnerRadius = innerRadius;
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="Ring"/> со значениями по умолчанию:
    /// центр в точке (0, 0), внешний радиус = 1.0, внутренний радиус = 0.5.
    /// </summary>
    public Ring() : this(new Point2D(0, 0), 1.0, 0.5) { }
}