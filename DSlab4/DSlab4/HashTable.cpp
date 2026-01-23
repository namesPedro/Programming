#include "HashTable.h"
#include <iostream>
#include <vector>

/// <summary>
/// Конструктор хеш-таблицы с заданной начальной ёмкостью.
/// </summary>
/// <param name="initialCapacity">Начальный размер таблицы.</param>
HashTable::HashTable(int initialCapacity)
{
    capacity = initialCapacity;
    size = 0;
    table = new KeyValuePair[capacity];
}

/// <summary>
/// Деструктор хеш-таблицы. Освобождает выделенную память.
/// </summary>
HashTable::~HashTable()
{
    delete[] table;
}

int HashTable::pearsonHash(const std::string& key, int tableSize) const
{
    static const unsigned char T[256] = {
        98, 6, 85, 150, 36, 23, 112, 164, 135, 207, 169, 5, 26, 64, 165, 219,
        61, 20, 68, 89, 130, 63, 52, 102, 24, 229, 132, 245, 80, 216, 195, 115,
        90, 168, 156, 203, 177, 120, 2, 190, 188, 7, 100, 185, 174, 243, 162, 10,
        237, 18, 253, 225, 8, 208, 172, 244, 255, 126, 101, 79, 145, 235, 228, 121,
        123, 251, 67, 250, 161, 0, 107, 97, 241, 111, 181, 82, 249, 33, 69, 55,
        59, 153, 29, 9, 213, 167, 84, 93, 30, 46, 94, 75, 151, 114, 73, 222,
        197, 96, 210, 45, 16, 227, 248, 202, 51, 152, 252, 125, 81, 206, 215, 186,
        39, 158, 178, 187, 131, 136, 1, 49, 50, 17, 141, 91, 47, 129, 60, 99,
        154, 35, 86, 171, 105, 34, 38, 200, 147, 58, 77, 118, 173, 246, 76, 254,
        133, 232, 196, 144, 198, 124, 53, 4, 108, 74, 223, 234, 134, 230, 157, 139,
        189, 205, 199, 128, 176, 19, 211, 236, 127, 192, 231, 70, 233, 88, 146, 44,
        183, 201, 22, 83, 13, 214, 116, 109, 159, 32, 95, 226, 140, 220, 57, 12,
        221, 31, 209, 182, 143, 92, 149, 184, 148, 62, 113, 65, 37, 27, 106, 166,
        3, 14, 204, 72, 21, 41, 56, 66, 28, 193, 40, 217, 25, 54, 179, 117,
        238, 87, 240, 155, 180, 170, 242, 212, 191, 163, 78, 218, 137, 194, 175, 110,
        43, 119, 224, 71, 122, 142, 42, 160, 104, 48, 247, 103, 15, 11, 138, 239
    };
    unsigned char hash = 0;
    for (char c : key)
    {
        hash = T[hash ^ static_cast<unsigned char>(c)];
    }
    return hash % tableSize;
}

int HashTable::hash2(const std::string& key) const
{
    int hash = 0;
    for (char c : key)
    {
        hash = (hash * 31 + c);
    }
    return (hash % (capacity - 1)) + 1;
}

int HashTable::findIndex(const std::string& key, bool forInsert) const
{
    int h1 = pearsonHash(key, capacity);
    int h2 = hash2(key);
    int index = h1;
    int i = 0;

    while (i < capacity)
    {
        if (table[index].key.empty() || table[index].isDeleted)
        {
            if (forInsert) return index;
            if (table[index].key.empty()) break;
        }
        else if (table[index].key == key)
        {
            return index;
        }
        i++;
        index = (h1 + i * h2) % capacity;
    }
    return -1;
}

void HashTable::rehash()
{
    int oldCapacity = capacity;
    KeyValuePair* oldTable = table;

    capacity *= 2;
    table = new KeyValuePair[capacity];
    size = 0;

    for (int i = 0; i < oldCapacity; i++)
    {
        if (!oldTable[i].key.empty() && !oldTable[i].isDeleted)
        {
            insert(oldTable[i].key, oldTable[i].value);
        }
    }

    delete[] oldTable;
    std::cout << "[Rehashed] New capacity: " << capacity << std::endl;
}

/// <summary>
/// Вставляет пару "ключ-значение" в хеш-таблицу. При необходимости выполняет рехеширование.
/// Если ключ уже существует, его значение обновляется.
/// </summary>
/// <param name="key">Ключ для вставки.</param>
/// <param name="value">Значение, связанное с ключом.</param>
/// <returns>true при успешной вставке или обновлении; false, если таблица полна.</returns>
bool HashTable::insert(const std::string& key, const std::string& value)
{
    if (getLoadFactor() > LOAD_FACTOR_THRESHOLD)
    {
        rehash();
    }

    int index = findIndex(key, true);
    if (index == -1) return false;

    if (table[index].key.empty() || table[index].isDeleted)
    {
        table[index] = KeyValuePair(key, value);
        size++;
    }
    else
    {
        table[index].value = value;
    }
    return true;
}

/// <summary>
/// Ищет значение по заданному ключу.
/// </summary>
/// <param name="key">Ключ для поиска.</param>
/// <param name="value">Сюда будет записано найденное значение (если найдено).</param>
/// <returns>true, если ключ найден и не помечен как удалённый; иначе false.</returns>
bool HashTable::find(const std::string& key, std::string& value) const
{
    int index = findIndex(key, false);
    if (index != -1 && !table[index].isDeleted)
    {
        value = table[index].value;
        return true;
    }
    return false;
}

/// <summary>
/// Удаляет запись по ключу (логическое удаление через флаг isDeleted).
/// </summary>
/// <param name="key">Ключ для удаления.</param>
/// <returns>true, если ключ был найден и помечен как удалённый; иначе false.</returns>
bool HashTable::remove(const std::string& key)
{
    int index = findIndex(key, false);
    if (index != -1 && !table[index].isDeleted)
    {
        table[index].isDeleted = true;
        size--;
        return true;
    }
    return false;
}

/// <summary>
/// Выводит текущее состояние хеш-таблицы (ёмкость, размер, коэффициент заполнения и содержимое).
/// </summary>
void HashTable::display() const
{
    std::cout << "=== Hash Table State ===" << std::endl;
    std::cout << "Capacity: " << capacity << std::endl;
    std::cout << "Size: " << size << std::endl;
    std::cout << "Load Factor: " << getLoadFactor() << std::endl;
    std::cout << "\nKey-value pairs:\n";
    for (int i = 0; i < capacity; i++)
    {
        std::cout << "[" << i << "]: ";
        if (table[i].key.empty())
        {
            std::cout << "EMPTY";
        }
        else if (table[i].isDeleted)
        {
            std::cout << "DELETED";
        }
        else
        {
            std::cout << "{" << table[i].key << ":" << table[i].value << "}";
        }
        std::cout << std::endl;
    }
}