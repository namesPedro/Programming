#pragma once
#include <string>
#include "HashTable.h"

/// <summary>
/// Словарь, реализованный на основе хеш-таблицы.
/// Ключи уникальны, дублирование не допускается.
/// </summary>
class Dictionary
{
private:
    HashTable _hashTable;

    /// <summary>
    /// Возвращает все пары ключ-значение из словаря.
    /// </summary>
    /// <returns>Вектор пар ключ-значение.</returns>
    std::vector<KeyValuePair> GetAllPairs() const;

public:
    /// <summary>
    /// Добавляет пару "ключ-значение" в словарь.
    /// Если ключ уже существует, выводится ошибка.
    /// </summary>
    /// <param name="key">Ключ.</param>
    /// <param name="value">Значение.</param>
    /// <returns>true, если добавление успешно.</returns>
    bool Add(const std::string& key, const std::string& value);

    /// <summary>
    /// Удаляет пару по ключу.
    /// </summary>
    /// <param name="key">Ключ для удаления.</param>
    /// <returns>true, если удаление успешно.</returns>
    bool Remove(const std::string& key);

    /// <summary>
    /// Ищет значение по ключу.
    /// </summary>
    /// <param name="key">Ключ для поиска.</param>
    /// <returns>Значение или пустая строка, если не найдено.</returns>
    std::string Find(const std::string& key) const;

    /// <summary>
    /// Проверяет наличие ключа в словаре.
    /// </summary>
    /// <param name="key">Ключ.</param>
    /// <returns>true, если ключ существует.</returns>
    bool HasKey(const std::string& key) const;

    /// <summary>
    /// Выводит текущее состояние словаря.
    /// </summary>
    void Display() const;

    /// <summary>
    /// Возвращает количество пар в словаре.
    /// </summary>
    /// <returns>Количество пар.</returns>
    int GetSize() const;

    /// <summary>
    /// Очищает словарь.
    /// </summary>
    void Clear();

    /// <summary>
    /// Возвращает ссылку на внутреннюю хеш-таблицу для демонстрации.
    /// </summary>
    /// <returns>Ссылка на HashTable.</returns>
    const HashTable& GetHashTable() const;
};