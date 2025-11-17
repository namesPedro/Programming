#include "../Header Files/DynamicArray.h"
#include <iostream>
#include <algorithm>

// Константы для управления динамическим массивом
// Начальная емкость массива по умолчанию
const int DefaultCapacity = 4;
// Коэффициент увеличения емкости массива
const double GrowthFactor = 1.5;
// Минимальная емкость массива
const int MinCapacity = 4;              

// Константы для алгоритма сортировки расческой
// Коэффициент уменьшения шага для сортировки расческой
const int CombSortShrinkFactor = 13;
/// Множитель для вычисления шага сортировки расческой
const int CombSortMultiplier = 10;

/// <summary>
/// Конструктор по умолчанию. Инициализирует пустой динамический массив.
/// </summary>
DynamicArray::DynamicArray() : _size(0), _capacity(DefaultCapacity), _growthFactor(GrowthFactor)
{
    _array = new int[_capacity];
}

/// <summary>
/// Деструктор. Освобождает память, выделенную под массив.
/// </summary>
DynamicArray::~DynamicArray()
{
    delete[] _array;
}

/// <summary>
/// Изменяет емкость массива при необходимости увеличения.
/// Создает новый массив большего размера и копирует в него существующие элементы.
/// </summary>
void DynamicArray::Resize()
{
    int newCapacity = static_cast<int>(_capacity * _growthFactor);
    if (newCapacity <= _capacity) {
        newCapacity = _capacity + 1;
    }

    int* newArray = new int[newCapacity];

    for (int i = 0; i < _size; i++) {
        newArray[i] = _array[i];
    }

    delete[] _array;
    _array = newArray;
    _capacity = newCapacity;
}

/// <summary>
/// Возвращает текущее количество элементов в массиве.
/// </summary>
/// <returns>Количество элементов в массиве</returns>
int DynamicArray::GetSize()
{
    return _size;
}

/// <summary>
/// Возвращает текущую емкость массива (максимальное количество элементов без перераспределения памяти).
/// </summary>
/// <returns>Емкость массива</returns>
int DynamicArray::GetCapacity()
{
    return _capacity;
}

/// <summary>
/// Возвращает указатель на внутренний массив данных.
/// </summary>
/// <returns>Указатель на массив целых чисел</returns>
int* DynamicArray::GetArray()
{
    return _array;
}

/// <summary>
/// Добавляет элемент в массив по указанному индексу.
/// При необходимости увеличивает емкость массива.
/// </summary>
/// <param name="index">Индекс для вставки элемента</param>
/// <param name="value">Значение элемента для вставки</param>
/// <exception cref="std::out_of_range">Выбрасывается если индекс вне допустимого диапазона</exception>
void DynamicArray::AddElement(int index, int value)
{
    if (index < 0 || index > _size) {
        throw std::out_of_range("Index out of range");
    }

    if (_size == _capacity) {
        Resize();
    }

    for (int i = _size; i > index; i--) {
        _array[i] = _array[i - 1];
    }

    _array[index] = value;
    _size++;
}

/// <summary>
/// Удаляет элемент из массива по указанному индексу.
/// При необходимости уменьшает емкость массива для оптимизации использования памяти.
/// </summary>
/// <param name="index">Индекс элемента для удаления</param>
/// <exception cref="std::out_of_range">Выбрасывается если индекс вне допустимого диапазона</exception>
void DynamicArray::RemoveByIndex(int index)
{
    if (index < 0 || index >= _size) {
        throw std::out_of_range("Index out of range");
    }

    for (int i = index; i < _size - 1; i++) {
        _array[i] = _array[i + 1];
    }
    _size--;

    if (_capacity > MinCapacity && _size < _capacity / _growthFactor) {
        int newCapacity = static_cast<int>(_capacity / _growthFactor);
        if (newCapacity < MinCapacity) newCapacity = MinCapacity;

        int* newArray = new int[newCapacity];
        for (int i = 0; i < _size; i++) {
            newArray[i] = _array[i];
        }

        delete[] _array;
        _array = newArray;
        _capacity = newCapacity;
    }
}

/// <summary>
/// Удаляет первый найденный элемент с указанным значением из массива.
/// </summary>
/// <param name="value">Значение элемента для удаления</param>
void DynamicArray::RemoveByValue(int value)
{
    for (int i = 0; i < _size; i++) {
        if (_array[i] == value) {
            RemoveByIndex(i);
            return;
        }
    }
}

/// <summary>
/// Возвращает элемент массива по указанному индексу.
/// </summary>
/// <param name="index">Индекс элемента</param>
/// <returns>Значение элемента по указанному индексу</returns>
/// <exception cref="std::out_of_range">Выбрасывается если индекс вне допустимого диапазона</exception>
int DynamicArray::GetElement(int index)
{
    if (index < 0 || index >= _size) {
        throw std::out_of_range("Index out of range");
    }
    return _array[index];
}

/// <summary>
/// Вычисляет следующий шаг для алгоритма сортировки расческой.
/// </summary>
/// <param name="gap">Текущий шаг</param>
/// <returns>Следующий шаг для сортировки</returns>
int getNextGap(int gap)
{
    gap = (gap * CombSortMultiplier) / CombSortShrinkFactor;

    if (gap < 1)
        return 1;
    return gap;
}

/// <summary>
/// Сортирует массив по возрастанию using алгоритм сортировки расческой.
/// Эффективный алгоритм, улучшающий пузырьковую сортировку.
/// </summary>
void DynamicArray::SortArray()
{
    int gap = _size;
    bool swapped = true;

    while (gap != 1 || swapped == true)
    {
        gap = getNextGap(gap);

        swapped = false;

        for (int i = 0; i < _size - gap; i++)
        {
            if (_array[i] > _array[i + gap])
            {
                std::swap(_array[i], _array[i + gap]);
                swapped = true;
            }
        }
    }
}

/// <summary>
/// Выполняет линейный поиск элемента в массиве.
/// </summary>
/// <param name="value">Значение для поиска</param>
/// <returns>Индекс найденного элемента или -1 если элемент не найден</returns>
int DynamicArray::LinearSearch(int value)
{
    for (int i = 0; i < _size; i++) {
        if (_array[i] == value) {
            return i;
        }
    }
    return -1;
}

/// <summary>
/// Выполняет бинарный поиск элемента в отсортированном массиве.
/// Требует предварительной сортировки массива.
/// </summary>
/// <param name="value">Значение для поиска</param>
/// <returns>Индекс найденного элемента или -1 если элемент не найден</returns>
int DynamicArray::BinarySearch(int value)
{
    int left = 0;
    int right = _size - 1;

    while (left <= right)
    {
        int mid = left + (right - left) / 2;

        if (_array[mid] == value)
        {
            return mid;
        }
        else if (_array[mid] < value)
        {
            left = mid + 1;
        }
        else
        {
            right = mid - 1;
        }
    }
    return -1;
}

/// <summary>
/// Вставляет элемент в начало массива.
/// </summary>
/// <param name="value">Значение элемента для вставки</param>
void DynamicArray::InsertAtBeginning(int value)
{
    AddElement(0, value);
}

/// <summary>
/// Вставляет элемент в конец массива.
/// </summary>
/// <param name="value">Значение элемента для вставки</param>
void DynamicArray::InsertAtEnd(int value)
{
    AddElement(_size, value);
}

/// <summary>
/// Вставляет элемент после первого найденного элемента с указанным значением.
/// </summary>
/// <param name="afterValue">Значение элемента, после которого нужно вставить новый элемент</param>
/// <param name="value">Значение нового элемента для вставки</param>
/// <exception cref="std::invalid_argument">Выбрасывается если элемент afterValue не найден</exception>
void DynamicArray::InsertAfterElement(int afterValue, int value)
{
    int index = LinearSearch(afterValue);
    if (index != -1)
    {
        AddElement(index + 1, value);
    }
    else
    {
        throw std::invalid_argument("Element not found");
    }
}