using System.Collections.Generic;
using System;

/// <summary>
/// Предоставляет методы для создания прямоугольников со случайными параметрами.
/// </summary>
public static class RectangleFactory
{
    private static Random _rand = new Random();

    private static readonly List<string> colors = new List<string>
    {
        "Red", "Green", "Blue", "Yellow", "Purple", "Orange", "Pink",
        "Brown", "Black", "White", "Cyan", "Magenta", "Gray", "Gold", "Lime"
    };

    /// <summary>
    /// Создает новый прямоугольник со случайными параметрами.
    /// </summary>
    /// <returns>Новый экземпляр класса <see cref="Rectangle"/> со случайными характеристиками.</returns>
    public static Rectangle Randomize()
    {
        int x = _rand.Next(1, 400);
        int y = _rand.Next(1, 400);
        int width = _rand.Next(10, 150);
        int height = _rand.Next(10, 150);
        string color = colors[_rand.Next(0, 14)];

        return new Rectangle(height, width, color, new Point2D(x, y));
    }
}