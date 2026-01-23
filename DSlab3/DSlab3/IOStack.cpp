#include "IOStack.h"
#include "Stack.h"
#include <iostream>

/// <summary>
/// «апускает интерактивное меню дл€ работы со стеком.
/// </summary>
void RunStackMenu()
{
    const int MenuPush = 1;
    const int MenuPop = 2;
    const int MenuClear = 3;
    const int MenuBack = 4;

    Stack stack;
    int choice;

    do
    {
        std::cout << "\n=== Stack Menu ===" << std::endl;
        std::cout << MenuPush << ". Push" << std::endl;
        std::cout << MenuPop << ". Pop" << std::endl;
        std::cout << MenuClear << ". Clear" << std::endl;
        std::cout << MenuBack << ". Back to Main Menu" << std::endl;
        std::cout << "Choice: ";
        std::cin >> choice;

        switch (choice)
        {
        case MenuPush:
        {
            int data;
            std::cout << "Enter data to push: ";
            std::cin >> data;
            stack.Push(data);
            std::cout << "Data pushed successfully." << std::endl;
            break;
        }
        case MenuPop:
        {
            int data = stack.Pop();
            if (data != -1)
            {
                std::cout << "Popped  " << data << std::endl;
            }
            break;
        }
        case MenuClear:
            stack.ClearStack();
            std::cout << "Stack cleared." << std::endl;
            break;
        case MenuBack:
            std::cout << "Returning to main menu..." << std::endl;
            break;
        default:
            std::cout << "Invalid choice!" << std::endl;
        }
    } while (choice != MenuBack);
}