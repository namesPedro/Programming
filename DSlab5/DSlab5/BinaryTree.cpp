#include "BinaryTree.h"
#include <iostream>
#include <algorithm>

BinaryTree::BinaryTree() : _root(nullptr) {}

BinaryTree::~BinaryTree() {
    ClearTree();
}

BinaryTreeNode* BinaryTree::GetRoot() {
    return _root;
}

void BinaryTree::AddElement(int data) {
    _root = insertRecursive(_root, data);
}

BinaryTreeNode* BinaryTree::insertRecursive(BinaryTreeNode* node, int data) {
    if (node == nullptr) {
        return new BinaryTreeNode(data);
    }

    if (data < node->GetData()) {
        node->SetLeft(insertRecursive(node->GetLeft(), data));
    }
    else if (data > node->GetData()) {
        node->SetRight(insertRecursive(node->GetRight(), data));
    }

    return node;
}

void BinaryTree::RemoveElement(int data) {
    _root = removeRecursive(_root, data);
}

BinaryTreeNode* BinaryTree::removeRecursive(BinaryTreeNode* node, int data) {
    if (node == nullptr) return nullptr;

    if (data < node->GetData()) {
        node->SetLeft(removeRecursive(node->GetLeft(), data));
    }
    else if (data > node->GetData()) {
        node->SetRight(removeRecursive(node->GetRight(), data));
    }
    else {
        // Узел найден
        if (node->GetLeft() == nullptr) {
            BinaryTreeNode* temp = node->GetRight();
            delete node;
            return temp;
        }
        else if (node->GetRight() == nullptr) {
            BinaryTreeNode* temp = node->GetLeft();
            delete node;
            return temp;
        }

        // У узла два потомка
        BinaryTreeNode* temp = findMin(node->GetRight());
        // Копируем данные минимального узла из правого поддерева
        // В реальной реализации нужно скопировать все данные
        // Для простоты мы не можем изменить _data напрямую, нужен setter
        // Временно просто удаляем и вставляем заново
        int minData = temp->GetData();
        node->SetRight(removeRecursive(node->GetRight(), minData));

        // Создаем новый узел с правильными данными
        BinaryTreeNode* newNode = new BinaryTreeNode(minData);
        newNode->SetLeft(node->GetLeft());
        newNode->SetRight(node->GetRight());
        delete node;
        node = newNode;
    }

    return node;
}

BinaryTreeNode* BinaryTree::findMin(BinaryTreeNode* node) {
    while (node && node->GetLeft() != nullptr) {
        node = node->GetLeft();
    }
    return node;
}

BinaryTreeNode* BinaryTree::findMax(BinaryTreeNode* node) {
    while (node && node->GetRight() != nullptr) {
        node = node->GetRight();
    }
    return node;
}

BinaryTreeNode* BinaryTree::SearchElement(int data) {
    return searchRecursive(_root, data);
}

BinaryTreeNode* BinaryTree::searchRecursive(BinaryTreeNode* node, int data) {
    if (node == nullptr || node->GetData() == data) {
        return node;
    }

    if (data < node->GetData()) {
        return searchRecursive(node->GetLeft(), data);
    }

    return searchRecursive(node->GetRight(), data);
}

BinaryTreeNode* BinaryTree::GetMinNode() {
    return findMin(_root);
}

BinaryTreeNode* BinaryTree::GetMaxNode() {
    return findMax(_root);
}

void BinaryTree::DisplayTree() {
    displayRecursive(_root, 0);
    std::cout << std::endl;
}

void BinaryTree::displayRecursive(BinaryTreeNode* node, int level) {
    if (node != nullptr) {
        displayRecursive(node->GetRight(), level + 1);

        for (int i = 0; i < level; i++) {
            std::cout << "   ";
        }

        std::cout << node->GetData() << std::endl;

        displayRecursive(node->GetLeft(), level + 1);
    }
}

void BinaryTree::ClearTree() {
    clearRecursive(_root);
    _root = nullptr;
}

void BinaryTree::clearRecursive(BinaryTreeNode* node) {
    if (node != nullptr) {
        clearRecursive(node->GetLeft());
        clearRecursive(node->GetRight());
        delete node;
    }
}