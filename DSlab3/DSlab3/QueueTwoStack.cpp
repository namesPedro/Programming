#include "QueueTwoStack.h"

QueueTwoStack::QueueTwoStack() {
    _inStack = new Stack();
    _outStack = new Stack();
}

QueueTwoStack::~QueueTwoStack() {
    delete _inStack;
    delete _outStack;
}

void QueueTwoStack::_TransferInToOut() {
    while (!_inStack->IsEmpty()) {
        _outStack->Push(_inStack->Pop());
    }
}

void QueueTwoStack::Enqueue(int data) {
    _inStack->Push(data);
}

int QueueTwoStack::Dequeue() {
    if (_outStack->IsEmpty()) {
        _TransferInToOut();
    }

    if (_outStack->IsEmpty()) {
        return -1; // Очередь пуста
    }

    return _outStack->Pop();
}

void QueueTwoStack::ClearQueue() {
    _inStack->ClearStack();
    _outStack->ClearStack();
}

bool QueueTwoStack::IsEmpty() {
    return _inStack->IsEmpty() && _outStack->IsEmpty();
}