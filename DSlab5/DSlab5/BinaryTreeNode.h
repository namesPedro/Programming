#pragma once

struct BinaryTreeNode {
private:
    int _data;
    BinaryTreeNode* _left;
    BinaryTreeNode* _right;

public:
    BinaryTreeNode(int data);
    ~BinaryTreeNode();

    int GetData();
    BinaryTreeNode* GetLeft();
    void SetLeft(BinaryTreeNode* node);
    BinaryTreeNode* GetRight();
    void SetRight(BinaryTreeNode* node);
};