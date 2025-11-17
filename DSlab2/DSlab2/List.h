#ifndef LIST_H
#define LIST_H

#include "Node.h"

//! \brief Структура двусвязного списка.
struct List
{
private:
    //! \brief Поле указателя начального узла.
    Node* _head;

    //! \brief Поле указателя конечного узла.
    Node* _tail;

    //! \brief Поле количества элементов в списке.
    int _size;

public:
    // Конструктор (функция создания и инициализации)
    List() : _head(nullptr), _tail(nullptr), _size(0) {}

    // Деструктор (очень важный для очистки памяти!)
    ~List() {
        Clean();
    }

    //! \brief Возвращает указатель на начальный узел.
    //! \return Указатель на начальный узел.
    Node* GetHead() const { return _head; }

    //! \brief Возвращает указатель на конечный узел.
    //! \return Указатель на конечный узел.
    Node* GetTail() const { return _tail; }

    //! \brief Возвращает размер списка.
    //! \return Размер списка.
    int GetSize() const { return _size; }

    //! \brief Проверяет, пуст ли список.
    //! \return true, если список пуст.
    bool IsEmpty() const { return _size == 0; }

    //! \brief Возвращает узел по указанному индексу.
    //! \param index Индекс, по которому нужно получить узел.
    //! \return Узел или nullptr, если индекс неверный.
    Node* GetNodeByIndex(int index) const;

    // --- ОСНОВНЫЕ ОПЕРАЦИИ ---
    //! \brief Добавляет новый узел в начало списка.
    //! \param node Указатель на новый узел.
    void AddToFront(Node* node);

    //! \brief Добавляет новый узел в конец списка.
    //! \param node Указатель на новый узел.
    void AddToEnd(Node* node);

    //! \brief Добавляет новый узел в список по индексу.
    //! \param node Указатель на новый узел.
    //! \param index Индекс, по которому нужно установить новый узел.
    //! \return Возвращает true, если удалось добавить элемент.
    bool AddNode(Node* node, int index);

    //! \brief Вставляет новый узел ПОСЛЕ узла с указанным значением.
    //! \param node Указатель на новый узел.
    //! \param value Значение, после которого нужно вставить.
    //! \return Возвращает true, если узел с значением найден и вставка произведена.
    bool InsertAfter(Node* node, int value);

    //! \brief Вставляет новый узел ПЕРЕД узлом с указанным значением.
    //! \param node Указатель на новый узел.
    //! \param value Значение, перед которым нужно вставить.
    //! \return Возвращает true, если узел с значением найден и вставка произведена.
    bool InsertBefore(Node* node, int value);

    //! \brief Удаляет узел по индексу.
    //! \param index Индекс узла.
    //! \return Возвращает true, если удалось удалить элемент.
    bool RemoveNodeByIndex(int index);

    //! \brief Удаляет первый узел по значению внутри узла.
    //! \param value Значение внутри узла.
    //! \return Возвращает true, если узел найден и удален.
    bool RemoveNodeByValue(int value);

    //! \brief Сортирует двусвязный список пузырьком.
    void Sort();

    //! \brief Находит узел по указанному значению.
    //! \param value Значение, по которому ищется узел.
    //! \return Найденный узел или nullptr.
    Node* FindNodeByValue(int value) const;

    //! \brief Очищает список от всех элементов.
    void Clean();

    //! \brief Выводит список в консоль.
    void Print() const;
};

#endif