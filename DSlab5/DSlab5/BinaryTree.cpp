#include "BinaryTree.h"
#include <iostream>
#include <algorithm>

/// <summary>
/// Конструктор бинарного дерева поиска. Создаёт пустое дерево.
/// </summary>
BinaryTree::BinaryTree()
{
    _root = nullptr;
}

/// <summary>
/// Деструктор бинарного дерева. Очищает всю память, занятую узлами.
/// </summary>
BinaryTree::~BinaryTree()
{
    ClearTree();
}

/// <summary>
/// Возвращает указатель на корневой узел дерева.
/// </summary>
/// <returns>Указатель на корень или nullptr, если дерево пусто.</returns>
BinaryTreeNode* BinaryTree::GetRoot()
{
    return _root;
}

/// <summary>
/// Добавляет элемент в дерево.
/// </summary>
/// <param name="data">Значение для вставки.</param>
void BinaryTree::AddElement(int data)
{
    _root = insertRecursive(_root, data);
}

BinaryTreeNode* BinaryTree::insertRecursive(BinaryTreeNode* node, int data)
{
    if (node == nullptr)
    {
        return new BinaryTreeNode(data);
    }

    if (data < node->GetData())
    {
        node->SetLeft(insertRecursive(node->GetLeft(), data));
    }
    else if (data > node->GetData())
    {
        node->SetRight(insertRecursive(node->GetRight(), data));
    }

    return node;
}

/// <summary>
/// Удаляет элемент из дерева.
/// </summary>
/// <param name="data">Значение для удаления.</param>
void BinaryTree::RemoveElement(int data)
{
    _root = removeRecursive(_root, data);
}

BinaryTreeNode* BinaryTree::removeRecursive(BinaryTreeNode* node, int data)
{
    if (node == nullptr) return nullptr;

    if (data < node->GetData())
    {
        node->SetLeft(removeRecursive(node->GetLeft(), data));
    }
    else if (data > node->GetData())
    {
        node->SetRight(removeRecursive(node->GetRight(), data));
    }
    else
    {
        if (node->GetLeft() == nullptr)
        {
            BinaryTreeNode* temp = node->GetRight();
            delete node;
            return temp;
        }
        else if (node->GetRight() == nullptr)
        {
            BinaryTreeNode* temp = node->GetLeft();
            delete node;
            return temp;
        }

        BinaryTreeNode* temp = findMin(node->GetRight());
        node->SetData(temp->GetData());
        node->SetRight(removeRecursive(node->GetRight(), temp->GetData()));
    }

    return node;
}

BinaryTreeNode* BinaryTree::findMin(BinaryTreeNode* node)
{
    while (node && node->GetLeft() != nullptr)
    {
        node = node->GetLeft();
    }
    return node;
}

BinaryTreeNode* BinaryTree::findMax(BinaryTreeNode* node)
{
    while (node && node->GetRight() != nullptr)
    {
        node = node->GetRight();
    }
    return node;
}

/// <summary>
/// Ищет узел с заданным значением в дереве.
/// </summary>
/// <param name="data">Искомое значение.</param>
/// <returns>Указатель на найденный узел или nullptr, если не найден.</returns>
BinaryTreeNode* BinaryTree::SearchElement(int data)
{
    return searchRecursive(_root, data);
}

BinaryTreeNode* BinaryTree::searchRecursive(BinaryTreeNode* node, int data)
{
    if (node == nullptr || node->GetData() == data)
    {
        return node;
    }

    if (data < node->GetData())
    {
        return searchRecursive(node->GetLeft(), data);
    }

    return searchRecursive(node->GetRight(), data);
}

/// <summary>
/// Возвращает узел с минимальным значением в дереве.
/// </summary>
/// <returns>Указатель на узел с минимальным значением или nullptr, если дерево пусто.</returns>
BinaryTreeNode* BinaryTree::GetMinNode()
{
    return findMin(_root);
}

/// <summary>
/// Возвращает узел с максимальным значением в дереве.
/// </summary>
/// <returns>Указатель на узел с максимальным значением или nullptr, если дерево пусто.</returns>
BinaryTreeNode* BinaryTree::GetMaxNode()
{
    return findMax(_root);
}

/// <summary>
/// Выводит дерево в виде повернутого на 90 градусов (правое поддерево сверху, левое — снизу).
/// </summary>
void BinaryTree::DisplayTree()
{
    displayRecursive(_root, 0);
    std::cout << std::endl;
}

void BinaryTree::displayRecursive(BinaryTreeNode* node, int level)
{
    if (node != nullptr)
    {
        displayRecursive(node->GetRight(), level + 1);

        for (int i = 0; i < level; i++)
        {
            std::cout << "   ";
        }

        std::cout << node->GetData() << std::endl;

        displayRecursive(node->GetLeft(), level + 1);
    }
}

/// <summary>
/// Очищает всё дерево, освобождая память всех узлов.
/// </summary>
void BinaryTree::ClearTree()
{
    clearRecursive(_root);
    _root = nullptr;
}

void BinaryTree::clearRecursive(BinaryTreeNode* node)
{
    if (node != nullptr)
    {
        clearRecursive(node->GetLeft());
        clearRecursive(node->GetRight());
        delete node;
    }
}