#include "IOQueueRing.h"
#include "QueueRing.h"
#include <iostream>

void RunQueueRingMenu() {
    QueueRing queue(5); // Начальный размер 5
    int choice;

    do {
        std::cout << "\n=== Queue (Circular Buffer) Menu ===" << std::endl;
        std::cout << "1. Enqueue" << std::endl;
        std::cout << "2. Dequeue" << std::endl;
        std::cout << "3. Resize" << std::endl;
        std::cout << "4. Back to Main Menu" << std::endl;
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
            break;
        }
        case 3: {
            int newSize;
            std::cout << "Enter new size: ";
            std::cin >> newSize;
            queue.Resize(newSize);
            std::cout << "Queue resized." << std::endl;
            break;
        }
        case 4:
            std::cout << "Returning to main menu..." << std::endl;
            break;
        default:
            std::cout << "Invalid choice!" << std::endl;
        }
    } while (choice != 4);
}