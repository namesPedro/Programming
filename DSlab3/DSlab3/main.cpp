#include <iostream>
#include "IOStack.h"
#include "IORingBuffer.h"
#include "IOQueueRing.h"
#include "IOQueueTwoStack.h"

int main() {
    int mainChoice;
    do {
        std::cout << "\n=== Main Menu ===" << std::endl;
        std::cout << "1. Stack" << std::endl;
        std::cout << "2. Circular Buffer" << std::endl;
        std::cout << "3. Queue (Circular Buffer)" << std::endl;
        std::cout << "4. Queue (Two Stacks)" << std::endl;
        std::cout << "5. Exit" << std::endl;
        std::cout << "Choice: ";
        std::cin >> mainChoice;

        switch (mainChoice) {
        case 1: RunStackMenu(); break;
        case 2: RunRingBufferMenu(); break;
        case 3: RunQueueRingMenu(); break;
        case 4: RunQueueTwoStackMenu(); break;
        case 5: std::cout << "Exiting..." << std::endl; break;
        default: std::cout << "Invalid choice!" << std::endl;
        }
    } while (mainChoice != 5);

    return 0;
}