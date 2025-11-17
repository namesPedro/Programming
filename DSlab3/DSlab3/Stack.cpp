#include "Stack.h"
#include <iostream>

Stack::Stack() : _top(nullptr) {}

Stack::~Stack() {
    ClearStack();
}

Node* Stack::Peek() {
    return _top;
}

void Stack::Push(int data) {
    Node* newNode = new Node(data);
    newNode->SetNext(_top);
    _top = newNode;
}

int Stack::Pop() {
    if (_top == nullptr) {
        std::cout << "Stack is empty!" << std::endl;
        return -1; // или выбросить исключение
    }

    Node* temp = _top;
    int data = temp->GetData();
    _top = _top->GetNext();
    delete temp;
    return data;
}

void Stack::ClearStack() {
    while (_top != nullptr) {
        Pop();
    }
}

bool Stack::IsEmpty() {
    return _top == nullptr;
}