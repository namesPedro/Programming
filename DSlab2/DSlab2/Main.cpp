#include <iostream>
#include <limits>
#include "List.h"

// Константы для меню
const int EXIT_OPTION = 9;
const int REMOVE_BY_INDEX_OPTION = 1;
const int REMOVE_BY_VALUE_OPTION = 2;
const int INSERT_AT_BEGINNING_OPTION = 3;
const int INSERT_AT_END_OPTION = 4;
const int INSERT_AFTER_ELEMENT_OPTION = 5;
const int INSERT_BEFORE_ELEMENT_OPTION = 6;
const int SORT_LIST_OPTION = 7;
const int LINEAR_SEARCH_OPTION = 8;

/// <summary>
/// Получает валидный числовой ввод от пользователя
/// </summary>
/// <param name="prompt">Сообщение для пользователя</param>
/// <returns>Введенное число</returns>
int GetValidatedInput(const std::string& prompt) {
    int value;
    while (true) {
        std::cout << prompt;
        std::cin >> value;

        if (std::cin.fail()) {
            std::cin.clear();
            std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
            std::cout << "Invalid input. Please enter a number." << std::endl;
        }
        else {
            std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
            return value;
        }
    }
}

/// <summary>
/// Выводит главное меню приложения для работы с двусвязным списком.
/// Отображает все доступные операции и текущее состояние списка.
/// </summary>
void printMenu(const List& list) {
    std::cout << "\nLaboratory Work #2 - Doubly Linked List\n";
    std::cout << "Current list: ";
    list.Print();
    std::cout << "\nSelect the action you want to do:\n";
    std::cout << REMOVE_BY_INDEX_OPTION << ". Remove an element by index from a list\n";
    std::cout << REMOVE_BY_VALUE_OPTION << ". Remove an element by value from a list\n";
    std::cout << INSERT_AT_BEGINNING_OPTION << ". Insert an element at the beginning\n";
    std::cout << INSERT_AT_END_OPTION << ". Insert an element at the end\n";
    std::cout << INSERT_AFTER_ELEMENT_OPTION << ". Insert after a certain element\n";
    std::cout << INSERT_BEFORE_ELEMENT_OPTION << ". Insert before a certain element\n";
    std::cout << SORT_LIST_OPTION << ". Sort list\n";
    std::cout << LINEAR_SEARCH_OPTION << ". Linear search for an element in a list\n";
    std::cout << EXIT_OPTION << ". Exit\n";
    std::cout << "Your input: ";
}

/// <summary>
/// Главная функция приложения для работы с двусвязным списком.
/// Реализует интерактивное меню для выполнения операций со списком.
/// Обрабатывает пользовательский ввод и выполняет соответствующие операции.
/// </summary>
/// <returns>Код завершения программы</returns>
int main() {
    List list;
    int choice = 0;

    // Начальное заполнение списка для примера
    list.AddToEnd(new Node(55));
    list.AddToEnd(new Node(7));
    list.AddToEnd(new Node(1));
    list.AddToEnd(new Node(3));

    /// <summary>
    /// Главный цикл приложения
    /// </summary>
    while (choice != EXIT_OPTION) {
        printMenu(list);
        choice = GetValidatedInput("");

        // Обработка выбора пользователя
        switch (choice) {
        case REMOVE_BY_INDEX_OPTION: {
            int index = GetValidatedInput("Enter index to remove: ");
            if (list.RemoveNodeByIndex(index)) {
                std::cout << "Element removed successfully.\n";
            }
            else {
                std::cout << "Failed to remove element. Invalid index.\n";
            }
            break;
        }
        case REMOVE_BY_VALUE_OPTION: {
            int value = GetValidatedInput("Enter value to remove: ");
            if (list.RemoveNodeByValue(value)) {
                std::cout << "Element removed successfully.\n";
            }
            else {
                std::cout << "Element not found.\n";
            }
            break;
        }
        case INSERT_AT_BEGINNING_OPTION: {
            int value = GetValidatedInput("Enter value to insert at the beginning: ");
            list.AddToFront(new Node(value));
            std::cout << "Element added.\n";
            break;
        }
        case INSERT_AT_END_OPTION: {
            int value = GetValidatedInput("Enter value to insert at the end: ");
            list.AddToEnd(new Node(value));
            std::cout << "Element added.\n";
            break;
        }
        case INSERT_AFTER_ELEMENT_OPTION: {
            int newValue = GetValidatedInput("Enter value to insert: ");
            int targetValue = GetValidatedInput("Enter value after which to insert: ");
            if (list.InsertAfter(new Node(newValue), targetValue)) {
                std::cout << "Element inserted successfully.\n";
            }
            else {
                std::cout << "Target value not found.\n";
            }
            break;
        }
        case INSERT_BEFORE_ELEMENT_OPTION: {
            int newValue = GetValidatedInput("Enter value to insert: ");
            int targetValue = GetValidatedInput("Enter value before which to insert: ");
            if (list.InsertBefore(new Node(newValue), targetValue)) {
                std::cout << "Element inserted successfully.\n";
            }
            else {
                std::cout << "Target value not found.\n";
            }
            break;
        }
        case SORT_LIST_OPTION: {
            list.Sort();
            std::cout << "List sorted successfully.\n";
            break;
        }
        case LINEAR_SEARCH_OPTION: {
            int value = GetValidatedInput("Enter value to search for: ");
            Node* found = list.FindNodeByValue(value);
            if (found != nullptr) {
                std::cout << "Value " << value << " found in the list.\n";
            }
            else {
                std::cout << "Value " << value << " not found.\n";
            }
            break;
        }
        case EXIT_OPTION: {
            std::cout << "Exiting...\n";
            break;
        }
        default: {
            std::cout << "Invalid choice. Please try again.\n";
            break;
        }
        }
    }

    return 0;
}