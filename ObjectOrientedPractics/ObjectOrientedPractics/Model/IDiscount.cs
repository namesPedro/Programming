using System.Collections.Generic;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет общий интерфейс для всех типов скидок.
    /// </summary>
    public interface IDiscount
    {
        /// <summary>
        /// Возвращает информацию о скидке для отображения.
        /// </summary>
        string Info { get; }

        /// <summary>
        /// Рассчитывает размер скидки без её применения.
        /// </summary>
        double Calculate(List<Item> items);

        /// <summary>
        /// Применяет скидку и возвращает её размер.
        /// </summary>
        double Apply(List<Item> items);

        /// <summary>
        /// Обновляет внутреннее состояние скидки после покупки.
        /// </summary>
        void Update(List<Item> items);
    }
}