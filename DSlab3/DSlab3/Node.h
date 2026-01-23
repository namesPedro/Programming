#ifndef NODE_H
#define NODE_H

/// <summary>
/// Узел односвязного списка.
/// </summary>
struct Node
{
private:
    int _data;
    Node* _next;

public:
    /// <summary>
    /// Конструктор узла.
    /// </summary>
    /// <param name="data">Данные для хранения в узле.</param>
    Node(int data);

    /// <summary>
    /// Деструктор узла.
    /// </summary>
    ~Node();

    /// <summary>
    /// Возвращает указатель на следующий узел.
    /// </summary>
    /// <returns>Указатель на следующий узел или nullptr.</returns>
    Node* GetNext();

    /// <summary>
    /// Устанавливает следующий узел.
    /// </summary>
    /// <param name="node">Указатель на новый следующий узел.</param>
    void SetNext(Node* node);

    /// <summary>
    /// Возвращает данные, хранящиеся в узле.
    /// </summary>
    /// <returns>Целочисленное значение данных.</returns>
    int GetData();
};

#endif