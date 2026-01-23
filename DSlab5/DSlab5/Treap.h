#pragma once
#include "TreapNode.h"
#include <utility>

struct Treap {
private:
    TreapNode* _root;

    // Split возвращает пару указателей
    std::pair<TreapNode*, TreapNode*> split(TreapNode* root, int key);
    TreapNode* merge(TreapNode* left, TreapNode* right);

    TreapNode* insertOptimizedRecursive(TreapNode* root, int key, int priority);
    TreapNode* removeOptimizedRecursive(TreapNode* root, int key);

    void displayRecursive(TreapNode* root, int level);
    void clearRecursive(TreapNode* root);

public:
    Treap();
    ~Treap();

    // Оптимизированные методы
    void InsertOptimized(int key, int priority);
    void RemoveOptimized(int key);

    // Неоптимизированные методы
    void InsertUnoptimized(int key, int priority);
    void RemoveUnoptimized(int key);

    // Основные операции
    TreapNode* SearchElement(int key);
    void SplitTree(int key, Treap& leftTree, Treap& rightTree);
    void MergeTrees(Treap& leftTree, Treap& rightTree);

    // Вспомогательные методы
    void DisplayTree();
    void ClearTree();
    TreapNode* GetRoot();
};