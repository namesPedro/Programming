#include "List.h"
#include <iostream>

// Константы для лучшей читаемости
const int INVALID_INDEX = -1;
const int EMPTY_LIST_SIZE = 0;

/// <summary>
/// Получает узел списка по указанному индексу.
/// </summary>
/// <param name="index">Индекс узла для поиска</param>
/// <returns>Указатель на найденный узел или nullptr если индекс невалидный</returns>
Node* List::GetNodeByIndex(int index) const {
    if (index < 0 || index >= _size) return nullptr;

    Node* current = _head;
    for (int i = 0; i < index && current != nullptr; ++i) {
        current = current->GetNextNode();
    }
    return current;
}

/// <summary>
/// Добавляет узел в начало списка.
/// </summary>
/// <param name="node">Указатель на узел для добавления</param>
void List::AddToFront(Node* node) {
    if (node == nullptr) return;

    node->SetNextNode(_head);
    node->SetPreviousNode(nullptr);

    if (_head != nullptr) {
        _head->SetPreviousNode(node);
    }
    _head = node;

    if (_tail == nullptr) { // Если список был пуст
        _tail = node;
    }
    _size++;
}

/// <summary>
/// Добавляет узел в конец списка.
/// </summary>
/// <param name="node">Указатель на узел для добавления</param>
void List::AddToEnd(Node* node) {
    if (node == nullptr) return;

    node->SetNextNode(nullptr);
    node->SetPreviousNode(_tail);

    if (_tail != nullptr) {
        _tail->SetNextNode(node);
    }
    _tail = node;

    if (_head == nullptr) { // Если список был пуст
        _head = node;
    }
    _size++;
}

/// <summary>
/// Добавляет узел в список по указанному индексу.
/// </summary>
/// <param name="node">Указатель на узел для добавления</param>
/// <param name="index">Индекс позиции для вставки</param>
/// <returns>true если узел успешно добавлен, false если индекс невалидный</returns>
bool List::AddNode(Node* node, int index) {
    if (index < 0 || index > _size) return false; // Можно добавить после последнего (index == _size)

    if (index == 0) {
        AddToFront(node);
        return true;
    }
    if (index == _size) {
        AddToEnd(node);
        return true;
    }

    // Вставка в середину
    Node* prevNode = GetNodeByIndex(index - 1);
    if (prevNode == nullptr) return false;

    Node* nextNode = prevNode->GetNextNode();

    node->SetNextNode(nextNode);
    node->SetPreviousNode(prevNode);

    prevNode->SetNextNode(node);
    if (nextNode != nullptr) {
        nextNode->SetPreviousNode(node);
    }
    _size++;
    return true;
}

/// <summary>
/// Вставляет узел после первого найденного узла с указанным значением.
/// </summary>
/// <param name="node">Указатель на узел для вставки</param>
/// <param name="value">Значение узла, после которого нужно вставить</param>
/// <returns>true если узел успешно вставлен, false если целевой узел не найден</returns>
bool List::InsertAfter(Node* node, int value) {
    if (node == nullptr) return false; // Добавляем проверку

    Node* target = FindNodeByValue(value);
    if (target == nullptr) return false;

    Node* nextNode = target->GetNextNode();

    node->SetNextNode(nextNode);
    node->SetPreviousNode(target);

    target->SetNextNode(node);
    if (nextNode != nullptr) {
        nextNode->SetPreviousNode(node);
    }
    else {
        // Если вставляем после хвоста, обновляем хвост
        _tail = node;
    }
    _size++;
    return true;
}

/// <summary>
/// Вставляет узел перед первым найденным узлом с указанным значением.
/// </summary>
/// <param name="node">Указатель на узел для вставки</param>
/// <param name="value">Значение узла, перед которым нужно вставить</param>
/// <returns>true если узел успешно вставлен, false если целевой узел не найден</returns>
bool List::InsertBefore(Node* node, int value) {
    if (node == nullptr) return false;

    Node* target = FindNodeByValue(value);
    if (target == nullptr) return false;

    // Если целевой узел - голова списка
    if (target == _head) {
        AddToFront(node);
        return true;
    }

    // Вставка перед целевым узлом
    Node* prevNode = target->GetPreviousNode();

    node->SetNextNode(target);
    node->SetPreviousNode(prevNode);

    if (prevNode != nullptr) {
        prevNode->SetNextNode(node);
    }
    target->SetPreviousNode(node);

    _size++;
    return true;
}

/// <summary>
/// Удаляет узел из списка по указанному индексу.
/// </summary>
/// <param name="index">Индекс узла для удаления</param>
/// <returns>true если узел успешно удален, false если индекс невалидный</returns>
bool List::RemoveNodeByIndex(int index) {
    if (index < 0 || index >= _size) return false;

    Node* nodeToDelete = GetNodeByIndex(index);
    if (nodeToDelete == nullptr) return false;

    Node* prevNode = nodeToDelete->GetPreviousNode();
    Node* nextNode = nodeToDelete->GetNextNode();

    if (prevNode != nullptr) {
        prevNode->SetNextNode(nextNode);
    }
    else {
        _head = nextNode; // Удаляем голову
    }

    if (nextNode != nullptr) {
        nextNode->SetPreviousNode(prevNode);
    }
    else {
        _tail = prevNode; // Удаляем хвост
    }

    delete nodeToDelete;
    _size--;
    return true;
}

/// <summary>
/// Удаляет первый найденный узел с указанным значением из списка.
/// </summary>
/// <param name="value">Значение узла для удаления</param>
/// <returns>true если узел успешно удален, false если узел не найден</returns>
bool List::RemoveNodeByValue(int value) {
    Node* nodeToDelete = FindNodeByValue(value);
    if (nodeToDelete == nullptr) return false;

    // Найдем его индекс для использования существующей логики удаления
    // (Это не оптимально O(n) повторно, но переиспользует код. Можно оптимизировать.)
    int index = 0;
    Node* current = _head;
    while (current != nullptr && current != nodeToDelete) {
        current = current->GetNextNode();
        index++;
    }

    if (current == nodeToDelete) {
        return RemoveNodeByIndex(index);
    }
    return false;
}

/// <summary>
/// Находит первый узел с указанным значением в списке.
/// </summary>
/// <param name="value">Значение для поиска</param>
/// <returns>Указатель на найденный узел или nullptr если узел не найден</returns>
Node* List::FindNodeByValue(int value) const {
    Node* current = _head;
    while (current != nullptr) {
        if (current->GetData() == value) {
            return current;
        }
        current = current->GetNextNode();
    }
    return nullptr;
}

/// <summary>
/// Очищает список, удаляя все узлы и освобождая память.
/// </summary>
void List::Clean() {
    Node* current = _head;
    while (current != nullptr) {
        Node* next = current->GetNextNode();
        delete current;
        current = next;
    }
    _head = nullptr;
    _tail = nullptr;
    _size = 0;
}

/// <summary>
/// Выводит содержимое списка в консоль.
/// Форматирует вывод с разделителями-запятыми между элементами.
/// </summary>
void List::Print() const {
    if (IsEmpty()) {
        std::cout << "List is empty." << std::endl;
        return;
    }

    Node* current = _head;
    while (current != nullptr) {
        std::cout << current->GetData();
        if (current->GetNextNode() != nullptr) {
            std::cout << ", ";
        }
        current = current->GetNextNode();
    }
    std::cout << std::endl;
}

/// <summary>
/// Сортирует список по возрастанию методом пузырька.
/// </summary>
void List::Sort() {
    if (_size <= 1) return; // Нечего сортировать

    bool swapped;
    do {
        swapped = false;
        Node* current = _head;

        while (current != nullptr && current->GetNextNode() != nullptr) {
            if (current->GetData() > current->GetNextNode()->GetData()) {
                // Обмен значениями
                int temp = current->GetData();
                current->SetData(current->GetNextNode()->GetData());
                current->GetNextNode()->SetData(temp);
                swapped = true;
            }
            current = current->GetNextNode();
        }
    } while (swapped);
}