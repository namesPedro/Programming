#ifndef LIST_H
#define LIST_H

#include "Node.h"

/// <summary>
/// Структура двусвязного списка.
/// </summary>
struct List
{
private:
    Node* _head;

    Node* _tail;

    int _size;

public:
    /// <summary>
    /// Конструктор по умолчанию. Инициализирует пустой список.
    /// </summary>
    List()
    {
        _head = nullptr;
        _tail = nullptr;
        _size = 0;
    }

    /// <summary>
    /// Деструктор. Освобождает всю память, занятую узлами списка.
    /// </summary>
    ~List()
    {
        Clean();
    }

    /// <summary>
    /// Возвращает указатель на начальный узел списка.
    /// </summary>
    /// <returns>Указатель на головной узел или nullptr, если список пуст.</returns>
    Node* GetHead() const
    {
        return _head;
    }

    /// <summary>
    /// Возвращает указатель на последний узел списка.
    /// </summary>
    /// <returns>Указатель на хвостовой узел или nullptr, если список пуст.</returns>
    Node* GetTail() const
    {
        return _tail;
    }

    /// <summary>
    /// Возвращает количество элементов в списке.
    /// </summary>
    /// <returns>Текущий размер списка.</returns>
    int GetSize() const
    {
        return _size;
    }

    /// <summary>
    /// Проверяет, пуст ли список.
    /// </summary>
    /// <returns>true, если список не содержит элементов; иначе false.</returns>
    bool IsEmpty() const
    {
        return _size == 0;
    }

    /// <summary>
    /// Возвращает узел по указанному индексу.
    /// </summary>
    /// <param name="index">Индекс запрашиваемого узла (от 0 до размера - 1).</param>
    /// <returns>Указатель на узел или nullptr, если индекс недопустим.</returns>
    Node* GetNodeByIndex(int index) const;

    /// <summary>
    /// Добавляет новый узел в начало списка.
    /// </summary>
    /// <param name="node">Указатель на новый узел (не должен быть nullptr).</param>
    void AddToFront(Node* node);

    /// <summary>
    /// Добавляет новый узел в конец списка.
    /// </summary>
    /// <param name="node">Указатель на новый узел (не должен быть nullptr).</param>
    void AddToEnd(Node* node);

    /// <summary>
    /// Добавляет новый узел в список по указанному индексу.
    /// </summary>
    /// <param name="node">Указатель на новый узел (не должен быть nullptr).</param>
    /// <param name="index">Индекс для вставки (от 0 до размера включительно).</param>
    /// <returns>true, если вставка выполнена успешно; иначе false.</returns>
    bool AddNode(Node* node, int index);

    /// <summary>
    /// Вставляет новый узел после узла с заданным индексом.
    /// </summary>
    /// <param name="index">Индекс узла, после которого выполняется вставка.</param>
    /// <param name="node">Указатель на новый узел (не должен быть nullptr).</param>
    /// <returns>true, если вставка выполнена успешно; иначе false.</returns>
    bool InsertAfter(int index, Node* node);

    /// <summary>
    /// Вставляет новый узел перед узлом с заданным индексом.
    /// </summary>
    /// <param name="index">Индекс узла, перед которым выполняется вставка.</param>
    /// <param name="node">Указатель на новый узел (не должен быть nullptr).</param>
    /// <returns>true, если вставка выполнена успешно; иначе false.</returns>
    bool InsertBefore(int index, Node* node);

    /// <summary>
    /// Удаляет узел по указанному индексу.
    /// </summary>
    /// <param name="index">Индекс удаляемого узла.</param>
    /// <returns>true, если удаление выполнено успешно; иначе false.</returns>
    bool RemoveNodeByIndex(int index);

    /// <summary>
    /// Удаляет первый найденный узел с указанным значением.
    /// </summary>
    /// <param name="value">Значение, по которому выполняется поиск узла.</param>
    /// <returns>true, если узел найден и удалён; иначе false.</returns>
    bool RemoveNodeByValue(int value);

    /// <summary>
    /// Сортирует список методом пузырька по возрастанию.
    /// </summary>
    void Sort();

    /// <summary>
    /// Находит первый узел с указанным значением.
    /// </summary>
    /// <param name="value">Значение для поиска.</param>
    /// <returns>Указатель на найденный узел или nullptr, если не найден.</returns>
    Node* FindNodeByValue(int value) const;

    /// <summary>
    /// Очищает список, удаляя все узлы и освобождая память.
    /// </summary>
    void Clean();

    /// <summary>
    /// Выводит содержимое списка в стандартный поток вывода.
    /// </summary>
    void Print() const;
};

#endif