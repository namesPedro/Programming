#include "Stack.h"
#include <iostream>

/// <summary>
/// Конструктор стека. Инициализирует пустой стек.
/// </summary>
Stack::Stack()
{
    _top = nullptr;
}

/// <summary>
/// Деструктор стека. Очищает все элементы.
/// </summary>
Stack::~Stack()
{
    ClearStack();
}

/// <summary>
/// Возвращает указатель на верхний узел стека без его удаления.
/// </summary>
/// <returns>Указатель на верхний узел или nullptr, если стек пуст.</returns>
Node* Stack::Peek()
{
    return _top;
}

/// <summary>
/// Добавляет элемент на вершину стека.
/// </summary>
/// <param name="data">Данные для добавления.</param>
void Stack::Push(int data)
{
    Node* newNode = new Node(data);
    newNode->SetNext(_top);
    _top = newNode;
}

/// <summary>
/// Удаляет и возвращает элемент с вершины стека.
/// </summary>
/// <returns>Значение извлечённого элемента или -1, если стек пуст.</returns>
int Stack::Pop()
{
    if (_top == nullptr)
    {
        std::cout << "Stack is empty!" << std::endl;
        return -1;
    }

    Node* temp = _top;
    int data = temp->GetData();
    _top = _top->GetNext();
    delete temp;
    return data;
}

/// <summary>
/// Очищает стек, удаляя все элементы.
/// </summary>
void Stack::ClearStack()
{
    while (_top != nullptr)
    {
        Pop();
    }
}

/// <summary>
/// Проверяет, пуст ли стек.
/// </summary>
/// <returns>true, если стек пуст; иначе false.</returns>
bool Stack::IsEmpty()
{
    return _top == nullptr;
}