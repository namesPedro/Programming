#ifndef STACK_H
#define STACK_H
#include "Node.h"

struct Stack {
private:
    Node* _top = nullptr;

public:
    Stack();
    ~Stack();
    Node* Peek();
    void Push(int data);
    int Pop();
    void ClearStack();
    bool IsEmpty(); // Вспомогательный метод
};

#endif