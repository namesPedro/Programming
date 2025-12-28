#include "Dictionary.h"
#include <iostream>
#include <string>

void displayMenu() {
    std::cout << "\n=== Dictionary Main Menu ===" << std::endl;
    std::cout << "1. Add key-value pair" << std::endl;
    std::cout << "2. Remove by key" << std::endl;
    std::cout << "3. Find value by key" << std::endl;
    std::cout << "4. Display current state" << std::endl;
    std::cout << "5. Clear dictionary" << std::endl;
    std::cout << "6. Demonstration scenarios" << std::endl;
    std::cout << "7. Exit" << std::endl;
    std::cout << "Choice: ";
}

void demonstration(Dictionary& dict) {
    std::cout << "\n=== Demonstration Scenarios ===" << std::endl;

    // 1. Добавление нескольких пар
    dict.add("name", "Alice");
    dict.add("age", "25");
    dict.add("city", "Moscow");
    dict.display();

    // 2. Попытка добавить дубликат
    dict.add("name", "Bob");

    // 3. Поиск
    std::string value;
    dict.find("city", value);

    // 4. Удаление
    dict.remove("age");
    dict.display();

    // 5. Добавление до перехеширования
    for (int i = 1; i <= 10; i++) {
        dict.add("key" + std::to_string(i), "value" + std::to_string(i));
    }
    dict.display();
}

int main() {
    Dictionary dict;
    int choice;
    std::string key, value;

    do {
        displayMenu();
        std::cin >> choice;
        std::cin.ignore();

        switch (choice) {
        case 1:
            std::cout << "Enter key: ";
            std::getline(std::cin, key);
            std::cout << "Enter value: ";
            std::getline(std::cin, value);
            dict.add(key, value);
            break;
        case 2:
            std::cout << "Enter key to remove: ";
            std::getline(std::cin, key);
            dict.remove(key);
            break;
        case 3:
            std::cout << "Enter key to find: ";
            std::getline(std::cin, key);
            dict.find(key, value);
            break;
        case 4:
            dict.display();
            break;
        case 5:
            dict.clear();
            break;
        case 6:
            demonstration(dict);
            break;
        case 7:
            std::cout << "Exiting..." << std::endl;
            break;
        default:
            std::cout << "Invalid choice." << std::endl;
        }
    } while (choice != 7);

    return 0;
}