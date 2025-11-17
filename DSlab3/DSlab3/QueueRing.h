#ifndef QUEUERING_H
#define QUEUERING_H
#include "RingBuffer.h"

struct QueueRing {
private:
    RingBuffer* _buffer;

public:
    QueueRing(int capacity = 10);
    ~QueueRing();
    void Enqueue(int data);
    int Dequeue();
    void ClearQueue();
    void Resize(int newCapacity);
    bool IsEmpty();
};

#endif