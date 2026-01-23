#pragma once
#include <vector>
#include <string>
#include "KeyValuePair.h"

/// <summary>
/// Хеш-таблица, реализованная с методом цепочек (chaining).
/// Использует хеш-функцию Пирсона.
/// </summary>
class HashTable
{
private:
    std::vector<std::vector<KeyValuePair>> _buckets;
    int _capacity;
    int _size;
    const double LOAD_FACTOR_THRESHOLD = 0.7;

    /// <summary>
    /// Таблица Пирсона (случайная перестановка 0..255).
    /// </summary>
    static const unsigned char _pearsonTable[256];

    /// <summary>
    /// Вычисляет хеш-код для строки с использованием метода Пирсона.
    /// </summary>
    /// <param name="key">Ключ (строка).</param>
    /// <returns>Хеш-код в диапазоне [0, capacity-1].</returns>
    int HashFunction(const std::string& key) const;

    /// <summary>
    /// Перехеширует таблицу, увеличивая её размер вдвое.
    /// </summary>
    void Rehash();

public:
    /// <summary>
    /// Конструктор хеш-таблицы с начальной вместимостью 16.
    /// </summary>
    HashTable();

    /// <summary>
    /// Конструктор копирования.
    /// </summary>
    HashTable(const HashTable& other);

    /// <summary>
    /// Оператор присваивания.
    /// </summary>
    HashTable& operator=(const HashTable& other);

    /// <summary>
    /// Деструктор хеш-таблицы.
    /// </summary>
    ~HashTable();

    /// <summary>
    /// Вставляет пару "ключ-значение" в хеш-таблицу.
    /// Дублирование ключей разрешено.
    /// </summary>
    /// <param name="key">Ключ.</param>
    /// <param name="value">Значение.</param>
    /// <returns>true, если вставка успешна.</returns>
    bool Insert(const std::string& key, const std::string& value);

    /// <summary>
    /// Удаляет первое вхождение пары по ключу.
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
    /// Возвращает текущий размер таблицы (количество пар).
    /// </summary>
    /// <returns>Количество пар.</returns>
    int GetSize() const;

    /// <summary>
    /// Возвращает вместимость таблицы.
    /// </summary>
    /// <returns>Вместимость.</returns>
    int GetCapacity() const;

    /// <summary>
    /// Выводит состояние хеш-таблицы в консоль.
    /// </summary>
    void Display() const;
};