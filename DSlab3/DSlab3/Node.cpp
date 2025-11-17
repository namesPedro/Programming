#include "Node.h"

Node::Node(int data) : _data(data), _next(nullptr) {}

Node::~Node() {
    // Автоматически освобождается
}

Node* Node::GetNext() {
    return _next;
}

void Node::SetNext(Node* node) {
    _next = node;
}

int Node::GetData() {
    return _data;
}