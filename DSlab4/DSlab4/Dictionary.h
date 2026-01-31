#pragma once
#include <string>
#include <vector>
#include <unordered_map>  // или своя реализация уникального хранилища

/// <summary>
/// Словарь - хранит только уникальные ключи.
/// Использует собственную структуру для хранения данных.
/// </summary>
class Dictionary
{
private:
    // Внутреннее хранилище для уникальных пар ключ-значение
    std::unordered_map<std::string, std::string> _data;

    // Ссылка на хеш-таблицу для демонстрации работы с дубликатами
    class HashTable* _hashTableRef;

public:
    /// <summary>
    /// Конструктор словаря.
    /// </summary>
    /// <param name="hashTable">Ссылка на хеш-таблицу для записи всех операций</param>
    Dictionary(class HashTable& hashTable);

    /// <summary>
    /// Добавляет пару "ключ-значение" в словарь.
    /// Если ключ уже существует, выводится ошибка.
    /// </summary>
    bool Add(const std::string& key, const std::string& value);

    /// <summary>
    /// Удаляет пару по ключу.
    /// </summary>
    bool Remove(const std::string& key);

    /// <summary>
    /// Ищет значение по ключу.
    /// </summary>
    std::string Find(const std::string& key) const;

    /// <summary>
    /// Проверяет наличие ключа в словаре.
    /// </summary>
    bool HasKey(const std::string& key) const;

    /// <summary>
    /// Возвращает количество пар в словаре.
    /// </summary>
    int GetSize() const;

    /// <summary>
    /// Очищает словарь.
    /// </summary>
    void Clear();

    /// <summary>
    /// Возвращает все пары ключ-значение.
    /// </summary>
    std::vector<std::pair<std::string, std::string>> GetAllPairs() const;
};