#include "QueueRing.h"

/// <summary>
/// Конструктор очереди на основе кольцевого буфера.
/// </summary>
/// <param name="capacity">Начальная ёмкость очереди.</param>
QueueRing::QueueRing(int capacity)
{
    _buffer = new RingBuffer(capacity);
}

/// <summary>
/// Деструктор очереди. Освобождает память, выделенную под кольцевой буфер.
/// </summary>
QueueRing::~QueueRing()
{
    delete _buffer;
}

/// <summary>
/// Добавляет элемент в конец очереди.
/// </summary>
/// <param name="data">Данные для добавления.</param>
void QueueRing::Enqueue(int data)
{
    _buffer->AddElement(data);
}

/// <summary>
/// Извлекает элемент из начала очереди.
/// </summary>
/// <returns>Значение извлечённого элемента или -1, если очередь пуста.</returns>
int QueueRing::Dequeue()
{
    return _buffer->GetElement();
}

/// <summary>
/// Очищает очередь, удаляя все элементы.
/// </summary>
void QueueRing::ClearQueue()
{
    _buffer->ClearRingBuf();
}

/// <summary>
/// Изменяет ёмкость очереди.
/// </summary>
/// <param name="newCapacity">Новая ёмкость очереди.</param>
void QueueRing::Resize(int newCapacity)
{
    _buffer->Resize(newCapacity);
}

/// <summary>
/// Проверяет, пуста ли очередь.
/// </summary>
/// <returns>true, если очередь пуста; иначе false.</returns>
bool QueueRing::IsEmpty()
{
    return _buffer->IsEmpty();
}