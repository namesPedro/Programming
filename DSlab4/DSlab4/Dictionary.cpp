#include "Dictionary.h"
#include "HashTable.h"
#include <iostream>

Dictionary::Dictionary(HashTable& hashTable) : _hashTableRef(&hashTable)
{
}

bool Dictionary::Add(const std::string& key, const std::string& value)
{
    std::cout << "\n=== Dictionary Operation: Add ===" << std::endl;
    std::cout << "Attempting to add: [" << key << "] = " << value << std::endl;

    // Проверяем уникальность ключа в словаре
    if (HasKey(key))
    {
        std::cout << "Dictionary: Error! Key '" << key << "' already exists. Duplicate keys are not allowed in Dictionary." << std::endl;
        std::cout << "Dictionary: Key NOT added to Dictionary." << std::endl;

        // В хеш-таблицу добавляем, т.к. там разрешены дубликаты
        _hashTableRef->Insert(key, value);
        std::cout << "HashTable: Key added to HashTable (duplicates allowed)." << std::endl;

        return false;
    }

    // Добавляем в словарь (уникальные ключи)
    _data[key] = value;

    // Добавляем в хеш-таблицу (разрешены дубликаты)
    _hashTableRef->Insert(key, value);

    std::cout << "Dictionary: Key successfully added." << std::endl;
    std::cout << "HashTable: Key added to HashTable." << std::endl;

    // Показываем статистику
    std::cout << "Dictionary size: " << GetSize() << std::endl;
    std::cout << "HashTable size: " << _hashTableRef->GetSize() << std::endl;

    return true;
}

bool Dictionary::Remove(const std::string& key)
{
    std::cout << "\n=== Dictionary Operation: Remove ===" << std::endl;
    std::cout << "Attempting to remove key: '" << key << "'" << std::endl;

    bool dictHasKey = HasKey(key);

    if (dictHasKey)
    {
        // Удаляем из словаря
        _data.erase(key);
        std::cout << "Dictionary: Key '" << key << "' was found and removed." << std::endl;
    }
    else
    {
        std::cout << "Dictionary: Key '" << key << "' was NOT found." << std::endl;
    }

    // Удаляем только одно вхождение из хеш-таблицы
    bool hashTableRemoved = _hashTableRef->Remove(key);

    if (hashTableRemoved)
    {
        std::cout << "HashTable: Key '" << key << "' was found and removed (first occurrence)." << std::endl;
    }
    else
    {
        std::cout << "HashTable: Key '" << key << "' was NOT found." << std::endl;
    }

    // Показываем статистику
    std::cout << "Dictionary size: " << GetSize() << std::endl;
    std::cout << "HashTable size: " << _hashTableRef->GetSize() << std::endl;

    return dictHasKey;
}

std::string Dictionary::Find(const std::string& key) const
{
    std::cout << "\n=== Dictionary Operation: Find ===" << std::endl;
    std::cout << "Searching for key: '" << key << "'" << std::endl;

    auto it = _data.find(key);
    if (it != _data.end())
    {
        std::cout << "Dictionary: Key '" << key << "' found. Value: " << it->second << std::endl;

        // Также ищем в хеш-таблице для сравнения
        std::string hashTableResult = _hashTableRef->Find(key);
        std::cout << "HashTable: Key '" << key << "' found. Value: " << hashTableResult << std::endl;

        return it->second;
    }
    else
    {
        std::cout << "Dictionary: Key '" << key << "' NOT found." << std::endl;

        // Проверяем хеш-таблицу
        std::string hashTableResult = _hashTableRef->Find(key);
        if (!hashTableResult.empty())
        {
            std::cout << "HashTable: Key '" << key << "' found (but not in Dictionary - may be a duplicate). Value: " << hashTableResult << std::endl;
        }
        else
        {
            std::cout << "HashTable: Key '" << key << "' NOT found." << std::endl;
        }

        return "";
    }
}

bool Dictionary::HasKey(const std::string& key) const
{
    return _data.find(key) != _data.end();
}

void Dictionary::Display() const
{
    std::cout << "\n=== Dictionary State ===" << std::endl;
    std::cout << "Total entries: " << GetSize() << std::endl;

    for (const auto& pair : _data)
    {
        std::cout << "[" << pair.first << "]: " << pair.second << std::endl;
    }
}

int Dictionary::GetSize() const
{
    return _data.size();
}

void Dictionary::Clear()
{
    std::cout << "\n=== Dictionary Operation: Clear ===" << std::endl;
    std::cout << "Clearing Dictionary..." << std::endl;

    _data.clear();

    std::cout << "Dictionary: Cleared." << std::endl;
    // Хеш-таблицу не очищаем, чтобы показать разницу
}

std::vector<std::pair<std::string, std::string>> Dictionary::GetAllPairs() const
{
    std::vector<std::pair<std::string, std::string>> result;
    result.reserve(_data.size());

    for (const auto& pair : _data)
    {
        result.push_back(pair);
    }

    return result;
}