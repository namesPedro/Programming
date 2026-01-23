#pragma once

/// <summary>
/// Узел бинарного дерева поиска.
/// </summary>
struct BinaryTreeNode
{
private:
    int _data;
    BinaryTreeNode* _left;
    BinaryTreeNode* _right;

public:
    /// <summary>
    /// Конструктор узла.
    /// </summary>
    /// <param name="data">Данные, хранимые в узле.</param>
    BinaryTreeNode(int data);

    /// <summary>
    /// Деструктор узла. Рекурсивно освобождает память левого и правого поддеревьев.
    /// </summary>
    ~BinaryTreeNode();

    /// <summary>
    /// Возвращает данные, хранящиеся в узле.
    /// </summary>
    /// <returns>Целочисленное значение узла.</returns>
    int GetData();

    /// <summary>
    /// Возвращает указатель на левого потомка.
    /// </summary>
    /// <returns>Указатель на левый узел или nullptr.</returns>
    BinaryTreeNode* GetLeft();

    /// <summary>
    /// Устанавливает левого потомка.
    /// </summary>
    /// <param name="node">Указатель на новый левый узел.</param>
    void SetLeft(BinaryTreeNode* node);

    /// <summary>
    /// Возвращает указатель на правого потомка.
    /// </summary>
    /// <returns>Указатель на правый узел или nullptr.</returns>
    BinaryTreeNode* GetRight();

    /// <summary>
    /// Устанавливает правого потомка.
    /// </summary>
    /// <param name="node">Указатель на новый правый узел.</param>
    void SetRight(BinaryTreeNode* node);
};