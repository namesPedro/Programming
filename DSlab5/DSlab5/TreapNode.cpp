#include "TreapNode.h"
#include <iostream>

TreapNode::TreapNode(int key, int priority)
    : _key(key), _priority(priority), _left(nullptr), _right(nullptr) {}

TreapNode::~TreapNode() {
    // Деструктор рекурсивно удаляет потомков
    if (_left) delete _left;
    if (_right) delete _right;
}

int TreapNode::GetKey() {
    return _key;
}

int TreapNode::GetPriority() {
    return _priority;
}

TreapNode* TreapNode::GetLeft() {
    return _left;
}

void TreapNode::SetLeft(TreapNode* node) {
    _left = node;
}

TreapNode* TreapNode::GetRight() {
    return _right;
}

void TreapNode::SetRight(TreapNode* node) {ф#include "TreapNode.h"
#include <iostream>

/// <summary>
/// Конструктор узла декартового дерева (Treap).
/// </summary>
/// <param name="key">Ключ узла.</param>
/// <param name="priority">Приоритет узла (обычно генерируется случайно).</param>
TreapNode::TreapNode(int key, int priority)
{
    _key = key;
    _priority = priority;
    _left = nullptr;
    _right = nullptr;
}

/// <summary>
/// Деструктор узла. Рекурсивно освобождает память левого и правого поддеревьев.
/// </summary>
TreapNode::~TreapNode()
{
    if (_left) delete _left;
    if (_right) delete _right;
}

/// <summary>
/// Возвращает ключ узла.
/// </summary>
/// <returns>Целочисленное значение ключа.</returns>
int TreapNode::GetKey()
{
    return _key;
}

/// <summary>
/// Возвращает приоритет узла.
/// </summary>
/// <returns>Целочисленное значение приоритета.</returns>
int TreapNode::GetPriority()
{
    return _priority;
}

/// <summary>
/// Возвращает указатель на левого потомка.
/// </summary>
/// <returns>Указатель на левый узел или nullptr.</returns>
TreapNode* TreapNode::GetLeft()
{
    return _left;
}

/// <summary>
/// Устанавливает левого потомка.
/// </summary>
/// <param name="node">Указатель на новый левый узел.</param>
void TreapNode::SetLeft(TreapNode* node)
{
    _left = node;
}

/// <summary>
/// Возвращает указатель на правого потомка.
/// </summary>
/// <returns>Указатель на правый узел или nullptr.</returns>
TreapNode* TreapNode::GetRight()
{
    return _right;
}

/// <summary>
/// Устанавливает правого потомка.
/// </summary>
/// <param name="node">Указатель на новый правый узел.</param>
void TreapNode::SetRight(TreapNode* node)
{
    _right = node;
}
    _right = node;
}