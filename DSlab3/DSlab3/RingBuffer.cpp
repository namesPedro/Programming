#include "RingBuffer.h"
#include <iostream>
#include <cstring> // для memcpy

RingBuffer::RingBuffer(int capacity) : _capacity(capacity), _size(0), _headIndex(0), _tailIndex(0) {
    _array = new int[capacity];
}

RingBuffer::~RingBuffer() {
    delete[] _array;
}

void RingBuffer::AddElement(int data) {
    if (IsFull()) {
        std::cout << "Buffer is full! Resizing..." << std::endl;
        Resize(_capacity * 2);
    }

    _array[_tailIndex] = data;
    _tailIndex = (_tailIndex + 1) % _capacity;
    _size++;
}

int RingBuffer::GetElement() {
    if (IsEmpty()) {
        std::cout << "Buffer is empty!" << std::endl;
        return -1;
    }

    int data = _array[_headIndex];
    _headIndex = (_headIndex + 1) % _capacity;
    _size--;
    return data;
}

void RingBuffer::Resize(int newCapacity) {
    int* newArray = new int[newCapacity];

    // Копируем элементы в новый массив
    for (int i = 0; i < _size; i++) {
        newArray[i] = _array[(_headIndex + i) % _capacity];
    }

    delete[] _array;
    _array = newArray;
    _capacity = newCapacity;
    _headIndex = 0;
    _tailIndex = _size;
}

void RingBuffer::ClearRingBuf() {
    _headIndex = 0;
    _tailIndex = 0;
    _size = 0;
}

int* RingBuffer::GetArray() {
    return _array;
}

int RingBuffer::GetFreeSpace() {
    return _capacity - _size;
}

int RingBuffer::GetSize() {
    return _size;
}

bool RingBuffer::IsEmpty() {
    return _size == 0;
}

bool RingBuffer::IsFull() {
    return _size == _capacity;
}