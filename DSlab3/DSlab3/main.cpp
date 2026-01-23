#include <iostream>
#include "IOStack.h"
#include "IORingBuffer.h"
#include "IOQueueRing.h"
#include "IOQueueTwoStack.h"

int main()
{
    const int MenuStack = 1;
    const int MenuCircularBuffer = 2;
    const int MenuQueueRing = 3;
    const int MenuQueueTwoStacks = 4;
    const int MenuExit = 5;

    int mainChoice;

    do
    {
        std::cout << "\n=== Main Menu ===" << std::endl;
        std::cout << MenuStack << ". Stack" << std::endl;
        std::cout << MenuCircularBuffer << ". Circular Buffer" << std::endl;
        std::cout << MenuQueueRing << ". Queue (Circular Buffer)" << std::endl;
        std::cout << MenuQueueTwoStacks << ". Queue (Two Stacks)" << std::endl;
        std::cout << MenuExit << ". Exit" << std::endl;
        std::cout << "Choice: ";
        std::cin >> mainChoice;

        switch (mainChoice)
        {
        case MenuStack:
            RunStackMenu();
            break;
        case MenuCircularBuffer:
            RunRingBufferMenu();
            break;
        case MenuQueueRing:
            RunQueueRingMenu();
            break;
        case MenuQueueTwoStacks:
            RunQueueTwoStackMenu();
            break;
        case MenuExit:
            std::cout << "Exiting..." << std::endl;
            break;
        default:
            std::cout << "Invalid choice!" << std::endl;
        }
    } while (mainChoice != MenuExit);

    return 0;
}