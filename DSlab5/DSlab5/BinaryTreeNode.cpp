#include "BinaryTreeNode.h"
#include <iostream>

BinaryTreeNode::BinaryTreeNode(int data)
    : _data(data), _left(nullptr), _right(nullptr) {}

BinaryTreeNode::~BinaryTreeNode() {
    // Деструктор рекурсивно удаляет потомков
    if (_left) delete _left;
    if (_right) delete _right;
}

int BinaryTreeNode::GetData() {
    return _data;
}

BinaryTreeNode* BinaryTreeNode::GetLeft() {
    return _left;
}

void BinaryTreeNode::SetLeft(BinaryTreeNode* node) {
    _left = node;
}

BinaryTreeNode* BinaryTreeNode::GetRight() {
    return _right;
}

void BinaryTreeNode::SetRight(BinaryTreeNode* node) {
    _right = node;
}