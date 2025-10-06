using System;
    /// <summary>
    /// Класс с универсальными методами проверки значений.
    /// </summary>
public static class Validator
{
    /// <summary>
    /// Проверка строки на наличие символов.
    /// </summary>
    /// <param name="value">Проверяемая строка.</param>
    /// <param name="propertyName">Имя объекта, которое подлежит проверке.</param>
    public static void AssertNotEmpty(string value, string propertyName)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException($"Свойство {propertyName} не может быть пустым.");
    }

    /// <summary>
    /// Проверка строки на количество символов.
    /// </summary>
    /// <param name="value">Проверяемая строка.</param>
    /// <param name="maxLength">Максимальное значение.</param>
    /// <param name="propertyName">Имя объекта, которое подлежит проверке.</param>
    public static void AssertMaxLength(string value, int maxLength, string propertyName)
    {
        if (value != null && value.Length > maxLength)
            throw new ArgumentException($"Свойство {propertyName} не должно превышать {maxLength} символов.");
    }
}
