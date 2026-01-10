using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectOrientedPractics.Model.Discounts
{
    public class PointsDiscount : IDiscount
    {
        private int _points;

        public int Points
        {
            get => _points;
            private set => _points = Math.Max(0, value);
        }

        public string Info => $"Накопительная – {Points} баллов";

        public PointsDiscount()
        {
            _points = 0;
        }

        public double Calculate(List<Item> items)
        {
            if (items == null || items.Count == 0) return 0;

            double total = items.Sum(item => item.Cost);
            double maxDiscount = total * 0.3;
            return Math.Min(Points, maxDiscount);
        }

        public double Apply(List<Item> items)
        {
            double discount = Calculate(items);
            int pointsToSpend = (int)Math.Floor(discount);
            Points -= pointsToSpend;
            return discount;
        }

        public void Update(List<Item> items)
        {
            if (items == null || items.Count == 0) return;

            double total = items.Sum(item => item.Cost);
            int earnedPoints = (int)Math.Ceiling(total * 0.1);
            Points += earnedPoints;
        }
    }
}