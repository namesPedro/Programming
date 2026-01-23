#pragma once
#include <string>

/// <summary>
/// Представляет пару "ключ-значение" для хранения в хеш-таблице и словаре.
/// </summary>
struct KeyValuePair
{
private:
    std::string _key;
    std::string _value;

public:
    /// <summary>
    /// Конструктор пары "ключ-значение".
    /// </summary>
    /// <param name="key">Ключ (строка).</param>
    /// <param name="value">Значение (строка).</param>
    KeyValuePair(const std::string& key, const std::string& value);

    /// <summary>
    /// Возвращает ключ пары.
    /// </summary>
    /// <returns>Ключ.</returns>
    std::string GetKey() const;

    /// <summary>
    /// Возвращает значение пары.
    /// </summary>
    /// <returns>Значение.</returns>
    std::string GetValue() const;

    /// <summary>
    /// Устанавливает новое значение пары.
    /// </summary>
    /// <param name="value">Новое значение.</param>
    void SetValue(const std::string& value);
};