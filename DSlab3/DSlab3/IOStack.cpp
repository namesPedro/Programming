#include "IOStack.h"
#include "Stack.h"
#include <iostream>

void RunStackMenu() {
    Stack stack;
    int choice;

    do {
        std::cout << "\n=== Stack Menu ===" << std::endl;
        std::cout << "1. Push" << std::endl;
        std::cout << "2. Pop" << std::endl;
        std::cout << "3. Clear" << std::endl;
        std::cout << "4. Back to Main Menu" << std::endl;
        std::cout << "Choice: ";
        std::cin >> choice;

        switch (choice) {
        case 1: {
            int data;
            std::cout << "Enter data to push: ";
            std::cin >> data;
            stack.Push(data);
            std::cout << "Data pushed successfully." << std::endl;
            break;
        }
        case 2: {
            int data = stack.Pop();
            if (data != -1) {
                std::cout << "Popped data: " << data << std::endl;
            }
            break;
        }
        case 3:
            stack.ClearStack();
            std::cout << "Stack cleared." << std::endl;
            break;
        case 4:
            std::cout << "Returning to main menu..." << std::endl;
            break;
        default:
            std::cout << "Invalid choice!" << std::endl;
        }
    } while (choice != 4);
}