#pragma once
#ifndef DICTIONARY_H
#define DICTIONARY_H

#include "HashTable.h"
#include <iostream>

class Dictionary {
private:
    HashTable hashTable;

public:
    Dictionary() : hashTable() {}

    void add(const std::string& key, const std::string& value);
    bool remove(const std::string& key);
    bool find(const std::string& key, std::string& value) const;
    void display() const;
    void clear();
};

#endif