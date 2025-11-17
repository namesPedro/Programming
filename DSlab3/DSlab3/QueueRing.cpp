#include "QueueRing.h"

QueueRing::QueueRing(int capacity) {
    _buffer = new RingBuffer(capacity);
}

QueueRing::~QueueRing() {
    delete _buffer;
}

void QueueRing::Enqueue(int data) {
    _buffer->AddElement(data);
}

int QueueRing::Dequeue() {
    return _buffer->GetElement();
}

void QueueRing::ClearQueue() {
    _buffer->ClearRingBuf();
}

void QueueRing::Resize(int newCapacity) {
    _buffer->Resize(newCapacity);
}

bool QueueRing::IsEmpty() {
    return _buffer->IsEmpty();
}