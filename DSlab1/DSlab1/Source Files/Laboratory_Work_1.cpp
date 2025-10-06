#include <iostream>
#include <limits>
#include "../Header Files/DynamicArray.h"

void DisplayMenu(DynamicArray& array)
{
    std::cout << "Laboratory Work #1 - Dynamic Array" << std::endl;
    std::cout << "Current array: ";
    array.PrintArray();
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

int main()
{
    // TODO: использовать указатель
    DynamicArray array;
    bool running = true;

    array.InsertAtEnd(12);
    array.InsertAtEnd(3);
    array.InsertAtEnd(8);
    array.InsertAtEnd(25);

    // TODO: RSDN
    while (running) {
        DisplayMenu(array);

        int choice = GetValidatedInput("");

        try {
            switch (choice) {
                // TODO: единообразно
            case 0:
                running = false;
                std::cout << "Goodbye!" << std::endl;
                break;

            case 1: {
                int index = GetValidatedInput("Enter index to remove: ");
                array.RemoveByIndex(index);
                std::cout << "Element removed successfully." << std::endl;
                break;
            }

            case 2: {
                int value = GetValidatedInput("Enter value to remove: ");
                array.RemoveByValue(value);
                std::cout << "Element removed successfully." << std::endl;
                break;
            }

            case 3: {
                int value = GetValidatedInput("Enter value to insert at beginning: ");
                array.InsertAtBeginning(value);
                std::cout << "Element inserted successfully." << std::endl;
                break;
            }

            case 4: {
                int value = GetValidatedInput("Enter value to insert at end: ");
                array.InsertAtEnd(value);
                std::cout << "Element inserted successfully." << std::endl;
                break;
            }

            case 5: {
                int afterValue = GetValidatedInput("Enter value after which to insert: ");
                int value = GetValidatedInput("Enter value to insert: ");
                array.InsertAfterElement(afterValue, value);
                std::cout << "Element inserted successfully." << std::endl;
                break;
            }

            case 6:
                array.SortArray();
                std::cout << "Array sorted successfully." << std::endl;
                break;

            case 7: {
                int value = GetValidatedInput("Enter value to search: ");
                int index = array.LinearSearch(value);
                if (index != -1) {
                    std::cout << "Element found at index: " << index << std::endl;
                }
                else {
                    std::cout << "Element not found." << std::endl;
                }
                break;
            }

            case 8: {
                int value = GetValidatedInput("Enter value to search: ");
                int index = array.BinarySearch(value);
                if (index != -1) {
                    std::cout << "Element found at index: " << index << std::endl;
                }
                else {
                    std::cout << "Element not found." << std::endl;
                }
                break;
            }

            case 9:
                std::cout << "Current array: ";
                array.PrintArray();
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