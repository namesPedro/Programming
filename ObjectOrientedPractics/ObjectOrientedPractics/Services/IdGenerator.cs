namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Предоставляет функциональность для генерации уникальных целочисленных идентификаторов.
    /// Идентификаторы генерируются последовательно, начиная с 0.
    /// </summary>
    public static class IdGenerator
    {
        private static int _currentId = 0;

        /// <summary>
        /// Возвращает следующий уникальный идентификатор и увеличивает внутренний счётчик.
        /// Первый вызов вернёт <c>0</c>, второй — <c>1</c> и так далее.
        /// </summary>
        /// <returns>Уникальный целочисленный идентификатор.</returns>
        public static int GetNextId()
        {
            return _currentId++;
        }

        /// <summary>
        /// Сбрасывает внутренний счётчик идентификаторов до нуля.
        /// Следующий вызов <see cref="GetNextId"/> вернёт <c>0</c>.
        /// </summary>
        public static void Reset()
        {
            _currentId = 0;
        }

        /// <summary>
        /// Возвращает текущее значение внутреннего счётчика без его изменения.
        /// Это значение будет присвоено следующему идентификатору при вызове <see cref="GetNextId"/>.
        /// </summary>
        /// <returns>Текущее значение счётчика идентификаторов.</returns>
        public static int GetCurrentId()
        {
            return _currentId;
        }
    }
}