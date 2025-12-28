#include "List.h"
#include <iostream>

const int InvalidIndex = -1;
const int EmptyListSize = 0;

/// <summary>
/// ѕолучает узел списка по указанному индексу.
/// </summary>
/// <param name="index">»ндекс узла дл€ поиска</param>
/// <returns>”казатель на найденный узел или nullptr если индекс невалидный</returns>
Node* List::GetNodeByIndex(int index) const {
    if (index < 0 || index >= _size) return nullptr;

    Node* current = _head;
    for (int i = 0; i < index && current != nullptr; ++i) {
        current = current->GetNextNode();
    }
    return current;
}

/// <summary>
/// ƒобавл€ет узел в начало списка.
/// </summary>
/// <param name="node">”казатель на узел дл€ добавлени€</param>
void List::AddToFront(Node* node) {
    if (node == nullptr) return;

    node->SetNextNode(_head);
    node->SetPreviousNode(nullptr);

    if (_head != nullptr) {
        _head->SetPreviousNode(node);
    }
    _head = node;

    if (_tail == nullptr) {
        _tail = node;
    }
    _size++;
}

/// <summary>
/// ƒобавл€ет узел в конец списка.
/// </summary>
/// <param name="node">”казатель на узел дл€ добавлени€</param>
void List::AddToEnd(Node* node) {
    if (node == nullptr) return;

    node->SetNextNode(nullptr);
    node->SetPreviousNode(_tail);

    if (_tail != nullptr) {
        _tail->SetNextNode(node);
    }
    _tail = node;

    if (_head == nullptr) {
        _head = node;
    }
    _size++;
}

/// <summary>
/// ƒобавл€ет узел в список по указанному индексу.
/// </summary>
/// <param name="node">”казатель на узел дл€ добавлени€</param>
/// <param name="index">»ндекс позиции дл€ вставки</param>
/// <returns>true если узел успешно добавлен, false если индекс невалидный</returns>
bool List::AddNode(Node* node, int index) {
    if (index < 0 || index > _size) return false; // ћожно добавить после последнего (index == _size)

    if (index == 0) {
        AddToFront(node);
        return true;
    }
    if (index == _size) {
        AddToEnd(node);
        return true;
    }

    // ¬ставка в середину
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
/// ¬ставл€ет узел после первого найденного узла с указанным значением.
/// </summary>
/// <param name="node">”казатель на узел дл€ вставки</param>
/// <param name="value">«начение узла, после которого нужно вставить</param>
/// <returns>true если узел успешно вставлен, false если целевой узел не найден</returns>
bool List::InsertAfter(int index, Node* node) {
    if (node == nullptr) return false;

    Node* target = GetNodeByIndex(index);
    if (target == nullptr) return false;

    Node* nextNode = target->GetNextNode();

    node->SetNextNode(nextNode);
    node->SetPreviousNode(target);

    target->SetNextNode(node);
    if (nextNode != nullptr) {
        nextNode->SetPreviousNode(node);
    }
    else {
        _tail = node;
    }
    _size++;
    return true;
}

/// <summary>
/// ¬ставл€ет узел перед первым найденным узлом с указанным значением.
/// </summary>
/// <param name="node">”казатель на узел дл€ вставки</param>
/// <param name="value">«начение узла, перед которым нужно вставить</param>
/// <returns>true если узел успешно вставлен, false если целевой узел не найден</returns>
bool List::InsertBefore(int index, Node* node) {
    if (node == nullptr) return false;

    Node* target = GetNodeByIndex(index);
    if (target == nullptr) return false;

    if (target == _head) {
        AddToFront(node);
        return true;
    }

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
/// ”дал€ет узел из списка по указанному индексу.
/// </summary>
/// <param name="index">»ндекс узла дл€ удалени€</param>
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
        _head = nextNode;
    }

    if (nextNode != nullptr) {
        nextNode->SetPreviousNode(prevNode);
    }
    else {
        _tail = prevNode;
    }

    delete nodeToDelete;
    _size--;
    return true;
}

/// <summary>
/// ”дал€ет первый найденный узел с указанным значением из списка.
/// </summary>
/// <param name="value">«начение узла дл€ удалени€</param>
/// <returns>true если узел успешно удален, false если узел не найден</returns>
bool List::RemoveNodeByValue(int value) {
    Node* nodeToDelete = FindNodeByValue(value);
    if (nodeToDelete == nullptr) return false;

    int index = 0;
    Node* current = _head;
    while (current != nullptr && current != nodeToDelete) {
        current = current->GetNextNode();
        index++;
    }

    return RemoveNodeByIndex(index);
}

/// <summary>
/// Ќаходит первый узел с указанным значением в списке.
/// </summary>
/// <param name="value">«начение дл€ поиска</param>
/// <returns>”казатель на найденный узел или nullptr если узел не найден</returns>
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
/// ќчищает список, удал€€ все узлы и освобожда€ пам€ть.
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
/// ¬ыводит содержимое списка в консоль.
/// ‘орматирует вывод с разделител€ми-зап€тыми между элементами.
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
/// —ортирует список по возрастанию методом пузырька.
/// </summary>
void List::Sort() {
    if (_size <= 1) return;

    bool swapped;
    do {
        swapped = false;
        Node* current = _head;

        while (current != nullptr && current->GetNextNode() != nullptr) {
            if (current->GetData() > current->GetNextNode()->GetData()) {
                // ќбмен значени€ми
                int temp = current->GetData();
                current->SetData(current->GetNextNode()->GetData());
                current->GetNextNode()->SetData(temp);
                swapped = true;
            }
            current = current->GetNextNode();
        }
    } while (swapped);
}