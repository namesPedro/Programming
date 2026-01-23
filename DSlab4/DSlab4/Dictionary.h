#pragma once
#ifndef DICTIONARY_H
#define DICTIONARY_H

#include "HashTable.h"
#include <iostream>

/// <summary>
/// Словарь на основе хеш-таблицы, предоставляющий интерфейс для работы с парами "ключ-значение".
/// </summary>
class Dictionary
{
private:
    HashTable hashTable;

public:
    /// <summary>
    /// Конструктор словаря. Инициализирует внутреннюю хеш-таблицу.
    /// </summary>
    Dictionary() : hashTable()
    {
    }

    /// <summary>
    /// Добавляет новую пару "ключ-значение" в словарь.
    /// Если ключ уже существует, операция завершится с ошибкой.
    /// </summary>
    /// <param name="key">Ключ для добавления.</param>
    /// <param name="value">Значение, связанное с ключом.</param>
    void add(const std::string& key, const std::string& value);

    /// <summary>
    /// Удаляет запись по указанному ключу.
    /// </summary>
    /// <param name="key">Ключ для удаления.</param>
    /// <returns>true, если ключ был найден и удалён; иначе false.</returns>
    bool remove(const std::string& key);

    /// <summary>
    /// Ищет значение по заданному ключу.
    /// </summary>
    /// <param name="key">Ключ для поиска.</param>
    /// <param name="value">Сюда будет записано найденное значение (если найдено).</param>
    /// <returns>true, если ключ найден; иначе false.</returns>
    bool find(const std::string& key, std::string& value) const;

    /// <summary>
    /// Выводит текущее состояние словаря (включая содержимое хеш-таблицы).
    /// </summary>
    void display() const;

    /// <summary>
    /// Очищает словарь (в текущей реализации выводится информационное сообщение).
    /// </summary>
    void clear();
};

#endif