#include <iostream>
#include <limits>
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

void DemonstrationScenarios(Dictionary& dict, HashTable& hashTable)
{
    std::cout << "\n=== Demonstration Scenarios ===" << std::endl;

    // 1. Добавление нескольких пар
    std::cout << "\n1. Adding multiple key-value pairs..." << std::endl;
    dict.Add("name", "John");
    dict.Add("age", "25");
    dict.Add("city", "New York");
    dict.Add("address", "My Street");

    // 2. Удаление
    std::cout << "\n2. Removing 'age'..." << std::endl;
    dict.Remove("age");

    // 3. Поиск
    std::cout << "\n3. Finding 'city'..." << std::endl;
    std::string value = dict.Find("city");

    // 4. Попытка добавления дублирующего ключа (разные результаты для Dictionary и HashTable)
    std::cout << "\n4. Attempting to add duplicate key 'name'..." << std::endl;
    dict.Add("name", "Alice");  // В словаре не добавится, в хеш-таблицу добавится

    // 5. Добавление еще одного дубликата для демонстрации
    std::cout << "\n5. Adding another duplicate key 'name'..." << std::endl;
    dict.Add("name", "Bob");  // В словаре не добавится, в хеш-таблицу добавится

    // 6. Поиск ключа с дубликатами
    std::cout << "\n6. Finding 'name'..." << std::endl;
    dict.Find("name");

    // 7. Показать разницу в размерах
    std::cout << "\n7. Showing size difference between Dictionary and HashTable..." << std::endl;
    std::cout << "Dictionary size (unique keys): " << dict.GetSize() << std::endl;
    std::cout << "HashTable size (all pairs): " << hashTable.GetSize() << std::endl;

    // 8. Добавление до перехеширования
    std::cout << "\n8. Adding elements until rehash..." << std::endl;
    for (int i = 0; i < 20; i++)
    {
        dict.Add("key" + std::to_string(i), "value" + std::to_string(i));
    }

    // 9. Добавление дубликатов для новых ключей
    std::cout << "\n9. Adding duplicates for some keys..." << std::endl;
    dict.Add("key1", "duplicate1");
    dict.Add("key5", "duplicate5");
    dict.Add("key10", "duplicate10");

    // 10. Удаление элементов с дубликатами
    std::cout << "\n10. Removing elements that have duplicates..." << std::endl;
    dict.Remove("key5");
    dict.Remove("key10");

    // 11. Отображение финального состояния
    std::cout << "\n11. Final state:" << std::endl;
    dict.Display();
    hashTable.Display();
}

/// <summary>
/// Получает валидный числовой ввод от пользователя.
/// </summary>
/// <param name="prompt">Сообщение для пользователя</param>
/// <returns>Введенное число</returns>
int GetValidatedInput(const std::string& prompt)
{
    int value;
    while (true)
    {
        std::cout << prompt;
        std::cin >> value;

        if (std::cin.fail())
        {
            std::cin.clear();
            std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
            std::cout << "Invalid input. Please enter a number." << std::endl;
        }
        else
        {
            std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
            return value;
        }
    }
}

int main()
{
    HashTable hashTable;

    Dictionary dict(hashTable);

    int choice;

    std::cout << "==========================================" << std::endl;
    std::cout << "Dictionary and HashTable Demo Program" << std::endl;
    std::cout << "==========================================" << std::endl;
    std::cout << "Key differences:" << std::endl;
    std::cout << "- Dictionary: Unique keys only, stores data separately" << std::endl;
    std::cout << "- HashTable: Allows duplicate keys, stores all operations" << std::endl;
    std::cout << "==========================================" << std::endl;

    do
    {
        DisplayMenu();
        choice = GetValidatedInput("");

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
            dict.Remove(key);
            break;
        }
        case MenuFind:
        {
            std::string key;
            std::cout << "Enter key to find: ";
            std::getline(std::cin, key);
            dict.Find(key);
            break;
        }
        case MenuDisplay:
            dict.Display();
            hashTable.Display();
            break;
        case MenuClear:
            dict.Clear();
            break;
        case MenuDemo:
            DemonstrationScenarios(dict, hashTable);
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