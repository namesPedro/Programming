#include "TreapNode.h"
#include <iostream>

TreapNode::TreapNode(int key, int priority)
    : _key(key), _priority(priority), _left(nullptr), _right(nullptr)
{
}

TreapNode::~TreapNode()
{
    if (_left) delete _left;
    if (_right) delete _right;
}

int TreapNode::GetKey()
{
    return _key;
}

int TreapNode::GetPriority()
{
    return _priority;
}

TreapNode* TreapNode::GetLeft()
{
    return _left;
}

void TreapNode::SetLeft(TreapNode* node)
{
    _left = node;
}

TreapNode* TreapNode::GetRight()
{
    return _right;
}

void TreapNode::SetRight(TreapNode* node)
{
    _right = node;
}