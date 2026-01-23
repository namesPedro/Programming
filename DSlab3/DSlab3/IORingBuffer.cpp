#include "IORingBuffer.h"
#include "RingBuffer.h"
#include <iostream>

/// <summary>
/// Запускает интерактивное меню для работы с кольцевым буфером.
/// </summary>
void RunRingBufferMenu()
{
    const int MenuPush = 1;
    const int MenuPop = 2;
    const int MenuFreeSpace = 3;
    const int MenuOccupiedSpace = 4;
    const int MenuResize = 5;
    const int MenuBack = 6;

    RingBuffer buffer(5);
    int choice;

    do
    {
        std::cout << "\n=== Circular Buffer Menu ===" << std::endl;
        std::cout << MenuPush << ". Push" << std::endl;
        std::cout << MenuPop << ". Pop" << std::endl;
        std::cout << MenuFreeSpace << ". Free Space" << std::endl;
        std::cout << MenuOccupiedSpace << ". Occupied Space" << std::endl;
        std::cout << MenuResize << ". Resize" << std::endl;
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
            buffer.AddElement(data);
            std::cout << "Data added successfully." << std::endl;
            break;
        }
        case MenuPop:
        {
            int data = buffer.GetElement();
            if (data != -1)
            {
                std::cout << "Retrieved data: " << data << std::endl;
            }
            break;
        }
        case MenuFreeSpace:
            std::cout << "Free space: " << buffer.GetFreeSpace() << std::endl;
            break;
        case MenuOccupiedSpace:
            std::cout << "Occupied space: " << buffer.GetSize() << std::endl;
            break;
        case MenuResize:
        {
            int newSize;
            std::cout << "Enter new size: ";
            std::cin >> newSize;
            buffer.Resize(newSize);
            std::cout << "Buffer resized." << std::endl;
            break;
        }
        case MenuBack:
            std::cout << "Returning to main menu..." << std::endl;
            break;
        default:
            std::cout << "Invalid choice!" << std::endl;
        }
    } while (choice != MenuBack);
}