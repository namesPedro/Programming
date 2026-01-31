#include "Dictionary.h"
#include "HashTable.h"
#include <iostream>

Dictionary::Dictionary(HashTable& hashTable) : _hashTableRef(&hashTable)
{
}

bool Dictionary::Add(const std::string& key, const std::string& value)
{
    if (HasKey(key))
    {
        std::cout << "Dictionary: Error! Key '" << key << "' already exists. Key NOT added to Dictionary." << std::endl;

        _hashTableRef->Insert(key, value);
        std::cout << "HashTable: Key '" << key << "' added." << std::endl;

        return false;
    }

    _data[key] = value;

    _hashTableRef->Insert(key, value);

    std::cout << "Dictionary: Key '" << key << "' added." << std::endl;
    std::cout << "HashTable: Key '" << key << "' added." << std::endl;

    return true;
}

bool Dictionary::Remove(const std::string& key)
{
    bool dictHasKey = HasKey(key);

    if (dictHasKey)
    {
        _data.erase(key);
        std::cout << "Dictionary: Key '" << key << "' was found and removed." << std::endl;
    }
    else
    {
        std::cout << "Dictionary: Key '" << key << "' was NOT found." << std::endl;
    }

    bool hashTableRemoved = _hashTableRef->Remove(key);

    if (hashTableRemoved)
    {
        std::cout << "HashTable: Key '" << key << "' was found and removed (first occurrence)." << std::endl;
    }
    else
    {
        std::cout << "HashTable: Key '" << key << "' was NOT found." << std::endl;
    }

    return dictHasKey;
}

std::string Dictionary::Find(const std::string& key) const
{
    auto it = _data.find(key);
    if (it != _data.end())
    {
        std::cout << "Dictionary: Key '" << key << "' found. Value: " << it->second << std::endl;

        std::string hashTableResult = _hashTableRef->Find(key);
        std::cout << "HashTable: Key '" << key << "' found. Value: " << hashTableResult << std::endl;

        return it->second;
    }
    else
    {
        std::cout << "Dictionary: Key '" << key << "' NOT found." << std::endl;

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

int Dictionary::GetSize() const
{
    return _data.size();
}

void Dictionary::Clear()
{
    _data.clear();

    std::cout << "Dictionary: Cleared." << std::endl;
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