using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Реализует накопительную систему скидок на основе баллов.
    /// Покупатель получает 10% от стоимости покупки в баллах.
    /// Баллы можно тратить как рубли (1 балл = 1 рубль), максимум 30% от суммы заказа.
    /// </summary>
    public class PointsDiscount : IDiscount, IComparable<PointsDiscount>
    {
        private const double EarnRate = 0.10;
        private const double MaxDiscountRatio = 0.30;

        private int _points;

        /// <summary>
        /// Текущее количество накопленных баллов.
        /// </summary>
        public int Points
        {
            get => _points;
            private set => _points = Math.Max(0, value);
        }

        /// <summary>
        /// Получает описание скидки для отображения в интерфейсе.
        /// </summary>
        public string Info => $"Накопительная – {Points} баллов";

        /// <summary>
        /// Инициализирует новую накопительную скидку с нулевым балансом.
        /// </summary>
        public PointsDiscount()
        {
            _points = 0;
        }

        /// <inheritdoc/>
        public double Calculate(List<Item> items)
        {
            if (items == null || items.Count == 0)
                return 0;

            double total = items.Sum(item => item.Cost);
            double maxDiscount = total * MaxDiscountRatio;
            return Math.Min(_points, maxDiscount);
        }

        /// <inheritdoc/>
        public double Apply(List<Item> items)
        {
            double discount = Calculate(items);
            int pointsToSpend = (int)Math.Floor(discount);
            _points -= pointsToSpend;
            return pointsToSpend;
        }

        /// <inheritdoc/>
        public void Update(List<Item> items)
        {
            if (items == null || items.Count == 0)
                return;

            double total = items.Sum(item => item.Cost);
            int earnedPoints = (int)Math.Ceiling(total * EarnRate);
            _points += earnedPoints;
        }

        /// <inheritdoc/>
        public int CompareTo(PointsDiscount other)
        {
            if (other is null) return 1;
            return _points.CompareTo(other._points);
        }
    }
}