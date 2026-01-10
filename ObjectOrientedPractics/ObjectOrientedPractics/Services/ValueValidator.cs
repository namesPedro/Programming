using System;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Предоставляет методы для валидации значений.
    /// </summary>
    public static class ValueValidator
    {
        /// <summary>
        /// Проверяет, что длина строки не превышает заданного максимума.
        /// Строка может быть <see langword="null"/> или пустой — это допустимо.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="maxLength">Максимально допустимая длина строки (включительно).</param>
        /// <param name="propertyName">Имя свойства для отображения в сообщении об ошибке.</param>
        /// <exception cref="ArgumentException">
        /// Выбрасывается, если длина строки больше <paramref name="maxLength"/>.
        /// </exception>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value != null && value.Length > maxLength)
            {
                throw new ArgumentException(
                    $"{propertyName} не должен превышать {maxLength} символов.");
            }
        }
    }
}