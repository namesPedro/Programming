#pragma once
#include "BinaryTreeNode.h"

/// <summary>
/// Бинарное дерево поиска (BST). Поддерживает вставку, удаление, поиск, обход и очистку.
/// </summary>
struct BinaryTree
{
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
    /// <summary>
    /// Конструктор бинарного дерева поиска. Создаёт пустое дерево.
    /// </summary>
    BinaryTree();

    /// <summary>
    /// Деструктор бинарного дерева. Очищает всю память, занятую узлами.
    /// </summary>
    ~BinaryTree();

    /// <summary>
    /// Возвращает указатель на корневой узел дерева.
    /// </summary>
    /// <returns>Указатель на корень или nullptr, если дерево пусто.</returns>
    BinaryTreeNode* GetRoot();

    /// <summary>
    /// Добавляет элемент в дерево.
    /// </summary>
    /// <param name="data">Значение для вставки.</param>
    void AddElement(int data);

    /// <summary>
    /// Удаляет элемент из дерева.
    /// </summary>
    /// <param name="data">Значение для удаления.</param>
    void RemoveElement(int data);

    /// <summary>
    /// Ищет узел с заданным значением в дереве.
    /// </summary>
    /// <param name="data">Искомое значение.</param>
    /// <returns>Указатель на найденный узел или nullptr, если не найден.</returns>
    BinaryTreeNode* SearchElement(int data);

    /// <summary>
    /// Возвращает узел с минимальным значением в дереве.
    /// </summary>
    /// <returns>Указатель на узел с минимальным значением или nullptr, если дерево пусто.</returns>
    BinaryTreeNode* GetMinNode();

    /// <summary>
    /// Возвращает узел с максимальным значением в дереве.
    /// </summary>
    /// <returns>Указатель на узел с максимальным значением или nullptr, если дерево пусто.</returns>
    BinaryTreeNode* GetMaxNode();

    /// <summary>
    /// Выводит дерево в виде повернутого на 90 градусов (правое поддерево сверху, левое — снизу).
    /// </summary>
    void DisplayTree();

    /// <summary>
    /// Очищает всё дерево, освобождая память всех узлов.
    /// </summary>
    void ClearTree();
};