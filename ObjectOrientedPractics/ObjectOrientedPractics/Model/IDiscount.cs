using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Определяет контракт для всех типов скидок.
    /// </summary>
    public interface IDiscount
    {
        /// <summary>
        /// Получает человекочитаемое описание скидки для отображения в интерфейсе.
        /// </summary>
        string Info { get; }

        /// <summary>
        /// Рассчитывает сумму скидки на основе списка товаров без изменения их состояния.
        /// </summary>
        /// <param name="items">Список товаров в корзине.</param>
        /// <returns>Сумма скидки в рублях.</returns>
        double Calculate(List<Item> items);

        /// <summary>
        /// Применяет скидку к товарам (если требуется) и возвращает сумму скидки.
        /// </summary>
        /// <param name="items">Список товаров в корзине.</param>
        /// <returns>Сумма применённой скидки в рублях.</returns>
        double Apply(List<Item> items);

        /// <summary>
        /// Обновляет внутреннее состояние скидки после завершения покупки (например, начисление баллов).
        /// </summary>
        /// <param name="items">Список купленных товаров.</param>
        void Update(List<Item> items);
    }
}