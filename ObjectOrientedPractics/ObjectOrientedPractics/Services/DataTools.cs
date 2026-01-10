using System;
using System.Collections.Generic;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Предоставляет универсальные методы для фильтрации и сортировки данных.
    /// </summary>
    public static class DataTools
    {
        /// <summary>
        /// Фильтрует список товаров по заданному критерию.
        /// </summary>
        /// <param name="items">Исходный список товаров.</param>
        /// <param name="predicate">Критерий фильтрации.</param>
        /// <returns>Новый список, содержащий только элементы, удовлетворяющие условию.</returns>
        /// <exception cref="ArgumentNullException">Выбрасывается, если <paramref name="predicate"/> равен <see langword="null"/>.</exception>
        public static List<Item> Filter(List<Item> items, Func<Item, bool> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));

            var result = new List<Item>();
            if (items == null)
                return result;

            foreach (var item in items)
            {
                if (predicate(item))
                    result.Add(item);
            }
            return result;
        }

        /// <summary>
        /// Сортирует список товаров с использованием алгоритма пузырьковой сортировки.
        /// </summary>
        /// <param name="items">Исходный список товаров.</param>
        /// <param name="comparer">Функция сравнения двух товаров. 
        /// Должна возвращать отрицательное число, если первый элемент меньше второго,
        /// ноль — если равны, положительное — если больше.</param>
        /// <returns>Новый отсортированный список.</returns>
        /// <exception cref="ArgumentNullException">Выбрасывается, если <paramref name="comparer"/> равен <see langword="null"/>.</exception>
        public static List<Item> Sort(List<Item> items, Func<Item, Item, int> comparer)
        {
            if (comparer == null)
                throw new ArgumentNullException(nameof(comparer));

            if (items == null || items.Count <= 1)
                return items == null ? new List<Item>() : new List<Item>(items);

            var sorted = new List<Item>(items);
            int n = sorted.Count;

            for (int i = 0; i < n - 1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (comparer(sorted[j], sorted[j + 1]) > 0)
                    {
                        var temp = sorted[j];
                        sorted[j] = sorted[j + 1];
                        sorted[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }

            return sorted;
        }
    }
}