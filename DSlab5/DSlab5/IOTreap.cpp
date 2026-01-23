#include "IOTreap.h"
#include <iostream>
#include <limits>
#include <cstdlib>
#include <ctime>

void IOTreap::ShowMenu() {
    std::cout << "\n=== Treap Menu ===" << std::endl;
    std::cout << "1. Insert (Unoptimized - 1 Split, 2 Merge)" << std::endl;
    std::cout << "2. Insert (Optimized - 1 Split)" << std::endl;
    std::cout << "3. Remove (Unoptimized - 2 Split, 1 Merge)" << std::endl;
    std::cout << "4. Remove (Optimized - 1 Merge)" << std::endl;
    std::cout << "5. Search element" << std::endl;
    std::cout << "6. Split tree" << std::endl;
    std::cout << "7. Merge trees" << std::endl;
    std::cout << "8. Display tree" << std::endl;
    std::cout << "9. Clear tree" << std::endl;
    std::cout << "10. Back to Main Menu" << std::endl;
    std::cout << "Choice: ";
}

void IOTreap::HandleMenu(Treap& tree) {
    int choice;
    int key, priority;
    int splitKey;

    // Используем статические переменные для хранения деревьев
    static Treap leftTree;
    static Treap rightTree;
    static bool treesPrepared = false;

    do {
        ShowMenu();
        std::cin >> choice;

        switch (choice) {
        case 1:
            std::cout << "Enter key: ";
            std::cin >> key;
            std::cout << "Enter priority (0 for random): ";
            std::cin >> priority;
            if (priority == 0) {
                priority = std::rand() % 100 + 1;
            }
            tree.InsertUnoptimized(key, priority);
            std::cout << "Element " << key << "[" << priority << "] inserted (unoptimized)." << std::endl;
            break;

        case 2:
            std::cout << "Enter key: ";
            std::cin >> key;
            std::cout << "Enter priority (0 for random): ";
            std::cin >> priority;
            if (priority == 0) {
                priority = std::rand() % 100 + 1;
            }
            tree.InsertOptimized(key, priority);
            std::cout << "Element " << key << "[" << priority << "] inserted (optimized)." << std::endl;
            break;

        case 3:
            std::cout << "Enter key to remove: ";
            std::cin >> key;
            tree.RemoveUnoptimized(key);
            std::cout << "Element " << key << " removed (unoptimized)." << std::endl;
            break;

        case 4:
            std::cout << "Enter key to remove: ";
            std::cin >> key;
            tree.RemoveOptimized(key);
            std::cout << "Element " << key << " removed (optimized)." << std::endl;
            break;

        case 5:
            std::cout << "Enter key to search: ";
            std::cin >> key;
            if (tree.SearchElement(key)) {
                std::cout << "Element " << key << " found." << std::endl;
            }
            else {
                std::cout << "Element " << key << " not found." << std::endl;
            }
            break;

        case 6:
            std::cout << "Current tree:" << std::endl;
            tree.DisplayTree();
            std::cout << "Enter split key: ";
            std::cin >> splitKey;
            tree.SplitTree(splitKey, leftTree, rightTree);
            std::cout << "Tree split at key " << splitKey << std::endl;
            std::cout << "Left tree (keys < " << splitKey << "):" << std::endl;
            leftTree.DisplayTree();
            std::cout << "Right tree (keys >= " << splitKey << "):" << std::endl;
            rightTree.DisplayTree();
            treesPrepared = true;
            break;

        case 7:
            if (treesPrepared) {
                tree.MergeTrees(leftTree, rightTree);
                std::cout << "Trees merged successfully!" << std::endl;
                std::cout << "Resulting tree:" << std::endl;
                tree.DisplayTree();
                treesPrepared = false;
            }
            else {
                std::cout << "Error: Please split tree first (option 6)." << std::endl;
            }
            break;

        case 8:
            std::cout << "\nTreap (Cartesian Tree):" << std::endl;
            tree.DisplayTree();
            break;

        case 9:
            tree.ClearTree();
            leftTree.ClearTree();
            rightTree.ClearTree();
            treesPrepared = false;
            std::cout << "All trees cleared." << std::endl;
            break;

        case 10:
            std::cout << "Returning to main menu..." << std::endl;
            break;

        default:
            std::cout << "Invalid choice. Try again." << std::endl;
            break;
        }

        // Очистка буфера ввода
        std::cin.clear();
        std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');

    } while (choice != 10);
}