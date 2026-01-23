#include "IOBinaryTree.h"
#include "IOTreap.h"
#include <iostream>
#include <limits>

int main()
{
    const int MenuBinaryTree = 1;
    const int MenuTreap = 2;
    const int MenuExit = 3;

    BinaryTree binaryTree;
    Treap treap;

    int mainChoice;

    do
    {
        std::cout << "\n=== Main Menu ===" << std::endl;
        std::cout << MenuBinaryTree << ". Binary Search Tree" << std::endl;
        std::cout << MenuTreap << ". Treap (Cartesian Tree)" << std::endl;
        std::cout << MenuExit << ". Exit" << std::endl;
        std::cout << "Choice: ";
        std::cin >> mainChoice;

        switch (mainChoice)
        {
        case MenuBinaryTree:
            IOBinaryTree::HandleMenu(binaryTree);
            break;

        case MenuTreap:
            IOTreap::HandleMenu(treap);
            break;

        case MenuExit:
            std::cout << "Exiting program..." << std::endl;
            break;

        default:
            std::cout << "Invalid choice. Try again." << std::endl;
            break;
        }

        std::cin.clear();
        std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');

    } while (mainChoice != MenuExit);

    return 0;
}