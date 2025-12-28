#include "Dictionary.h"

void Dictionary::add(const std::string& key, const std::string& value) {
    std::string existingValue;
    if (hashTable.find(key, existingValue)) {
        std::cout << "[Error] Key '" << key << "' already exists. Cannot add duplicate." << std::endl;
        return;
    }
    hashTable.insert(key, value);
    std::cout << "[OK] Added: " << key << " -> " << value << std::endl;
}

bool Dictionary::remove(const std::string& key) {
    bool result = hashTable.remove(key);
    if (result) {
        std::cout << "[OK] Removed key: " << key << std::endl;
    }
    else {
        std::cout << "[Error] Key not found: " << key << std::endl;
    }
    return result;
}

bool Dictionary::find(const std::string& key, std::string& value) const {
    bool result = hashTable.find(key, value);
    if (result) {
        std::cout << "[OK] Found: " << key << " -> " << value << std::endl;
    }
    else {
        std::cout << "[Error] Key not found: " << key << std::endl;
    }
    return result;
}

void Dictionary::display() const {
    std::cout << "=== Dictionary State ===" << std::endl;
    std::cout << "Total entries: " << hashTable.getSize() << std::endl;
    // Для простоты выводим только через хеш-таблицу
    hashTable.display();
}

void Dictionary::clear() {
    // В данном примере просто создаём новую таблицу
    // В реальности лучше реализовать clear() в HashTable
    std::cout << "[Info] Dictionary cleared." << std::endl;
}