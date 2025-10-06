using System;

/// <summary>
/// Предоставляет методы для валидации числовых значений.
/// </summary>
public static class Validator
{
    /// <summary>
    /// Проверяет, что целочисленное значение положительное.
    /// </summary>
    /// <param name="value">Проверяемое значение.</param>
    /// <param name="propertyName">Наименование свойства (для сообщения об ошибке).</param>
    /// <exception cref="ArgumentException">Выбрасывается, если значение меньше или равно нулю.</exception>
    public static void AssertOnPositiveValue(int value, string propertyName)
    {
        if (value <= 0)
            throw new ArgumentException($"Property {propertyName} must be a positive integer.");
    }

    /// <summary>
    /// Проверяет, что вещественное значение положительное.
    /// </summary>
    /// <param name="value">Проверяемое значение.</param>
    /// <param name="propertyName">Наименование свойства (для сообщения об ошибке).</param>
    /// <exception cref="ArgumentException">Выбрасывается, если значение меньше или равно нулю.</exception>
    public static void AssertOnPositiveValue(double value, string propertyName)
    {
        if (value <= 0.0)
            throw new ArgumentException($"Property {propertyName} must be a positive number.");
    }

    /// <summary>
    /// Проверяет, что целочисленное значение находится в указанном диапазоне.
    /// </summary>
    /// <param name="value">Проверяемое значение.</param>
    /// <param name="min">Минимально допустимое значение (включительно).</param>
    /// <param name="max">Максимально допустимое значение (включительно).</param>
    /// <param name="propertyName">Наименование свойства (для сообщения об ошибке).</param>
    /// <exception cref="ArgumentException">Выбрасывается, если значение вне допустимого диапазона.</exception>
    public static void AssertValueInRange(int value, int min, int max, string propertyName)
    {
        if (value < min || value > max)
            throw new ArgumentException($"Property {propertyName} must be between {min} and {max}.");
    }

    /// <summary>
    /// Проверяет, что вещественное значение находится в указанном диапазоне.
    /// </summary>
    /// <param name="value">Проверяемое значение.</param>
    /// <param name="min">Минимально допустимое значение (включительно).</param>
    /// <param name="max">Максимально допустимое значение (включительно).</param>
    /// <param name="propertyName">Наименование свойства (для сообщения об ошибке).</param>
    /// <exception cref="ArgumentException">Выбрасывается, если значение вне допустимого диапазона.</exception>
    public static void AssertValueInRange(double value, double min, double max, string propertyName)
    {
        if (value < min || value > max)
            throw new ArgumentException($"Property {propertyName} must be between {min} and {max}.");
    }
}