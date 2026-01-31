#include "HashTable.h"
#include <iostream>
#include <algorithm>

const unsigned char HashTable::_pearsonTable[256] =
{
    50, 5, 212, 193, 135, 180, 20, 100, 82, 112, 7, 126, 190, 19, 237, 92, 166, 75, 173, 96,
    134, 86, 60, 198, 194, 136, 238, 21, 3, 59, 26, 174, 27, 171, 203, 14, 253, 65, 214, 188,
    4, 165, 247, 228, 133, 101, 74, 6, 183, 52, 250, 38, 217, 141, 123, 172, 46, 91, 111, 69,
    8, 67, 204, 110, 109, 151, 210, 93, 168, 34, 40, 83, 118, 10, 164, 25, 231, 249, 197, 227,
    246, 152, 9, 225, 31, 42, 148, 121, 144, 77, 234, 57, 68, 73, 22, 39, 147, 64, 113, 90,
    149, 103, 139, 37, 236, 219, 235, 157, 70, 160, 16, 48, 15, 89, 209, 80, 78, 18, 43, 185,
    181, 218, 243, 119, 155, 120, 28, 35, 140, 254, 179, 137, 62, 199, 211, 95, 84, 143, 32, 24,
    221, 159, 116, 241, 242, 186, 129, 163, 29, 131, 207, 153, 106, 79, 229, 167, 142, 81, 71, 108,
    162, 44, 187, 170, 117, 224, 76, 158, 47, 156, 213, 177, 13, 230, 191, 232, 56, 98, 245, 23,
    200, 99, 115, 202, 195, 105, 150, 0, 248, 114, 255, 41, 53, 58, 61, 154, 182, 196, 240, 176,
    124, 178, 30, 104, 223, 54, 2, 146, 138, 130, 94, 87, 215, 55, 127, 201, 206, 66, 1, 145,
    122, 63, 175, 161, 216, 244, 88, 192, 107, 51, 97, 33, 208, 184, 45, 169, 205, 11, 220, 72,
    252, 222, 85, 12, 125, 226, 36, 233, 239, 132, 189, 128, 49, 102, 17, 251
};

int HashTable::HashFunction(const std::string& key) const
{
    unsigned char hash = 0;
    for (char c : key)
    {
        hash = _pearsonTable[hash ^ static_cast<unsigned char>(c)];
    }
    return hash % _capacity;
}

HashTable::HashTable()
{
    _capacity = 16;
    _size = 0;
    _buckets.resize(_capacity);
}

HashTable::HashTable(const HashTable& other)
    : _capacity(other._capacity), _size(other._size), _buckets(other._buckets)
{
}

HashTable& HashTable::operator=(const HashTable& other)
{
    if (this != &other)
    {
        _capacity = other._capacity;
        _size = other._size;
        _buckets = other._buckets;
    }
    return *this;
}

HashTable::~HashTable()
{
    _buckets.clear();
}

bool HashTable::Insert(const std::string& key, const std::string& value)
{
    int index = HashFunction(key);
    _buckets[index].push_back(KeyValuePair(key, value));
    _size++;

    double loadFactor = static_cast<double>(_size) / _capacity;

    if (loadFactor > LoadFactorThreshold) Rehash();

    return true;
}

bool HashTable::Remove(const std::string& key)
{
    int index = HashFunction(key);
    for (auto it = _buckets[index].begin(); it != _buckets[index].end(); ++it)
    {
        if (it->GetKey() == key)
        {
            _buckets[index].erase(it);
            _size--;
            return true;
        }
    }
    return false;
}

std::string HashTable::Find(const std::string& key) const
{
    int index = HashFunction(key);
    for (const auto& pair : _buckets[index])
    {
        if (pair.GetKey() == key)
        {
            return pair.GetValue();
        }
    }
    return "";
}

int HashTable::GetSize() const
{
    return _size;
}

int HashTable::GetUniqueKeyCount() const
{
    std::vector<std::string> uniqueKeys;

    for (const auto& bucket : _buckets)
    {
        for (const auto& pair : bucket)
        {
            std::string key = pair.GetKey();
            if (std::find(uniqueKeys.begin(), uniqueKeys.end(), key) == uniqueKeys.end())
            {
                uniqueKeys.push_back(key);
            }
        }
    }

    return uniqueKeys.size();
}

int HashTable::GetCapacity() const
{
    return _capacity;
}

void HashTable::Rehash()
{
    int oldCapacity = _capacity;
    int newCapacity = _capacity * 2;
    std::vector<std::vector<KeyValuePair>> newBuckets(newCapacity);

    for (const auto& bucket : _buckets)
    {
        for (const auto& pair : bucket)
        {
            unsigned char hash = 0;
            std::string key = pair.GetKey();
            for (char c : key)
            {
                hash = _pearsonTable[hash ^ static_cast<unsigned char>(c)];
            }
            int newIndex = hash % newCapacity;
            newBuckets[newIndex].push_back(pair);
        }
    }

    _buckets = std::move(newBuckets);
    _capacity = newCapacity;

    std::cout << "HashTable: Rehash completed. New capacity: " << _capacity << std::endl;
}

const std::vector<std::vector<KeyValuePair>>& HashTable::GetBuckets() const
{
    return _buckets;
}