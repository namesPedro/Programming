#ifndef QUEUETWOSTACK_H
#define QUEUETWOSTACK_H
#include "Stack.h"

struct QueueTwoStack {
private:
    Stack* _inStack;
    Stack* _outStack;
    void _TransferInToOut(); // ¬спомогательный метод дл€ перекладывани€

public:
    QueueTwoStack();
    ~QueueTwoStack();
    void Enqueue(int data);
    int Dequeue();
    void ClearQueue();
    bool IsEmpty();
};

#endif