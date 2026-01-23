#pragma once
#include "TreapNode.h"
#include <utility>

/// <summary>
/// Декартово дерево (Treap) — структура данных, сочетающая свойства бинарного дерева поиска и кучи.
/// Поддерживает вставку, удаление, поиск, разделение и слияние.
/// </summary>
struct Treap
{
private:
    TreapNode* _root;

    std::pair<TreapNode*, TreapNode*> split(TreapNode* root, int key);
    TreapNode* merge(TreapNode* left, TreapNode* right);

    TreapNode* insertOptimizedRecursive(TreapNode* root, int key, int priority);
    TreapNode* removeOptimizedRecursive(TreapNode* root, int key);

    void displayRecursive(TreapNode* root, int level);
    void clearRecursive(TreapNode* root);

public:
    /// <summary>
    /// Конструктор декартового дерева. Инициализирует генератор случайных чисел.
    /// </summary>
    Treap();

    /// <summary>
    /// Деструктор декартового дерева. Очищает всю память, занятую узлами.
    /// </summary>
    ~Treap();

    /// <summary>
    /// Вставляет элемент в дерево с использованием оптимизированного метода (рекурсивный подход).
    /// </summary>
    /// <param name="key">Ключ для вставки.</param>
    /// <param name="priority">Приоритет узла.</param>
    void InsertOptimized(int key, int priority);

    /// <summary>
    /// Удаляет элемент из дерева с использованием оптимизированного метода.
    /// </summary>
    /// <param name="key">Ключ для удаления.</param>
    void RemoveOptimized(int key);

    /// <summary>
    /// Вставляет элемент в дерево с использованием неоптимизированного метода (1 split + 2 merge).
    /// </summary>
    /// <param name="key">Ключ для вставки.</param>
    /// <param name="priority">Приоритет узла.</param>
    void InsertUnoptimized(int key, int priority);

    /// <summary>
    /// Удаляет элемент из дерева с использованием неоптимизированного метода (2 split + 1 merge).
    /// </summary>
    /// <param name="key">Ключ для удаления.</param>
    void RemoveUnoptimized(int key);

    /// <summary>
    /// Ищет узел с заданным ключом в дереве.
    /// </summary>
    /// <param name="key">Искомый ключ.</param>
    /// <returns>Указатель на найденный узел или nullptr, если не найден.</returns>
    TreapNode* SearchElement(int key);

    /// <summary>
    /// Разделяет текущее дерево на два поддерева по заданному ключу.
    /// Левое дерево содержит ключи ≤ key, правое — > key.
    /// </summary>
    /// <param name="key">Ключ разделения.</param>
    /// <param name="leftTree">Сюда помещается левое поддерево.</param>
    /// <param name="rightTree">Сюда помещается правое поддерево.</param>
    void SplitTree(int key, Treap& leftTree, Treap& rightTree);

    /// <summary>
    /// Объединяет два дерева в одно. Предполагается, что все ключи в leftTree ≤ всех ключей в rightTree.
    /// </summary>
    /// <param name="leftTree">Левое дерево (передаётся по ссылке).</param>
    /// <param name="rightTree">Правое дерево (передаётся по ссылке).</param>
    void MergeTrees(Treap& leftTree, Treap& rightTree);

    /// <summary>
    /// Выводит дерево в виде повернутого на 90 градусов (правое поддерево сверху, левое — снизу).
    /// Каждый узел отображается как "ключ[приоритет]".
    /// </summary>
    void DisplayTree();

    /// <summary>
    /// Очищает всё дерево, освобождая память всех узлов.
    /// </summary>
    void ClearTree();

    /// <summary>
    /// Возвращает указатель на корневой узел дерева.
    /// </summary>
    /// <returns>Указатель на корень или nullptr, если дерево пусто.</returns>
    TreapNode* GetRoot();
};