#ifndef QUEUETWOSTACK_H
#define QUEUETWOSTACK_H

#include "Stack.h"

/// <summary>
/// Очередь, реализованная с использованием двух стеков.
/// </summary>
struct QueueTwoStack
{
private:
    Stack* _inStack;
    Stack* _outStack;
    void _TransferInToOut();

public:
    /// <summary>
    /// Конструктор очереди.
    /// </summary>
    QueueTwoStack();

    /// <summary>
    /// Деструктор очереди.
    /// </summary>
    ~QueueTwoStack();

    /// <summary>
    /// Добавляет элемент в конец очереди.
    /// </summary>
    /// <param name="data">Данные для добавления.</param>
    void Enqueue(int data);

    /// <summary>
    /// Извлекает элемент из начала очереди.
    /// </summary>
    /// <returns>Значение извлечённого элемента или -1, если очередь пуста.</returns>
    int Dequeue();

    /// <summary>
    /// Очищает очередь.
    /// </summary>
    void ClearQueue();

    /// <summary>
    /// Проверяет, пуста ли очередь.
    /// </summary>
    /// <returns>true, если очередь пуста; иначе false.</returns>
    bool IsEmpty();
};

#endif