/// <summary>
/// Представляет точку в двумерном пространстве с целочисленными координатами.
/// </summary>
public class Point2D
{
    private int x;
    private int y;

    /// <summary>
    /// Возвращает или задает координату X точки.
    /// Значение должно быть положительным.
    /// </summary>
    /// <exception cref="ArgumentException">Выбрасывается, если значение отрицательное.</exception>
    public int X
    {
        get => x;
        set
        {
            Validator.AssertOnPositiveValue(value, nameof(X));
            x = value;
        }
    }

    /// <summary>
    /// Возвращает или задает координату Y точки.
    /// Значение должно быть положительным.
    /// </summary>
    /// <exception cref="ArgumentException">Выбрасывается, если значение отрицательное.</exception>
    public int Y
    {
        get => y;
        set
        {
            Validator.AssertOnPositiveValue(value, nameof(Y));
            y = value;
        }
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="Point2D"/> с указанными координатами.
    /// </summary>
    /// <param name="x">Координата X точки. Должна быть положительной.</param>
    /// <param name="y">Координата Y точки. Должна быть положительной.</param>
    /// <exception cref="ArgumentException">Выбрасывается, если x или y отрицательные.</exception>
    public Point2D(int x, int y)
    {
        X = x;
        Y = y;
    }

    /// <summary>
    /// Возвращает строковое представление точки в формате (X, Y).
    /// </summary>
    /// <returns>Строка, представляющая текущую точку.</returns>
    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}