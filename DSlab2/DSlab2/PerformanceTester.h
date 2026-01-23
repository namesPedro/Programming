#pragma once
#include "List.h"
#include "DynamicArray.h"

/// <summary>
/// Структура для хранения результатов измерений производительности.
/// </summary>
struct MeasureResult
{
    int size;
    double listTime;
    double arrayTime;
};

/// <summary>
/// Класс для проведения сравнительных тестов производительности между списком и динамическим массивом.
/// </summary>
class PerformanceTester
{
public:
    /// <summary>
    /// Определяет количество итераций тестирования в зависимости от размера структуры данных.
    /// </summary>
    /// <param name="size">Размер структуры данных.</param>
    /// <returns>Количество итераций для обеспечения точности измерений.</returns>
    static int GetIterationsForSize(int size);

    /// <summary>
    /// Измеряет время вставки элемента в начало списка и массива.
    /// </summary>
    /// <param name="sizes">Массив тестируемых размеров.</param>
    /// <param name="count">Количество размеров.</param>
    /// <param name="results">Выходной массив результатов.</param>
    /// <returns>Количество записанных результатов.</returns>
    static int MeasureInsertAtBeginning(const int* sizes, int count, MeasureResult* results);

    /// <summary>
    /// Измеряет время вставки элемента в конец списка и массива.
    /// </summary>
    /// <param name="sizes">Массив тестируемых размеров.</param>
    /// <param name="count">Количество размеров.</param>
    /// <param name="results">Выходной массив результатов.</param>
    /// <returns>Количество записанных результатов.</returns>
    static int MeasureInsertAtEnd(const int* sizes, int count, MeasureResult* results);

    /// <summary>
    /// Измеряет время вставки элемента в середину списка и массива.
    /// </summary>
    /// <param name="sizes">Массив тестируемых размеров.</param>
    /// <param name="count">Количество размеров.</param>
    /// <param name="results">Выходной массив результатов.</param>
    /// <returns>Количество записанных результатов.</returns>
    static int MeasureInsertAtMiddle(const int* sizes, int count, MeasureResult* results);

    /// <summary>
    /// Измеряет время удаления элемента из начала списка и массива.
    /// </summary>
    /// <param name="sizes">Массив тестируемых размеров.</param>
    /// <param name="count">Количество размеров.</param>
    /// <param name="results">Выходной массив результатов.</param>
    /// <returns>Количество записанных результатов.</returns>
    static int MeasureRemoveFromBeginning(const int* sizes, int count, MeasureResult* results);

    /// <summary>
    /// Измеряет время удаления элемента с конца списка и массива.
    /// </summary>
    /// <param name="sizes">Массив тестируемых размеров.</param>
    /// <param name="count">Количество размеров.</param>
    /// <param name="results">Выходной массив результатов.</param>
    /// <returns>Количество записанных результатов.</returns>
    static int MeasureRemoveFromEnd(const int* sizes, int count, MeasureResult* results);

    /// <summary>
    /// Измеряет время удаления элемента из середины списка и массива.
    /// </summary>
    /// <param name="sizes">Массив тестируемых размеров.</param>
    /// <param name="count">Количество размеров.</param>
    /// <param name="results">Выходной массив результатов.</param>
    /// <returns>Количество записанных результатов.</returns>
    static int MeasureRemoveFromMiddle(const int* sizes, int count, MeasureResult* results);
};