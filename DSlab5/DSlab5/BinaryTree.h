#pragma once
#include "BinaryTreeNode.h"

struct BinaryTree {
private:
    BinaryTreeNode* _root;

    BinaryTreeNode* insertRecursive(BinaryTreeNode* node, int data);
    BinaryTreeNode* removeRecursive(BinaryTreeNode* node, int data);
    BinaryTreeNode* findMin(BinaryTreeNode* node);
    BinaryTreeNode* findMax(BinaryTreeNode* node);
    BinaryTreeNode* searchRecursive(BinaryTreeNode* node, int data);
    void clearRecursive(BinaryTreeNode* node);
    void displayRecursive(BinaryTreeNode* node, int level);

public:
    BinaryTree();
    ~BinaryTree();

    BinaryTreeNode* GetRoot();
    void AddElement(int data);
    void RemoveElement(int data);
    BinaryTreeNode* SearchElement(int data);
    BinaryTreeNode* GetMinNode();
    BinaryTreeNode* GetMaxNode();
    void DisplayTree();
    void ClearTree();
};