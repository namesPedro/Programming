#ifndef QUEUERING_H
#define QUEUERING_H

#include "RingBuffer.h"

/// <summary>
/// Очередь, реализованная на основе кольцевого буфера.
/// </summary>
struct QueueRing
{
private:
    RingBuffer* _buffer;

public:
    /// <summary>
    /// Конструктор очереди.
    /// </summary>
    /// <param name="capacity">Начальная ёмкость очереди (по умолчанию 10).</param>
    QueueRing(int capacity = 10);

    /// <summary>
    /// Деструктор очереди.
    /// </summary>
    ~QueueRing();

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
    /// Изменяет ёмкость очереди.
    /// </summary>
    /// <param name="newCapacity">Новая ёмкость.</param>
    void Resize(int newCapacity);

    /// <summary>
    /// Проверяет, пуста ли очередь.
    /// </summary>
    /// <returns>true, если очередь пуста; иначе false.</returns>
    bool IsEmpty();
};

#endif