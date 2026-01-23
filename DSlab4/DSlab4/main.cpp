#include <iostream>
#include "Dictionary.h"
#include "HashTable.h"

// Константы меню
const int MenuAdd = 1;
const int MenuRemove = 2;
const int MenuFind = 3;
const int MenuDisplay = 4;
const int MenuClear = 5;
const int MenuDemo = 6;
const int MenuExit = 7;

void DisplayMenu()
{
    std::cout << "\n=== Dictionary Main Menu ===" << std::endl;
    std::cout << MenuAdd << ". Add key-value pair" << std::endl;
    std::cout << MenuRemove << ". Remove by key" << std::endl;
    std::cout << MenuFind << ". Find value by key" << std::endl;
    std::cout << MenuDisplay << ". Display current state" << std::endl;
    std::cout << MenuClear << ". Clear dictionary" << std::endl;
    std::cout << MenuDemo << ". Demonstration scenarios" << std::endl;
    std::cout << MenuExit << ". Exit" << std::endl;
    std::cout << "Choice: ";
}

void DemonstrationScenarios(Dictionary& dict)
{
    std::cout << "\n=== Demonstration Scenarios ===" << std::endl;

    // 1. Добавление нескольких пар
    std::cout << "1. Adding multiple key-value pairs..." << std::endl;
    dict.Add("name", "John");
    dict.Add("age", "25");
    dict.Add("city", "New York");
    dict.Add("address", "My Street");

    // 2. Удаление
    std::cout << "2. Removing 'age'..." << std::endl;
    dict.Remove("age");

    // 3. Поиск
    std::cout << "3. Finding 'city'..." << std::endl;
    std::string value = dict.Find("city");
    std::cout << "Found: " << value << std::endl;

    // 4. Попытка добавления дублирующего ключа
    std::cout << "4. Attempting to add duplicate key 'name'..." << std::endl;
    dict.Add("name", "Alice");

    // 5. Добавление до перехеширования
    std::cout << "5. Adding elements until rehash..." << std::endl;
    for (int i = 0; i < 20; i++)
    {
        dict.Add("key" + std::to_string(i), "value" + std::to_string(i));
    }

    // 6. Удаление элементов
    std::cout << "6. Removing some elements..." << std::endl;
    dict.Remove("key5");
    dict.Remove("key10");
}

int main()
{
    Dictionary dict;
    int choice;

    do
    {
        DisplayMenu();
        std::cin >> choice;
        std::cin.ignore();

        switch (choice)
        {
        case MenuAdd:
        {
            std::string key, value;
            std::cout << "Enter key: ";
            std::getline(std::cin, key);
            std::cout << "Enter value: ";
            std::getline(std::cin, value);
            dict.Add(key, value);
            break;
        }
        case MenuRemove:
        {
            std::string key;
            std::cout << "Enter key to remove: ";
            std::getline(std::cin, key);
            if (dict.Remove(key))
                std::cout << "Key removed." << std::endl;
            else
                std::cout << "Key not found." << std::endl;
            break;
        }
        case MenuFind:
        {
            std::string key;
            std::cout << "Enter key to find: ";
            std::getline(std::cin, key);
            std::string result = dict.Find(key);
            if (!result.empty())
                std::cout << "Value: " << result << std::endl;
            else
                std::cout << "Key not found." << std::endl;
            break;
        }
        case MenuDisplay:
            dict.Display();
            dict.GetHashTable().Display();
            break;
        case MenuClear:
            dict.Clear();
            std::cout << "Dictionary cleared." << std::endl;
            break;
        case MenuDemo:
            DemonstrationScenarios(dict);
            break;
        case MenuExit:
            std::cout << "Exiting..." << std::endl;
            break;
        default:
            std::cout << "Invalid choice." << std::endl;
        }
    } while (choice != MenuExit);

    return 0;
}