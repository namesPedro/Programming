#ifndef NODE_H
#define NODE_H

struct Node {
private:
    int _data;
    Node* _next;

public:
    Node(int data);
    ~Node();
    Node* GetNext();
    void SetNext(Node* node);
    int GetData(); // Добавим геттер для данных
};

#endif