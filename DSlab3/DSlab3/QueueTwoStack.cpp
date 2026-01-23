#include "QueueTwoStack.h"

/// <summary>
/// Конструктор очереди, реализованной с использованием двух стеков.
/// </summary>
QueueTwoStack::QueueTwoStack()
{
    _inStack = new Stack();
    _outStack = new Stack();
}

/// <summary>
/// Деструктор очереди. Освобождает память, выделенную под внутренние стеки.
/// </summary>
QueueTwoStack::~QueueTwoStack()
{
    delete _inStack;
    delete _outStack;
}

/// <summary>
/// Вспомогательный метод: переносит все элементы из входного стека в выходной.
/// Используется для обеспечения FIFO-порядка при извлечении.
/// </summary>
void QueueTwoStack::_TransferInToOut()
{
    while (!_inStack->IsEmpty())
    {
        _outStack->Push(_inStack->Pop());
    }
}

/// <summary>
/// Добавляет элемент в конец очереди.
/// </summary>
/// <param name="data">Данные для добавления.</param>
void QueueTwoStack::Enqueue(int data)
{
    _inStack->Push(data);
}

/// <summary>
/// Извлекает элемент из начала очереди.
/// </summary>
/// <returns>Значение извлечённого элемента или -1, если очередь пуста.</returns>
int QueueTwoStack::Dequeue()
{
    if (_outStack->IsEmpty())
    {
        _TransferInToOut();
    }

    if (_outStack->IsEmpty())
    {
        return -1;
    }

    return _outStack->Pop();
}

/// <summary>
/// Очищает очередь, удаляя все элементы из обоих внутренних стеков.
/// </summary>
void QueueTwoStack::ClearQueue()
{
    _inStack->ClearStack();
    _outStack->ClearStack();
}

/// <summary>
/// Проверяет, пуста ли очередь.
/// </summary>
/// <returns>true, если оба внутренних стека пусты; иначе false.</returns>
bool QueueTwoStack::IsEmpty()
{
    return _inStack->IsEmpty() && _outStack->IsEmpty();
}