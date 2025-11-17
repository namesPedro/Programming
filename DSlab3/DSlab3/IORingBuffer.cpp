#include "IORingBuffer.h"
#include "RingBuffer.h"
#include <iostream>

void RunRingBufferMenu() {
    RingBuffer buffer(5); // Начальный размер 5
    int choice;

    do {
        std::cout << "\n=== Circular Buffer Menu ===" << std::endl;
        std::cout << "1. Push" << std::endl;
        std::cout << "2. Pop" << std::endl;
        std::cout << "3. Free Space" << std::endl;
        std::cout << "4. Occupied Space" << std::endl;
        std::cout << "5. Resize" << std::endl;
        std::cout << "6. Back to Main Menu" << std::endl;
        std::cout << "Choice: ";
        std::cin >> choice;

        switch (choice) {
        case 1: {
            int data;
            std::cout << "Enter data to push: ";
            std::cin >> data;
            buffer.AddElement(data);
            std::cout << "Data added successfully." << std::endl;
            break;
        }
        case 2: {
            int data = buffer.GetElement();
            if (data != -1) {
                std::cout << "Retrieved data: " << data << std::endl;
            }
            break;
        }
        case 3:
            std::cout << "Free space: " << buffer.GetFreeSpace() << std::endl;
            break;
        case 4:
            std::cout << "Occupied space: " << buffer.GetSize() << std::endl;
            break;
        case 5: {
            int newSize;
            std::cout << "Enter new size: ";
            std::cin >> newSize;
            buffer.Resize(newSize);
            std::cout << "Buffer resized." << std::endl;
            break;
        }
        case 6:
            std::cout << "Returning to main menu..." << std::endl;
            break;
        default:
            std::cout << "Invalid choice!" << std::endl;
        }
    } while (choice != 6);
}