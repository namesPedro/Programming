using System;

/// <summary>
/// Предоставляет методы для проверки столкновений геометрических фигур.
/// </summary>
public static class CollisionManager
{
    /// <summary>
    /// Проверяет столкновение двух прямоугольников.
    /// </summary>
    /// <param name="rect1">Первый прямоугольник для проверки.</param>
    /// <param name="rect2">Второй прямоугольник для проверки.</param>
    /// <returns>
    /// Возвращает true, если прямоугольники пересекаются.
    /// Возвращает false, если прямоугольники не пересекаются.
    /// </returns>
    public static bool IsCollision(Rectangle rect1, Rectangle rect2)
    {
        double dx = Math.Abs(rect1.Center.X - rect2.Center.X);
        double dy = Math.Abs(rect1.Center.Y - rect2.Center.Y);

        return dx < ((rect1.Width + rect2.Width) / 2) &&
               dy < ((rect1.Length + rect2.Length) / 2);
    }

    /// <summary>
    /// Проверяет столкновение двух колец.
    /// </summary>
    /// <param name="ring1">Первое кольцо для проверки.</param>
    /// <param name="ring2">Второе кольцо для проверки.</param>
    /// <returns>
    /// Возвращает true, если кольца пересекаются.
    /// Возвращает false, если кольца не пересекаются.
    /// </returns>
    public static bool IsCollision(Ring ring1, Ring ring2)
    {
        double dx = ring1.Center.X - ring2.Center.X;
        double dy = ring1.Center.Y - ring2.Center.Y;
        double distance = Math.Sqrt(dx * dx + dy * dy);

        return distance < (ring1.OuterRadius + ring2.OuterRadius);
    }
}