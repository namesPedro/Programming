#include <iostream>
#include <limits>
#include "List.h"



// Константы для меню
const int ExitOption = 9;
const int RemoveByIndexOption = 1;
const int RemoveByValueOption = 2;
const int InsertAtBeginningOption = 3;
const int InsertAtEndOption = 4;
const int InsertAfterIndexOption = 5;
const int InsertBeforeIndexOption = 6;
const int SortListOption = 7;
const int LinearSearchOption = 8;

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
    std::cout << RemoveByIndexOption << ". Remove an element by index from a list\n";
    std::cout << RemoveByValueOption << ". Remove an element by value from a list\n";
    std::cout << InsertAtBeginningOption << ". Insert an element at the beginning\n";
    std::cout << InsertAtEndOption << ". Insert an element at the end\n";
    std::cout << InsertAfterIndexOption << ". Insert after a certain index\n";
    std::cout << InsertBeforeIndexOption << ". Insert before a certain index\n";
    std::cout << SortListOption << ". Sort list\n";
    std::cout << LinearSearchOption << ". Linear search for an element in a list\n";
    std::cout << ExitOption << ". Exit\n";
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
    while (choice != ExitOption) {
        printMenu(list);
        choice = GetValidatedInput("");

        // Обработка выбора пользователя
        switch (choice) {
        case RemoveByIndexOption: {
            int index = GetValidatedInput("Enter index to remove: ");
            if (list.RemoveNodeByIndex(index)) {
                std::cout << "Element removed successfully.\n";
            }
            else {
                std::cout << "Failed to remove element. Invalid index.\n";
            }
            break;
        }
        case RemoveByValueOption: {
            int value = GetValidatedInput("Enter value to remove: ");
            if (list.RemoveNodeByValue(value)) {
                std::cout << "Element removed successfully.\n";
            }
            else {
                std::cout << "Element not found.\n";
            }
            break;
        }
        case InsertAtBeginningOption: {
            int value = GetValidatedInput("Enter value to insert at the beginning: ");
            list.AddToFront(new Node(value));
            std::cout << "Element added.\n";
            break;
        }
        case InsertAtEndOption: {
            int value = GetValidatedInput("Enter value to insert at the end: ");
            list.AddToEnd(new Node(value));
            std::cout << "Element added.\n";
            break;
        }
        case InsertAfterIndexOption: {
            int newValue = GetValidatedInput("Enter value to insert: ");
            int targetIndex = GetValidatedInput("Enter index after which to insert: ");
            if (list.InsertAfter(new Node(newValue), targetIndex)) {
                std::cout << "Element inserted successfully.\n";
            }
            else {
                std::cout << "Target value not found.\n";
            }
            break;
        }
        case InsertBeforeIndexOption: {
            int newValue = GetValidatedInput("Enter value to insert: ");
            int targetIndex = GetValidatedInput("Enter index before which to insert: ");
            if (list.InsertBefore(new Node(newValue), targetIndex)) {
                std::cout << "Element inserted successfully.\n";
            }
            else {
                std::cout << "Target value not found.\n";
            }
            break;
        }
        case SortListOption: {
            list.Sort();
            std::cout << "List sorted successfully.\n";
            break;
        }
        case LinearSearchOption: {
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
        case ExitOption: {
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