#include "IOBinaryTree.h"
#include <iostream>
#include <limits>

void IOBinaryTree::ShowMenu() {
    std::cout << "\n=== Binary Search Tree Menu ===" << std::endl;
    std::cout << "1. Insert element" << std::endl;
    std::cout << "2. Remove element" << std::endl;
    std::cout << "3. Search element" << std::endl;
    std::cout << "4. Find minimum" << std::endl;
    std::cout << "5. Find maximum" << std::endl;
    std::cout << "6. Display tree" << std::endl;
    std::cout << "7. Clear tree" << std::endl;
    std::cout << "8. Back to Main Menu" << std::endl;
    std::cout << "Choice: ";
}

void IOBinaryTree::HandleMenu(BinaryTree& tree) {
    int choice;
    int value;
    
    do {
        ShowMenu();
        std::cin >> choice;
        
        switch (choice) {
            case 1:
                std::cout << "Enter value to insert: ";
                std::cin >> value;
                tree.AddElement(value);
                std::cout << "Element " << value << " inserted." << std::endl;
                break;
                
            case 2:
                std::cout << "Enter value to remove: ";
                std::cin >> value;
                tree.RemoveElement(value);
                std::cout << "Element " << value << " removed." << std::endl;
                break;
                
            case 3:
                std::cout << "Enter value to search: ";
                std::cin >> value;
                if (tree.SearchElement(value)) {
                    std::cout << "Element " << value << " found." << std::endl;
                } else {
                    std::cout << "Element " << value << " not found." << std::endl;
                }
                break;
                
            case 4: {
                BinaryTreeNode* minNode = tree.GetMinNode();
                if (minNode) {
                    std::cout << "Minimum: " << minNode->GetData() << std::endl;
                } else {
                    std::cout << "Tree is empty." << std::endl;
                }
                break;
            }
                
            case 5: {
                BinaryTreeNode* maxNode = tree.GetMaxNode();
                if (maxNode) {
                    std::cout << "Maximum: " << maxNode->GetData() << std::endl;
                } else {
                    std::cout << "Tree is empty." << std::endl;
                }
                break;
            }
                
            case 6:
                std::cout << "\nBinary Search Tree:" << std::endl;
                tree.DisplayTree();
                break;
                
            case 7:
                tree.ClearTree();
                std::cout << "Tree cleared." << std::endl;
                break;
                
            case 8:
                std::cout << "Returning to main menu..." << std::endl;
                break;
                
            default:
                std::cout << "Invalid choice. Try again." << std::endl;
                break;
        }
        
        // Очистка буфера ввода
        std::cin.clear();
        std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
        
    } while (choice != 8);
}