using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Сервисный класс для валидации значений
    /// </summary>
    public static class ValueValidator
    {
        /// <summary>
        /// Проверяет длину строки и выбрасывает исключение, если длина превышает максимальную
        /// </summary>
        /// <param name="value">Проверяемая строка</param>
        /// <param name="maxLength">Максимально допустимая длина строки</param>
        /// <param name="propertyName">Наименование свойства для текста исключения</param>
        /// <exception cref="ArgumentException">Выбрасывается когда длина строки превышает maxLength</exception>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value?.Length > maxLength)
            {
                throw new ArgumentException(
                    $"{propertyName} должен быть меньше {maxLength} символов");
            }
        }
    }
}
