#pragma once
#ifndef KEYVALUEPAIR_H
#define KEYVALUEPAIR_H

#include <string>

/// <summary>
/// Представляет пару "ключ-значение" с флагом логического удаления.
/// Используется в хеш-таблице с открытой адресацией.
/// </summary>
struct KeyValuePair
{
    std::string key;
    std::string value;
    bool isDeleted;

    /// <summary>
    /// Конструктор по умолчанию. Инициализирует пустой ключ, пустое значение и флаг isDeleted = false.
    /// </summary>
    KeyValuePair() : key(""), value(""), isDeleted(false)
    {
    }

    /// <summary>
    /// Конструктор с параметрами.
    /// </summary>
    /// <param name="k">Ключ.</param>
    /// <param name="v">Значение.</param>
    KeyValuePair(const std::string& k, const std::string& v)
        : key(k), value(v), isDeleted(false)
    {
    }
};

#endif