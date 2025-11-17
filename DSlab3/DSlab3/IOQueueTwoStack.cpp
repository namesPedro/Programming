#include "IOQueueTwoStack.h"
#include "QueueTwoStack.h"
#include <iostream>

void RunQueueTwoStackMenu() {
    QueueTwoStack queue;
    int choice;

    do {
        std::cout << "\n=== Queue (Two Stacks) Menu ===" << std::endl;
        std::cout << "1. Enqueue" << std::endl;
        std::cout << "2. Dequeue" << std::endl;
        std::cout << "3. Back to Main Menu" << std::endl;
        std::cout << "Choice: ";
        std::cin >> choice;

        switch (choice) {
        case 1: {
            int data;
            std::cout << "Enter data to enqueue: ";
            std::cin >> data;
            queue.Enqueue(data);
            std::cout << "Data enqueued successfully." << std::endl;
            break;
        }
        case 2: {
            int data = queue.Dequeue();
            if (data != -1) {
                std::cout << "Dequeued data: " << data << std::endl;
            }
            else {
                std::cout << "Queue is empty!" << std::endl;
            }
            break;
        }
        case 3:
            std::cout << "Returning to main menu..." << std::endl;
            break;
        default:
            std::cout << "Invalid choice!" << std::endl;
        }
    } while (choice != 3);
}