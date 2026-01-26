#include "Dictionary.h"
#include <iostream>

bool Dictionary::Add(const std::string& key, const std::string& value)
{
    if (HasKey(key))
    {
        std::cout << "Error: Key '" << key << "' already exists. Duplicate keys are not allowed." << std::endl;
        return false;
    }
    _hashTable.Insert(key, value);
    return true;
}

bool Dictionary::Remove(const std::string& key)
{
    return _hashTable.Remove(key);
}

std::string Dictionary::Find(const std::string& key) const
{
    return _hashTable.Find(key);
}

bool Dictionary::HasKey(const std::string& key) const
{
    return !_hashTable.Find(key).empty();
}

void Dictionary::Display() const
{
    std::cout << "=== Dictionary State ===" << std::endl;
    std::cout << "Total entries: " << GetSize() << std::endl;

    auto pairs = GetAllPairs();

    for (const auto& pair : pairs)
    {
        std::cout << "[" << pair.GetKey() << "]: " << pair.GetValue() << std::endl;
    }
}

std::vector<KeyValuePair> Dictionary::GetAllPairs() const
{
    std::vector<KeyValuePair> result;

    const auto& buckets = _hashTable.GetBuckets();

    for (const auto& bucket : buckets)
    {
        for (const auto& pair : bucket)
        {
            result.push_back(pair);
        }
    }

    return result;
}

int Dictionary::GetSize() const
{
    return _hashTable.GetSize();
}

void Dictionary::Clear()
{
    _hashTable = HashTable();
}

const HashTable& Dictionary::GetHashTable() const
{
    return _hashTable;
}