#include "BinaryTreeNode.h"
#include <iostream>

/// <summary>
/// Конструктор узла бинарного дерева.
/// </summary>
/// <param name="data">Данные, хранимые в узле.</param>
BinaryTreeNode::BinaryTreeNode(int data)
{
    _data = data;
    _left = nullptr;
    _right = nullptr;
}

/// <summary>
/// Деструктор узла. Рекурсивно освобождает память левого и правого поддеревьев.
/// </summary>
BinaryTreeNode::~BinaryTreeNode()
{
    if (_left) delete _left;
    if (_right) delete _right;
}

/// <summary>
/// Возвращает данные, хранящиеся в узле.
/// </summary>
/// <returns>Целочисленное значение узла.</returns>
int BinaryTreeNode::GetData()
{
    return _data;
}

/// <summary>
/// Возвращает указатель на левого потомка.
/// </summary>
/// <returns>Указатель на левый узел или nullptr.</returns>
BinaryTreeNode* BinaryTreeNode::GetLeft()
{
    return _left;
}

/// <summary>
/// Устанавливает левого потомка.
/// </summary>
/// <param name="node">Указатель на новый левый узел.</param>
void BinaryTreeNode::SetLeft(BinaryTreeNode* node)
{
    _left = node;
}

/// <summary>
/// Возвращает указатель на правого потомка.
/// </summary>
/// <returns>Указатель на правый узел или nullptr.</returns>
BinaryTreeNode* BinaryTreeNode::GetRight()
{
    return _right;
}

/// <summary>
/// Устанавливает правого потомка.
/// </summary>
/// <param name="node">Указатель на новый правый узел.</param>
void BinaryTreeNode::SetRight(BinaryTreeNode* node)
{
    _right = node;
}