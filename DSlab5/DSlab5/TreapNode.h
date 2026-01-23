#pragma once

struct TreapNode {
private:
    int _key;
    int _priority;
    TreapNode* _left;
    TreapNode* _right;

public:
    TreapNode(int key, int priority);
    ~TreapNode();

    int GetKey();
    int GetPriority();
    TreapNode* GetLeft();
    void SetLeft(TreapNode* node);
    TreapNode* GetRight();
    void SetRight(TreapNode* node);
};