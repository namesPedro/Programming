#include "DynamicArray.h"
#include <iostream>
#include <stdexcept>

/// <summary>
/// Конструктор по умолчанию. Инициализирует динамический массив начальной ёмкостью 10.
/// </summary>
DynamicArray::DynamicArray()
{
    _data = new int[10];
    _size = 0;
    _capacity = 10;
}

/// <summary>
/// Деструктор. Освобождает выделенную память.
/// </summary>
DynamicArray::~DynamicArray()
{
    delete[] _data;
}

/// <summary>
/// Увеличивает ёмкость массива вдвое и копирует существующие элементы в новый блок памяти.
/// </summary>
void DynamicArray::Resize()
{
    _capacity *= 2;
    int* newData = new int[_capacity];
    for (int i = 0; i < _size; ++i)
    {
        newData[i] = _data[i];
    }
    delete[] _data;
    _data = newData;
}

/// <summary>
/// Возвращает значение элемента по указанному индексу.
/// </summary>
/// <param name="index">Индекс запрашиваемого элемента.</param>
/// <returns>Значение элемента.</returns>
/// <exception cref="std::out_of_range">Выбрасывается, если индекс выходит за пределы допустимого диапазона.</exception>
int DynamicArray::Get(int index) const
{
    if (index < 0 || index >= _size)
    {
        throw std::out_of_range("Index out of range");
    }
    return _data[index];
}

/// <summary>
/// Устанавливает новое значение элемента по указанному индексу.
/// </summary>
/// <param name="index">Индекс изменяемого элемента.</param>
/// <param name="value">Новое значение.</param>
/// <exception cref="std::out_of_range">Выбрасывается, если индекс выходит за пределы допустимого диапазона.</exception>
void DynamicArray::Set(int index, int value)
{
    if (index < 0 || index >= _size)
    {
        throw std::out_of_range("Index out of range");
    }
    _data[index] = value;
}

/// <summary>
/// Добавляет элемент в конец массива. При необходимости увеличивает ёмкость.
/// </summary>
/// <param name="value">Добавляемое значение.</param>
void DynamicArray::Add(int value)
{
    if (_size >= _capacity)
    {
        Resize();
    }
    _data[_size++] = value;
}

/// <summary>
/// Вставляет элемент по указанному индексу с сдвигом последующих элементов.
/// </summary>
/// <param name="index">Индекс позиции для вставки (от 0 до размера массива включительно).</param>
/// <param name="value">Вставляемое значение.</param>
/// <returns>true, если вставка выполнена успешно; иначе false.</returns>
bool DynamicArray::Insert(int index, int value)
{
    if (index < 0 || index > _size) return false;

    if (_size >= _capacity)
    {
        Resize();
    }

    for (int i = _size; i > index; --i)
    {
        _data[i] = _data[i - 1];
    }
    _data[index] = value;
    _size++;
    return true;
}

/// <summary>
/// Удаляет элемент по указанному индексу с сдвигом последующих элементов.
/// </summary>
/// <param name="index">Индекс удаляемого элемента.</param>
/// <returns>true, если удаление выполнено успешно; иначе false.</returns>
bool DynamicArray::Remove(int index)
{
    if (index < 0 || index >= _size) return false;

    for (int i = index; i < _size - 1; ++i)
    {
        _data[i] = _data[i + 1];
    }
    _size--;
    return true;
}

/// <summary>
/// Очищает массив, устанавливая его размер в 0 (без освобождения памяти).
/// </summary>
void DynamicArray::Clean()
{
    _size = 0;
}

/// <summary>
/// Выводит содержимое массива в стандартный поток вывода.
/// </summary>
void DynamicArray::Print() const
{
    if (IsEmpty())
    {
        std::cout << "Array is empty." << std::endl;
        return;
    }

    for (int i = 0; i < _size; ++i)
    {
        std::cout << _data[i];
        if (i < _size - 1)
        {
            std::cout << ", ";
        }
    }
    std::cout << std::endl;
}