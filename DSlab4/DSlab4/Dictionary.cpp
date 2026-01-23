#include "Dictionary.h"

/// <summary>
/// Добавляет новую пару "ключ-значение" в словарь.
/// Если ключ уже существует, добавление отклоняется.
/// </summary>
/// <param name="key">Ключ для добавления.</param>
/// <param name="value">Значение, связанное с ключом.</param>
void Dictionary::add(const std::string& key, const std::string& value)
{
    std::string existingValue;
    if (hashTable.find(key, existingValue))
    {
        std::cout << "[Error] Key '" << key << "' already exists. Cannot add duplicate." << std::endl;
        return;
    }
    hashTable.insert(key, value);
    std::cout << "[OK] Added: " << key << " -> " << value << std::endl;
}

/// <summary>
/// Удаляет запись по указанному ключу из словаря.
/// </summary>
/// <param name="key">Ключ для удаления.</param>
/// <returns>true, если ключ был найден и удалён; иначе false.</returns>
bool Dictionary::remove(const std::string& key)
{
    bool result = hashTable.remove(key);
    if (result)
    {
        std::cout << "[OK] Removed key: " << key << std::endl;
    }
    else
    {
        std::cout << "[Error] Key not found: " << key << std::endl;
    }
    return result;
}

/// <summary>
/// Ищет значение по заданному ключу.
/// </summary>
/// <param name="key">Ключ для поиска.</param>
/// <param name="value">Сюда будет записано найденное значение (если найдено).</param>
/// <returns>true, если ключ найден; иначе false.</returns>
bool Dictionary::find(const std::string& key, std::string& value) const
{
    bool result = hashTable.find(key, value);
    if (result)
    {
        std::cout << "[OK] Found: " << key << " -> " << value << std::endl;
    }
    else
    {
        std::cout << "[Error] Key not found: " << key << std::endl;
    }
    return result;
}

/// <summary>
/// Выводит текущее состояние словаря (включая количество записей и содержимое).
/// </summary>
void Dictionary::display() const
{
    std::cout << "=== Dictionary State ===" << std::endl;
    std::cout << "Total entries: " << hashTable.getSize() << std::endl;
    hashTable.display();
}

/// <summary>
/// Очищает словарь (в текущей реализации выводится информационное сообщение).
/// </summary>
void Dictionary::clear()
{
    std::cout << "[Info] Dictionary cleared." << std::endl;
}