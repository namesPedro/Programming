#include "IOBinaryTree.h"
#include "IOTreap.h"
#include <iostream>
#include <limits>

int main() {
    BinaryTree binaryTree;
    Treap treap;

    int mainChoice;

    do {
        std::cout << "\n=== Main Menu ===" << std::endl;
        std::cout << "1. Binary Search Tree" << std::endl;
        std::cout << "2. Treap (Cartesian Tree)" << std::endl;
        std::cout << "3. Exit" << std::endl;
        std::cout << "Choice: ";
        std::cin >> mainChoice;

        switch (mainChoice) {
        case 1:
            IOBinaryTree::HandleMenu(binaryTree);
            break;

        case 2:
            IOTreap::HandleMenu(treap);
            break;

        case 3:
            std::cout << "Exiting program..." << std::endl;
            break;

        default:
            std::cout << "Invalid choice. Try again." << std::endl;
            break;
        }

        // Очистка буфера ввода
        std::cin.clear();
        std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');

    } while (mainChoice != 3);

    return 0;
}