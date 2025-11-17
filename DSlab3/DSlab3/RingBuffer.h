#ifndef RINGBUFFER_H
#define RINGBUFFER_H

struct RingBuffer {
private:
    int* _array = nullptr;
    int _headIndex = -1;
    int _tailIndex = -1;
    int _capacity = 0;
    int _size = 0;

public:
    RingBuffer(int capacity = 10); // Конструктор с начальной емкостью
    ~RingBuffer();
    void AddElement(int data);
    int GetElement();
    void Resize(int newCapacity); // Изменение размера
    void ClearRingBuf();
    int* GetArray(); // Для отладки
    int GetFreeSpace();
    int GetSize();
    bool IsEmpty();
    bool IsFull();
};

#endif