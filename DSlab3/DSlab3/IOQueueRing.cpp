#include "IOQueueRing.h"
#include "QueueRing.h"
#include <iostream>

/// <summary>
/// Запускает интерактивное меню для работы с очередью на основе кольцевого буфера.
/// </summary>
void RunQueueRingMenu()
{
    const int MenuEnqueue = 1;
    const int MenuDequeue = 2;
    const int MenuResize = 3;
    const int MenuBack = 4;

    QueueRing queue(5);
    int choice;

    do
    {
        std::cout << "\n=== Queue (Circular Buffer) Menu ===" << std::endl;
        std::cout << MenuEnqueue << ". Enqueue" << std::endl;
        std::cout << MenuDequeue << ". Dequeue" << std::endl;
        std::cout << MenuResize << ". Resize" << std::endl;
        std::cout << MenuBack << ". Back to Main Menu" << std::endl;
        std::cout << "Choice: ";
        std::cin >> choice;

        switch (choice)
        {
        case MenuEnqueue:
        {
            int data;
            std::cout << "Enter data to enqueue: ";
            std::cin >> data;
            queue.Enqueue(data);
            std::cout << "Data enqueued successfully." << std::endl;
            break;
        }
        case MenuDequeue:
        {
            int data = queue.Dequeue();
            if (data != -1)
            {
                std::cout << "Dequeued data: " << data << std::endl;
            }
            break;
        }
        case MenuResize:
        {
            int newSize;
            std::cout << "Enter new size: ";
            std::cin >> newSize;
            queue.Resize(newSize);
            std::cout << "Queue resized." << std::endl;
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