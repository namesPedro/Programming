#ifndef NODE_H
#define NODE_H

/// <summary>
/// Структура узла для двусвязного списка.
/// </summary>
struct Node
{
private:
    int _data;

    Node* _nextNode;

    Node* _previousNode;

public:
    /// <summary>
    /// Конструктор узла.
    /// </summary>
    /// <param name="data">Значение, хранимое в узле.</param>
    Node(int data)
    {
        _data = data;
        _nextNode = nullptr;
        _previousNode = nullptr;
    }

    /// <summary>
    /// Возвращает данные, хранящиеся в узле.
    /// </summary>
    /// <returns>Целочисленное значение данных.</returns>
    int GetData() const
    {
        return _data;
    }

    /// <summary>
    /// Устанавливает новые данные в узел.
    /// </summary>
    /// <param name="data">Новое значение данных.</param>
    void SetData(int data)
    {
        _data = data;
    }

    /// <summary>
    /// Возвращает указатель на следующий узел.
    /// </summary>
    /// <returns>Указатель на следующий узел или nullptr, если его нет.</returns>
    Node* GetNextNode() const
    {
        return _nextNode;
    }

    /// <summary>
    /// Устанавливает указатель на следующий узел.
    /// </summary>
    /// <param name="node">Указатель на следующий узел.</param>
    void SetNextNode(Node* node)
    {
        _nextNode = node;
    }

    /// <summary>
    /// Возвращает указатель на предыдущий узел.
    /// </summary>
    /// <returns>Указатель на предыдущий узел или nullptr, если его нет.</returns>
    Node* GetPreviousNode() const
    {
        return _previousNode;
    }

    /// <summary>
    /// Устанавливает указатель на предыдущий узел.
    /// </summary>
    /// <param name="node">Указатель на предыдущий узел.</param>
    void SetPreviousNode(Node* node)
    {
        _previousNode = node;
    }
};

#endif