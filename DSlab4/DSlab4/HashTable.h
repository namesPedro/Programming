#pragma once
#ifndef HASHTABLE_H
#define HASHTABLE_H

#include "KeyValuePair.h"

/// <summary>
/// Хеш-таблица с открытой адресацией и двойным хешированием.
/// Поддерживает вставку, поиск, удаление и автоматическое рехеширование.
/// </summary>
class HashTable
{
private:
    KeyValuePair* table;
    int capacity;
    int size;
    const double LOAD_FACTOR_THRESHOLD = 0.7;

    int pearsonHash(const std::string& key, int tableSize) const;
    int hash2(const std::string& key) const;
    int findIndex(const std::string& key, bool forInsert) const;
    void rehash();

public:
    /// <summary>
    /// Конструктор хеш-таблицы.
    /// </summary>
    /// <param name="initialCapacity">Начальная ёмкость таблицы (по умолчанию 16).</param>
    HashTable(int initialCapacity = 16);

    /// <summary>
    /// Деструктор хеш-таблицы. Освобождает выделенную память.
    /// </summary>
    ~HashTable();

    /// <summary>
    /// Вставляет пару "ключ-значение" в таблицу. При переполнении выполняется рехеширование.
    /// Если ключ уже существует, его значение обновляется.
    /// </summary>
    /// <param name="key">Ключ для вставки.</param>
    /// <param name="value">Значение, связанное с ключом.</param>
    /// <returns>true при успешной вставке или обновлении; false, если таблица полна.</returns>
    bool insert(const std::string& key, const std::string& value);

    /// <summary>
    /// Ищет значение по заданному ключу.
    /// </summary>
    /// <param name="key">Ключ для поиска.</param>
    /// <param name="value">Сюда будет записано найденное значение (если найдено).</param>
    /// <returns>true, если ключ найден и не помечен как удалённый; иначе false.</returns>
    bool find(const std::string& key, std::string& value) const;

    /// <summary>
    /// Удаляет запись по ключу (логическое удаление через флаг isDeleted).
    /// </summary>
    /// <param name="key">Ключ для удаления.</param>
    /// <returns>true, если ключ был найден и помечен как удалённый; иначе false.</returns>
    bool remove(const std::string& key);

    /// <summary>
    /// Выводит текущее состояние хеш-таблицы (ёмкость, размер, коэффициент заполнения и содержимое).
    /// </summary>
    void display() const;

    /// <summary>
    /// Возвращает текущее количество элементов в таблице.
    /// </summary>
    /// <returns>Число активных записей.</returns>
    int getSize() const { return size; }

    /// <summary>
    /// Возвращает текущую ёмкость таблицы.
    /// </summary>
    /// <returns>Размер внутреннего массива.</returns>
    int getCapacity() const { return capacity; }

    /// <summary>
    /// Возвращает текущий коэффициент заполнения таблицы.
    /// </summary>
    /// <returns>Отношение количества элементов к ёмкости (от 0.0 до 1.0).</returns>
    double getLoadFactor() const { return (double)size / capacity; }
};

#endif