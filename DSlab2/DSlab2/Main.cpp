#include <iostream>
#include <limits>
#include <vector>
#include <fstream>
#include <chrono>
#include <filesystem>

#include "Node.h"
#include "List.h" 
#include "DynamicArray.h"
#include "PerformanceTester.h"

/// <summary>
/// Сохраняет результаты измерений в текстовый файл в подкаталоге Measures.
/// </summary>
/// <param name="results">Вектор результатов измерений</param>
/// <param name="filename">Имя выходного TXT файла</param>
void SaveToTXT(MeasureResult* results, int count, const std::string& filename) {
    std::ofstream file("Measures/" + filename);
    if (!file.is_open()) {
        std::cout << "Error: Could not open file " << filename << std::endl;
        return;
    }

    for (int i = 0; i < count; i++) {
        file << results[i].size << " "
            << results[i].listTime << " "
            << results[i].arrayTime << "\n";
    }

    file.close();
    std::cout << "Saved to Measures/" << filename << std::endl;
}


/// <summary>
/// Запускает сравнительное тестирование производительности для двух структур данных.
/// Тестируются только основные операции вставки и удаления из разных позиций.
/// Результаты сохраняются в TXT файлы в подкаталоге Measures для последующего построения графиков.
/// </summary>
void RunPerformanceTests() {
    std::cout << "=== PERFORMANCE TESTING STARTED ===" << std::endl;

    // Статический массив размеров (как теперь требуется)
    const int sizes[] = { 100, 500, 1000, 2000, 5000, 10000 };
    const int sizeCount = sizeof(sizes) / sizeof(sizes[0]);

    // Временный буфер для результатов
    MeasureResult results[16];

    // ---- Insert At Beginning ----
    std::cout << "\n=== Testing Insert At Beginning ===" << std::endl;
    int n1 = PerformanceTester::MeasureInsertAtBeginning(sizes, sizeCount, results);
    SaveToTXT(results, n1, "InsertAtBeginning.txt");

    // ---- Insert At End ----
    std::cout << "\n=== Testing Insert At End ===" << std::endl;
    int n2 = PerformanceTester::MeasureInsertAtEnd(sizes, sizeCount, results);
    SaveToTXT(results, n2, "InsertAtEnd.txt");

    // ---- Insert At Middle ----
    std::cout << "\n=== Testing Insert At Middle ===" << std::endl;
    int n3 = PerformanceTester::MeasureInsertAtMiddle(sizes, sizeCount, results);
    SaveToTXT(results, n3, "InsertAtMiddle.txt");

    // ---- Remove From Beginning ----
    std::cout << "\n=== Testing Remove From Beginning ===" << std::endl;
    int n4 = PerformanceTester::MeasureRemoveFromBeginning(sizes, sizeCount, results);
    SaveToTXT(results, n4, "RemoveFromBeginning.txt");

    // ---- Remove From End ----
    std::cout << "\n=== Testing Remove From End ===" << std::endl;
    int n5 = PerformanceTester::MeasureRemoveFromEnd(sizes, sizeCount, results);
    SaveToTXT(results, n5, "RemoveFromEnd.txt");

    // ---- Remove From Middle ----
    std::cout << "\n=== Testing Remove From Middle ===" << std::endl;
    int n6 = PerformanceTester::MeasureRemoveFromMiddle(sizes, sizeCount, results);
    SaveToTXT(results, n6, "RemoveFromMiddle.txt");

    std::cout << "\n=== PERFORMANCE TESTING COMPLETED ===" << std::endl;
    std::cout << "TXT files created in Measures folder." << std::endl;
}


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
const int RunPerformanceTestsOption = 10;

/// <summary>
/// Получает валидный числовой ввод от пользователя.
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
    std::cout << RunPerformanceTestsOption << ". Run performance tests (for report)\n";
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
            if (list.InsertAfter(targetIndex, new Node(newValue))) {
                std::cout << "Element inserted successfully.\n";
            }
            else {
                std::cout << "Invalid index.\n";
            }
            break;
        }
        case InsertBeforeIndexOption: {
            int newValue = GetValidatedInput("Enter value to insert: ");
            int targetIndex = GetValidatedInput("Enter index before which to insert: ");
            if (list.InsertBefore(targetIndex, new Node(newValue))) {
                std::cout << "Element inserted successfully.\n";
            }
            else {
                std::cout << "Invalid index.\n";
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
        case RunPerformanceTestsOption:
        {
            RunPerformanceTests();
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