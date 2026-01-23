#pragma once
#include "Dictionary.h"

/// <summary>
/// Вспомогательные функции для ввода/вывода словаря.
/// </summary>
class IODictionary
{
public:
    /// <summary>
    /// Выводит состояние словаря в консоль.
    /// </summary>
    /// <param name="dict">Словарь.</param>
    static void Display(const Dictionary& dict);
};