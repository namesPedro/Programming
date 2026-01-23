#pragma once

/// <summary>
/// Узел декартового дерева (Treap), сочетающий ключ (BST) и приоритет (куча).
/// </summary>
struct TreapNode
{
private:
    int _key;
    int _priority;
    TreapNode* _left;
    TreapNode* _right;

public:
    /// <summary>
    /// Конструктор узла.
    /// </summary>
    /// <param name="key">Ключ узла (определяет положение в BST).</param>
    /// <param name="priority">Приоритет узла (определяет структуру кучи).</param>
    TreapNode(int key, int priority);

    /// <summary>
    /// Деструктор узла. Рекурсивно освобождает память левого и правого поддеревьев.
    /// </summary>
    ~TreapNode();

    /// <summary>
    /// Возвращает ключ узла.
    /// </summary>
    /// <returns>Целочисленное значение ключа.</returns>
    int GetKey();

    /// <summary>
    /// Возвращает приоритет узла.
    /// </summary>
    /// <returns>Целочисленное значение приоритета.</returns>
    int GetPriority();

    /// <summary>
    /// Возвращает указатель на левого потомка.
    /// </summary>
    /// <returns>Указатель на левый узел или nullptr.</returns>
    TreapNode* GetLeft();

    /// <summary>
    /// Устанавливает левого потомка.
    /// </summary>
    /// <param name="node">Указатель на новый левый узел.</param>
    void SetLeft(TreapNode* node);

    /// <summary>
    /// Возвращает указатель на правого потомка.
    /// </summary>
    /// <returns>Указатель на правый узел или nullptr.</returns>
    TreapNode* GetRight();

    /// <summary>
    /// Устанавливает правого потомка.
    /// </summary>
    /// <param name="node">Указатель на новый правый узел.</param>
    void SetRight(TreapNode* node);
};