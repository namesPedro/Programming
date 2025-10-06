#include "DynamicArray.h"
#include <iostream>
#include <algorithm>

DynamicArray::DynamicArray() : _size(0), _capacity(4), _growthFactor(1.5)
{
    _array = new int[_capacity];
}

DynamicArray::~DynamicArray()
{
    delete[] _array;
}

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

int DynamicArray::GetSize()
{
    return _size;
}

int DynamicArray::GetCapacity()
{
    return _capacity;
}

int* DynamicArray::GetArray()
{
    return _array;
}

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

void DynamicArray::RemoveByIndex(int index)
{
    if (index < 0 || index >= _size) {
        throw std::out_of_range("Index out of range");
    }

    for (int i = index; i < _size - 1; i++) {
        _array[i] = _array[i + 1];
    }
    _size--;

    if (_capacity > 4 && _size < _capacity / _growthFactor) {
        int newCapacity = static_cast<int>(_capacity / _growthFactor);
        if (newCapacity < 4) newCapacity = 4;

        int* newArray = new int[newCapacity];
        for (int i = 0; i < _size; i++) {
            newArray[i] = _array[i];
        }

        delete[] _array;
        _array = newArray;
        _capacity = newCapacity;
    }
}

void DynamicArray::RemoveByValue(int value)
{
    for (int i = 0; i < _size; i++) {
        if (_array[i] == value) {
            RemoveByIndex(i);
            return;
        }
    }
}

int DynamicArray::GetElement(int index)
{
    if (index < 0 || index >= _size) {
        throw std::out_of_range("Index out of range");
    }
    return _array[index];
}

int getNextGap(int gap)
{
    gap = (gap * 10) / 13;

    if (gap < 1)
        return 1;
    return gap;
}

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

int DynamicArray::LinearSearch(int value)
{
    for (int i = 0; i < _size; i++) {
        if (_array[i] == value) {
            return i;
        }
    }
    return -1;
}

int DynamicArray::BinarySearch(int value)
{
    int left = 0;
    int right = _size - 1;

    while (left <= right) {
        int mid = left + (right - left) / 2;

        if (_array[mid] == value) {
            return mid;
        }
        else if (_array[mid] < value) {
            left = mid + 1;
        }
        else {
            right = mid - 1;
        }
    }
    return -1;
}

void DynamicArray::InsertAtBeginning(int value)
{
    AddElement(0, value);
}

void DynamicArray::InsertAtEnd(int value)
{
    AddElement(_size, value);
}

void DynamicArray::InsertAfterElement(int afterValue, int value)
{
    int index = LinearSearch(afterValue);
    if (index != -1) {
        AddElement(index + 1, value);
    }
    else {
        throw std::invalid_argument("Element not found");
    }
}

void DynamicArray::PrintArray()
{
    if (_size == 0) {
        std::cout << "Array is empty" << std::endl;
        return;
    }

    for (int i = 0; i < _size; i++) {
        std::cout << _array[i];
        if (i < _size - 1) {
            std::cout << ", ";
        }
    }
    std::cout << std::endl;
}