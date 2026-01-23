#include "IOQueueTwoStack.h"
#include "QueueTwoStack.h"
#include <iostream>

/// <summary>
/// «апускает интерактивное меню дл€ работы с очередью, реализованной через два стека.
/// </summary>
void RunQueueTwoStackMenu()
{
    const int MenuEnqueue = 1;
    const int MenuDequeue = 2;
    const int MenuBack = 3;

    QueueTwoStack queue;
    int choice;

    do
    {
        std::cout << "\n=== Queue (Two Stacks) Menu ===" << std::endl;
        std::cout << MenuEnqueue << ". Enqueue" << std::endl;
        std::cout << MenuDequeue << ". Dequeue" << std::endl;
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
            else
            {
                std::cout << "Queue is empty!" << std::endl;
            }
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