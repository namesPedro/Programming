#include <iostream>
#include <limits>
#include "../Header Files/DynamicArray.h"

// Константы для меню
const int EXIT_OPTION = 0;
const int REMOVE_BY_INDEX_OPTION = 1;
const int REMOVE_BY_VALUE_OPTION = 2;
const int INSERT_AT_BEGINNING_OPTION = 3;
const int INSERT_AT_END_OPTION = 4;
const int INSERT_AFTER_ELEMENT_OPTION = 5;
const int SORT_ARRAY_OPTION = 6;
const int LINEAR_SEARCH_OPTION = 7;
const int BINARY_SEARCH_OPTION = 8;
const int PRINT_ARRAY_OPTION = 9;

/// <summary>
/// Выводит содержимое динамического массива в консоль.
/// Форматирует вывод с разделителями-запятыми между элементами.
/// </summary>
/// <param name="array">Ссылка на объект DynamicArray для вывода</param>
void PrintArray(DynamicArray& array)
{
    if (array.GetSize() == 0) {
        std::cout << "Array is empty" << std::endl;
        return;
    }

    for (int i = 0; i < array.GetSize(); i++) {
        std::cout << array.GetElement(i);
        if (i < array.GetSize() - 1) {
            std::cout << ", ";
        }
    }
    std::cout << std::endl;
}

/// <summary>
/// Отображает главное меню приложения с текущим состоянием массива.
/// Показывает все доступные операции с динамическим массивом.
/// </summary>
/// <param name="array">Ссылка на объект DynamicArray для отображения текущего состояния</param>
void DisplayMenu(DynamicArray& array)
{
    std::cout << "Laboratory Work #1 - Dynamic Array" << std::endl;
    std::cout << "Current array: ";
    PrintArray(array);
    std::cout << std::endl;

    std::cout << "Select the action you want to do:" << std::endl;
    std::cout << "1. Remove an element by index from an array" << std::endl;
    std::cout << "2. Remove an element by value from an array" << std::endl;
    std::cout << "3. Insert an element at the beginning" << std::endl;
    std::cout << "4. Insert an element at the end" << std::endl;
    std::cout << "5. Insert after a certain element" << std::endl;
    std::cout << "6. Sort array" << std::endl;
    std::cout << "7. Linear search for an element in an array" << std::endl;
    std::cout << "8. Binary search for an element in an array" << std::endl;
    std::cout << "9. Print array" << std::endl;
    std::cout << "0. Exit" << std::endl;
    std::cout << "Your input: ";
}

/// <summary>
/// Получает и проверяет ввод пользователя на корректность.
/// Защищает от некорректного ввода и очищает буфер ввода.
/// </summary>
/// <param name="prompt">Текст приглашения для ввода</param>
/// <returns>Корректное целочисленное значение, введенное пользователем</returns>
int GetValidatedInput(const std::string& prompt)
{
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
/// Главная функция приложения.
/// Реализует интерактивное меню для работы с динамическим массивом.
/// Обрабатывает пользовательский ввод и выполняет соответствующие операции.
/// </summary>
/// <returns>Код завершения программы</returns>
int main()
{
    // TODO: использовать указатель *
    std::unique_ptr<DynamicArray> array = std::make_unique<DynamicArray>();
    bool running = true;

    // Инициализация массива тестовыми данными
    array->InsertAtEnd(12);
    array->InsertAtEnd(3);
    array->InsertAtEnd(8);
    array->InsertAtEnd(25);

    // Главный цикл приложения
    while (running) {
        DisplayMenu(*array);

        int choice = GetValidatedInput("");

        try {
            switch (choice) {
            case EXIT_OPTION:
                running = false;
                std::cout << "Goodbye!" << std::endl;
                break;

            case REMOVE_BY_INDEX_OPTION: {
                int index = GetValidatedInput("Enter index to remove: ");
                array->RemoveByIndex(index);
                std::cout << "Element removed successfully." << std::endl;
                break;
            }

            case REMOVE_BY_VALUE_OPTION: {
                int value = GetValidatedInput("Enter value to remove: ");
                array->RemoveByValue(value);
                std::cout << "Element removed successfully." << std::endl;
                break;
            }

            case INSERT_AT_BEGINNING_OPTION: {
                int value = GetValidatedInput("Enter value to insert at beginning: ");
                array->InsertAtBeginning(value);
                std::cout << "Element inserted successfully." << std::endl;
                break;
            }

            case INSERT_AT_END_OPTION: {
                int value = GetValidatedInput("Enter value to insert at end: ");
                array->InsertAtEnd(value);
                std::cout << "Element inserted successfully." << std::endl;
                break;
            }

            case INSERT_AFTER_ELEMENT_OPTION: {
                int afterValue = GetValidatedInput("Enter value after which to insert: ");
                int value = GetValidatedInput("Enter value to insert: ");
                array->InsertAfterElement(afterValue, value);
                std::cout << "Element inserted successfully." << std::endl;
                break;
            }

            case SORT_ARRAY_OPTION:
                array->SortArray();
                std::cout << "Array sorted successfully." << std::endl;
                break;

            case LINEAR_SEARCH_OPTION: {
                int value = GetValidatedInput("Enter value to search: ");
                int index = array->LinearSearch(value);
                if (index != -1) {
                    std::cout << "Element found at index: " << index << std::endl;
                }
                else {
                    std::cout << "Element not found." << std::endl;
                }
                break;
            }

            case BINARY_SEARCH_OPTION: {
                int value = GetValidatedInput("Enter value to search: ");
                int index = array->BinarySearch(value);
                if (index != -1) {
                    std::cout << "Element found at index: " << index << std::endl;
                }
                else {
                    std::cout << "Element not found." << std::endl;
                }
                break;
            }

            case PRINT_ARRAY_OPTION:
                std::cout << "Current array: ";
                PrintArray(*array);
                break;

            default:
                std::cout << "Unknown command. Try entering the command again" << std::endl;
                break;
            }
        }
        catch (const std::exception& e) {
            std::cout << "Error: " << e.what() << std::endl;
        }

        std::cout << std::endl;
    }

    return 0;
}