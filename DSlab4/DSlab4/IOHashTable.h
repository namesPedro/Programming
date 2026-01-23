#pragma once
#include "HashTable.h"

/// <summary>
/// Вспомогательные функции для ввода/вывода хеш-таблицы.
/// </summary>
class IOHashTable
{
public:
    /// <summary>
    /// Выводит состояние хеш-таблицы в консоль.
    /// </summary>
    /// <param name="table">Хеш-таблица.</param>
    static void Display(const HashTable& table);
};