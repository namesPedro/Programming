#include "RingBuffer.h"
#include <iostream>
#include <cstring>

/// <summary>
/// Конструктор кольцевого буфера с заданной ёмкостью.
/// </summary>
/// <param name="capacity">Начальная ёмкость буфера.</param>
RingBuffer::RingBuffer(int capacity)
{
    _capacity = capacity;
    _size = 0;
    _headIndex = 0;
    _tailIndex = 0;
    _array = new int[capacity];
}

/// <summary>
/// Деструктор кольцевого буфера. Освобождает выделенную память.
/// </summary>
RingBuffer::~RingBuffer()
{
    delete[] _array;
}

/// <summary>
/// Добавляет элемент в конец буфера. При заполнении автоматически увеличивает размер.
/// </summary>
/// <param name="data">Данные для добавления.</param>
void RingBuffer::AddElement(int data)
{
    if (IsFull())
    {
        std::cout << "Buffer is full! Resizing..." << std::endl;
        Resize(_capacity * 2);
    }

    _array[_tailIndex] = data;
    _tailIndex = (_tailIndex + 1) % _capacity;
    _size++;
}

/// <summary>
/// Извлекает элемент из начала буфера.
/// </summary>
/// <returns>Значение извлечённого элемента или -1, если буфер пуст.</returns>
int RingBuffer::GetElement()
{
    if (IsEmpty())
    {
        std::cout << "Buffer is empty!" << std::endl;
        return -1;
    }

    int data = _array[_headIndex];
    _headIndex = (_headIndex + 1) % _capacity;
    _size--;
    return data;
}

/// <summary>
/// Изменяет ёмкость буфера и копирует существующие элементы в новый массив.
/// </summary>
/// <param name="newCapacity">Новая ёмкость буфера.</param>
void RingBuffer::Resize(int newCapacity)
{
    int* newArray = new int[newCapacity];

    for (int i = 0; i < _size; i++)
    {
        newArray[i] = _array[(_headIndex + i) % _capacity];
    }

    delete[] _array;
    _array = newArray;
    _capacity = newCapacity;
    _headIndex = 0;
    _tailIndex = _size;
}

/// <summary>
/// Очищает буфер, сбрасывая индексы и размер.
/// </summary>
void RingBuffer::ClearRingBuf()
{
    _headIndex = 0;
    _tailIndex = 0;
    _size = 0;
}

/// <summary>
/// Возвращает указатель на внутренний массив буфера.
/// </summary>
/// <returns>Указатель на массив данных.</returns>
int* RingBuffer::GetArray()
{
    return _array;
}

/// <summary>
/// Возвращает количество свободных ячеек в буфере.
/// </summary>
/// <returns>Число свободных мест.</returns>
int RingBuffer::GetFreeSpace()
{
    return _capacity - _size;
}

/// <summary>
/// Возвращает текущее количество элементов в буфере.
/// </summary>
/// <returns>Размер заполненной части буфера.</returns>
int RingBuffer::GetSize()
{
    return _size;
}

/// <summary>
/// Проверяет, пуст ли буфер.
/// </summary>
/// <returns>true, если буфер пуст; иначе false.</returns>
bool RingBuffer::IsEmpty()
{
    return _size == 0;
}

/// <summary>
/// Проверяет, заполнен ли буфер.
/// </summary>
/// <returns>true, если буфер полон; иначе false.</returns>
bool RingBuffer::IsFull()
{
    return _size == _capacity;
}