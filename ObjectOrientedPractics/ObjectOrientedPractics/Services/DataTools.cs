using System;
using System.Collections.Generic;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Содержит универсальные методы для обработки данных.
    /// </summary>
    public static class DataTools
    {
        /// <summary>
        /// Фильтрует список товаров по заданному критерию.
        /// </summary>
        /// <param name="items">Исходный список товаров.</param>
        /// <param name="predicate">Критерий фильтрации.</param>
        /// <returns>Новый список, содержащий только подходящие товары.</returns>
        public static List<Item> Filter(List<Item> items, Func<Item, bool> predicate)
        {
            if (items == null || predicate == null)
                return new List<Item>();

            var result = new List<Item>();
            foreach (var item in items)
            {
                if (predicate(item))
                    result.Add(item);
            }
            return result;
        }

        /// <summary>
        /// Сортирует список товаров по заданному компаратору.
        /// </summary>
        /// <param name="items">Исходный список товаров.</param>
        /// <param name="comparer">Функция сравнения двух товаров.</param>
        /// <returns>Новый отсортированный список.</returns>
        public static List<Item> Sort(List<Item> items, Func<Item, Item, int> comparer)
        {
            if (items == null || comparer == null)
                return new List<Item>(items ?? new List<Item>());

            // Создаём копию списка, чтобы не менять оригинал
            var sorted = new List<Item>(items);
            // Простая пузырьковая сортировка (как в задании)
            for (int i = 0; i < sorted.Count; i++)
            {
                for (int j = 1; j < sorted.Count; j++)
                {
                    if (comparer(sorted[j], sorted[j - 1]) < 0)
                    {
                        (sorted[j], sorted[j - 1]) = (sorted[j - 1], sorted[j]);
                    }
                }
            }
            return sorted;
        }
    }
}