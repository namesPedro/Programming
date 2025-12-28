#pragma once
#ifndef HASHTABLE_H
#define HASHTABLE_H

#include "KeyValuePair.h"

class HashTable {
private:
    KeyValuePair* table;
    int capacity;
    int size;
    const double LOAD_FACTOR_THRESHOLD = 0.7;

    // Прямой метод Пирсона для строки
    int pearsonHash(const std::string& key, int tableSize) const;

    // Вторая хеш-функция для двойного хеширования
    int hash2(const std::string& key) const;

    // Поиск индекса для вставки/поиска
    int findIndex(const std::string& key, bool forInsert) const;

    // Перехеширование
    void rehash();

public:
    HashTable(int initialCapacity = 16);
    ~HashTable();

    bool insert(const std::string& key, const std::string& value);
    bool find(const std::string& key, std::string& value) const;
    bool remove(const std::string& key);
    void display() const;

    int getSize() const { return size; }
    int getCapacity() const { return capacity; }
    double getLoadFactor() const { return (double)size / capacity; }
};

#endif