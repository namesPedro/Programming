#ifndef STACK_H
#define STACK_H

#include "Node.h"

/// <summary>
/// Стек на основе односвязного списка.
/// </summary>
struct Stack
{
private:
    Node* _top = nullptr;

public:
    /// <summary>
    /// Конструктор стека. Создаёт пустой стек.
    /// </summary>
    Stack();

    /// <summary>
    /// Деструктор стека. Очищает все элементы.
    /// </summary>
    ~Stack();

    /// <summary>
    /// Возвращает указатель на верхний узел без его удаления.
    /// </summary>
    /// <returns>Указатель на верхний узел или nullptr, если стек пуст.</returns>
    Node* Peek();

    /// <summary>
    /// Добавляет элемент на вершину стека.
    /// </summary>
    /// <param name="data">Данные для добавления.</param>
    void Push(int data);

    /// <summary>
    /// Удаляет и возвращает элемент с вершины стека.
    /// </summary>
    /// <returns>Значение извлечённого элемента или -1, если стек пуст.</returns>
    int Pop();

    /// <summary>
    /// Очищает стек, удаляя все элементы.
    /// </summary>
    void ClearStack();

    /// <summary>
    /// Проверяет, пуст ли стек.
    /// </summary>
    /// <returns>true, если стек пуст; иначе false.</returns>
    bool IsEmpty();
};

#endif