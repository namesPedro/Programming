using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Реализует процентную скидку на товары определённой категории.
    /// Скидка увеличивается на 1% за каждые 1000 рублей, потраченные в категории.
    /// Максимальная скидка — 10%.
    /// </summary>
    public class PercentDiscount : IDiscount, IComparable<PercentDiscount>
    {
        private const int LevelThreshold = 1000;
        private const int MaxPercent = 10;

        private double _accumulatedSpent;

        /// <summary>
        /// Категория товаров, на которые распространяется скидка.
        /// </summary>
        public Category TargetCategory { get; private set; }

        /// <summary>
        /// Текущий процент скидки (от 1 до 10).
        /// </summary>
        public int Percent { get; private set; }

        /// <summary>
        /// Получает описание скидки для отображения в интерфейсе.
        /// </summary>
        public string Info => $"Процентная «{TargetCategory}» - {Percent}%";

        /// <summary>
        /// Инициализирует новую процентную скидку для указанной категории.
        /// Начальный процент — 1%.
        /// </summary>
        /// <param name="category">Категория товаров.</param>
        public PercentDiscount(Category category)
        {
            TargetCategory = category;
            Percent = 1;
            _accumulatedSpent = 0;
        }

        /// <inheritdoc/>
        public double Calculate(List<Item> items)
        {
            if (items == null)
                return 0;

            double relevantTotal = items
                .Where(item => item.Category == TargetCategory)
                .Sum(item => item.Cost);

            return relevantTotal * (Percent / 100.0);
        }

        /// <inheritdoc/>
        public double Apply(List<Item> items)
        {
            return Calculate(items);
        }

        /// <inheritdoc/>
        public void Update(List<Item> items)
        {
            if (items == null)
                return;

            double spent = items
                .Where(item => item.Category == TargetCategory)
                .Sum(item => item.Cost);

            _accumulatedSpent += spent;
            int newLevel = (int)(_accumulatedSpent / LevelThreshold) + 1;
            Percent = Math.Min(MaxPercent, newLevel);
        }

        /// <inheritdoc/>
        public int CompareTo(PercentDiscount other)
        {
            if (other is null) return 1;
            return Percent.CompareTo(other.Percent);
        }
    }
}