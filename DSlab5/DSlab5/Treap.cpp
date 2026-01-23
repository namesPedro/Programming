#include "Treap.h"
#include <iostream>
#include <algorithm>
#include <cstdlib>
#include <ctime>

/// <summary>
/// Конструктор декартового дерева (Treap). Инициализирует генератор случайных чисел.
/// </summary>
Treap::Treap()
{
    _root = nullptr;
    std::srand(static_cast<unsigned int>(std::time(nullptr)));
}

/// <summary>
/// Деструктор декартового дерева. Очищает всю память, занятую узлами.
/// </summary>
Treap::~Treap()
{
    ClearTree();
}

std::pair<TreapNode*, TreapNode*> Treap::split(TreapNode* root, int key)
{
    if (root == nullptr)
    {
        return std::make_pair(nullptr, nullptr);
    }

    if (root->GetKey() <= key)
    {
        std::pair<TreapNode*, TreapNode*> result = split(root->GetRight(), key);
        root->SetRight(result.first);
        return std::make_pair(root, result.second);
    }
    else
    {
        std::pair<TreapNode*, TreapNode*> result = split(root->GetLeft(), key);
        root->SetLeft(result.second);
        return std::make_pair(result.first, root);
    }
}

TreapNode* Treap::merge(TreapNode* left, TreapNode* right)
{
    if (left == nullptr) return right;
    if (right == nullptr) return left;

    if (left->GetPriority() > right->GetPriority())
    {
        left->SetRight(merge(left->GetRight(), right));
        return left;
    }
    else
    {
        right->SetLeft(merge(left, right->GetLeft()));
        return right;
    }
}

/// <summary>
/// Вставляет элемент в дерево с использованием оптимизированного метода (рекурсивный подход).
/// </summary>
/// <param name="key">Ключ для вставки.</param>
/// <param name="priority">Приоритет узла. Если 0, генерируется случайно (но здесь ожидается явное значение).</param>
void Treap::InsertOptimized(int key, int priority)
{
    _root = insertOptimizedRecursive(_root, key, priority);
}

TreapNode* Treap::insertOptimizedRecursive(TreapNode* root, int key, int priority)
{
    if (root == nullptr)
    {
        return new TreapNode(key, priority);
    }

    if (priority > root->GetPriority())
    {
        std::pair<TreapNode*, TreapNode*> splitResult = split(root, key);
        TreapNode* newNode = new TreapNode(key, priority);
        newNode->SetLeft(splitResult.first);
        newNode->SetRight(splitResult.second);
        return newNode;
    }

    if (key < root->GetKey())
    {
        root->SetLeft(insertOptimizedRecursive(root->GetLeft(), key, priority));
    }
    else
    {
        root->SetRight(insertOptimizedRecursive(root->GetRight(), key, priority));
    }

    return root;
}

/// <summary>
/// Вставляет элемент в дерево с использованием неоптимизированного метода (1 split + 2 merge).
/// </summary>
/// <param name="key">Ключ для вставки.</param>
/// <param name="priority">Приоритет узла.</param>
void Treap::InsertUnoptimized(int key, int priority)
{
    std::pair<TreapNode*, TreapNode*> splitResult = split(_root, key);
    TreapNode* left = splitResult.first;
    TreapNode* right = splitResult.second;

    TreapNode* newNode = new TreapNode(key, priority);
    TreapNode* mergedLeft = merge(left, newNode);
    _root = merge(mergedLeft, right);
}

/// <summary>
/// Удаляет элемент из дерева с использованием оптимизированного метода (рекурсивный подход).
/// </summary>
/// <param name="key">Ключ для удаления.</param>
void Treap::RemoveOptimized(int key)
{
    _root = removeOptimizedRecursive(_root, key);
}

TreapNode* Treap::removeOptimizedRecursive(TreapNode* root, int key)
{
    if (root == nullptr) return nullptr;

    if (root->GetKey() == key)
    {
        TreapNode* result = merge(root->GetLeft(), root->GetRight());
        root->SetLeft(nullptr);
        root->SetRight(nullptr);
        delete root;
        return result;
    }

    if (key < root->GetKey())
    {
        root->SetLeft(removeOptimizedRecursive(root->GetLeft(), key));
    }
    else
    {
        root->SetRight(removeOptimizedRecursive(root->GetRight(), key));
    }

    return root;
}

/// <summary>
/// Удаляет элемент из дерева с использованием неоптимизированного метода (2 split + 1 merge).
/// </summary>
/// <param name="key">Ключ для удаления.</param>
void Treap::RemoveUnoptimized(int key)
{
    std::pair<TreapNode*, TreapNode*> firstSplit = split(_root, key - 1);
    TreapNode* left = firstSplit.first;
    std::pair<TreapNode*, TreapNode*> secondSplit = split(firstSplit.second, key);
    TreapNode* middle = secondSplit.first;
    TreapNode* right = secondSplit.second;

    if (middle)
    {
        delete middle;
    }
    _root = merge(left, right);
}

/// <summary>
/// Ищет узел с заданным ключом в дереве.
/// </summary>
/// <param name="key">Искомый ключ.</param>
/// <returns>Указатель на найденный узел или nullptr, если не найден.</returns>
TreapNode* Treap::SearchElement(int key)
{
    TreapNode* current = _root;
    while (current != nullptr)
    {
        if (current->GetKey() == key)
        {
            return current;
        }
        else if (key < current->GetKey())
        {
            current = current->GetLeft();
        }
        else
        {
            current = current->GetRight();
        }
    }
    return nullptr;
}

/// <summary>
/// Разделяет текущее дерево на два поддерева по заданному ключу.
/// Левое дерево содержит ключи ≤ key, правое — > key.
/// </summary>
/// <param name="key">Ключ разделения.</param>
/// <param name="leftTree">Сюда помещается левое поддерево.</param>
/// <param name="rightTree">Сюда помещается правое поддерево.</param>
void Treap::SplitTree(int key, Treap& leftTree, Treap& rightTree)
{
    leftTree.ClearTree();
    rightTree.ClearTree();

    std::pair<TreapNode*, TreapNode*> splitResult = split(_root, key);
    leftTree._root = splitResult.first;
    rightTree._root = splitResult.second;
    _root = nullptr;
}

/// <summary>
/// Объединяет два дерева в одно. Предполагается, что все ключи в leftTree ≤ всех ключей в rightTree.
/// </summary>
/// <param name="leftTree">Левое дерево (передаётся по ссылке).</param>
/// <param name="rightTree">Правое дерево (передаётся по ссылке).</param>
void Treap::MergeTrees(Treap& leftTree, Treap& rightTree)
{
    ClearTree();
    _root = merge(leftTree._root, rightTree._root);

    leftTree._root = nullptr;
    rightTree._root = nullptr;
}

/// <summary>
/// Выводит дерево в виде повернутого на 90 градусов (правое поддерево сверху, левое — снизу).
/// Каждый узел отображается как "ключ[приоритет]".
/// </summary>
void Treap::DisplayTree()
{
    displayRecursive(_root, 0);
    std::cout << std::endl;
}

void Treap::displayRecursive(TreapNode* root, int level)
{
    if (root != nullptr)
    {
        displayRecursive(root->GetRight(), level + 1);

        for (int i = 0; i < level; i++)
        {
            std::cout << "   ";
        }

        std::cout << root->GetKey() << "[" << root->GetPriority() << "]" << std::endl;

        displayRecursive(root->GetLeft(), level + 1);
    }
}

/// <summary>
/// Очищает всё дерево, освобождая память всех узлов.
/// </summary>
void Treap::ClearTree()
{
    clearRecursive(_root);
    _root = nullptr;
}

void Treap::clearRecursive(TreapNode* root)
{
    if (root != nullptr)
    {
        clearRecursive(root->GetLeft());
        clearRecursive(root->GetRight());
        delete root;
    }
}

/// <summary>
/// Возвращает указатель на корневой узел дерева.
/// </summary>
/// <returns>Указатель на корень или nullptr, если дерево пусто.</returns>
TreapNode* Treap::GetRoot()
{
    return _root;
}