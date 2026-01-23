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