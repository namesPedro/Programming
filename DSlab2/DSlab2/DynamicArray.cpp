#include "DynamicArray.h"
#include <iostream>
#include <stdexcept>

DynamicArray::DynamicArray() : _data(new int[10]), _size(0), _capacity(10) {}

DynamicArray::~DynamicArray() {
    delete[] _data;
}

void DynamicArray::Resize() {
    _capacity *= 2;
    int* newData = new int[_capacity];
    for (int i = 0; i < _size; ++i) {
        newData[i] = _data[i];
    }
    delete[] _data;
    _data = newData;
}

int DynamicArray::Get(int index) const {
    if (index < 0 || index >= _size) {
        throw std::out_of_range("Index out of range");
    }
    return _data[index];
}

void DynamicArray::Set(int index, int value) {
    if (index < 0 || index >= _size) {
        throw std::out_of_range("Index out of range");
    }
    _data[index] = value;
}

void DynamicArray::Add(int value) {
    if (_size >= _capacity) {
        Resize();
    }
    _data[_size++] = value;
}

bool DynamicArray::Insert(int index, int value) {
    if (index < 0 || index > _size) return false;

    if (_size >= _capacity) {
        Resize();
    }

    for (int i = _size; i > index; --i) {
        _data[i] = _data[i - 1];
    }
    _data[index] = value;
    _size++;
    return true;
}

bool DynamicArray::Remove(int index) {
    if (index < 0 || index >= _size) return false;

    for (int i = index; i < _size - 1; ++i) {
        _data[i] = _data[i + 1];
    }
    _size--;
    return true;
}

void DynamicArray::Clean() {
    _size = 0;
}

void DynamicArray::Print() const {
    if (IsEmpty()) {
        std::cout << "Array is empty." << std::endl;
        return;
    }

    for (int i = 0; i < _size; ++i) {
        std::cout << _data[i];
        if (i < _size - 1) {
            std::cout << ", ";
        }
    }
    std::cout << std::endl;
}