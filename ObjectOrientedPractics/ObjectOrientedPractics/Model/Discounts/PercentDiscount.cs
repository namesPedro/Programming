using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectOrientedPractics.Model.Discounts
{
    public class PercentDiscount : IDiscount, IComparable<PercentDiscount>
    {
        public Category TargetCategory { get; private set; }
        public int Percent { get; private set; }
        private double _accumulatedSpent;

        public string Info => $"Процентная «{TargetCategory}» - {Percent}%";

        public PercentDiscount(Category category)
        {
            TargetCategory = category;
            Percent = 1;
            _accumulatedSpent = 0;
        }

        public double Calculate(List<Item> items)
        {
            if (items == null) return 0;

            double relevantTotal = items
                .Where(item => item.Category == TargetCategory)
                .Sum(item => item.Cost);

            return relevantTotal * (Percent / 100.0);
        }

        public double Apply(List<Item> items)
        {
            return Calculate(items);
        }

        public void Update(List<Item> items)
        {
            if (items == null) return;

            double spent = items
                .Where(item => item.Category == TargetCategory)
                .Sum(item => item.Cost);

            _accumulatedSpent += spent;
            int newLevel = (int)(_accumulatedSpent / 1000) + 1;
            Percent = Math.Min(10, newLevel);
        }

        public int CompareTo(PercentDiscount other)
        {
            if (other == null) return 1;
            return Percent.CompareTo(other.Percent);
        }
    }
}