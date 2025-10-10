using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Генератор уникальных идентификаторов
    /// </summary>
    public static class IdGenerator
    {
        /// <summary>
        /// Текущее значение идентификатора
        /// </summary>
        private static int _currentId = 0;

        /// <summary>
        /// Возвращает следующий уникальный идентификатор
        /// </summary>
        /// <returns>Уникальный целочисленный идентификатор</returns>
        public static int GetNextId()
        {
            return _currentId++;
        }

        /// <summary>
        /// Сбрасывает счетчик идентификаторов до начального значения
        /// </summary>
        public static void Reset()
        {
            _currentId = 0;
        }

        /// <summary>
        /// Возвращает текущее значение идентификатора без его увеличения
        /// </summary>
        /// <returns>Текущее значение идентификатора</returns>
        public static int GetCurrentId()
        {
            return _currentId;
        }
    }
}
