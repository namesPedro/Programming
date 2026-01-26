#include "HashTable.h"
#include <iostream>

const unsigned char HashTable::_pearsonTable[256] =
{
    98, 6, 85, 150, 36, 23, 112, 164, 135, 207, 169, 5, 26, 64, 165, 219,
    61, 20, 68, 89, 130, 63, 52, 102, 24, 229, 132, 245, 80, 216, 195, 115,
    90, 168, 156, 203, 177, 120, 2, 190, 188, 7, 100, 185, 174, 243, 162,
    10, 237, 18, 253, 225, 8, 208, 172, 244, 255, 126, 101, 79, 145, 235,
    228, 121, 123, 251, 67, 250, 161, 0, 107, 97, 241, 111, 181, 82, 249,
    33, 69, 55, 59, 153, 29, 9, 213, 167, 84, 93, 30, 46, 94, 75, 151, 114,
    73, 222, 197, 96, 210, 45, 16, 227, 248, 202, 51, 152, 252, 125, 81, 173,
    220, 232, 124, 254, 60, 224, 154, 17, 122, 189, 21, 236, 119, 128, 109,
    137, 214, 158, 218, 247, 198, 234, 25, 191, 0, 223, 242, 178, 41, 1, 186,
    117, 53, 92, 131, 87, 105, 134, 143, 54, 166, 13, 129, 57, 240, 48, 88,
    212, 171, 142, 233, 110, 246, 31, 99, 28, 139, 22, 39, 78, 221, 104, 182,
    211, 147, 38, 71, 183, 127, 231, 146, 62, 163, 118, 43, 160, 209, 199,
    200, 108, 175, 140, 19, 77, 148, 103, 56, 113, 70, 4, 15, 149, 226, 37,
    11, 179, 230, 176, 74, 86, 239, 34, 201, 44, 184, 249, 65, 192, 238, 155,
    14, 35, 40, 27, 217, 32, 59, 141, 180, 42, 66, 193, 72, 83, 196, 144, 12,
    76, 138, 58, 50, 106, 47, 194, 91, 133, 49, 3, 170, 205, 187, 157, 136
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
    if (loadFactor > LoadFactorThreshold)
    {
        Rehash();
    }
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

int HashTable::GetCapacity() const
{
    return _capacity;
}

void HashTable::Rehash()
{
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
}

void HashTable::Display() const
{
    std::cout << "=== Hash Table State ===" << std::endl;
    std::cout << "Capacity: " << _capacity << std::endl;
    std::cout << "Size: " << _size << std::endl;
    std::cout << "Load Factor: " << static_cast<double>(_size) / _capacity << std::endl;
    std::cout << "Key-value pairs:" << std::endl;

    for (int i = 0; i < _capacity; i++)
    {
        std::cout << "[" << i << "]: ";
        if (_buckets[i].empty())
        {
            std::cout << "EMPTY";
        }
        else
        {
            for (size_t j = 0; j < _buckets[i].size(); j++)
            {
                std::cout << "{" << _buckets[i][j].GetKey() << ":" << _buckets[i][j].GetValue() << "}";
                if (j != _buckets[i].size() - 1) std::cout << ", ";
            }
        }
        std::cout << std::endl;
    }
}

const std::vector<std::vector<KeyValuePair>>& HashTable::GetBuckets() const
{
    return _buckets;
}