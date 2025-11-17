#ifndef NODE_H
#define NODE_H

//! \brief Структура узла для двусвязного списка.
struct Node
{
private:
    //! \brief Данные.
    int _data;

    //! \brief Указатель на следующий узел.
    Node* _nextNode;

    //! \brief Указатель на предыдущий узел.
    Node* _previousNode;

public:
    // Конструктор
    Node(int data) : _data(data), _nextNode(nullptr), _previousNode(nullptr) {}

    //! \brief Возвращает данные.
    //! \return Данные.
    int GetData() const { return _data; }

    //! \brief Устанавливает данные
    //! \param data Данные.
    void SetData(int data) { _data = data; }

    //! \brief Возвращает указатель следующий узел.
    //! \return Указатель на следующий узел.
    Node* GetNextNode() const { return _nextNode; }

    //! \brief Устанавливает указатель на следующий узел.
    //! \param node Указатель на следующий узел.
    void SetNextNode(Node* node) { _nextNode = node; }

    //! \brief Возвращает указатель на предыдущий узел.
    //! \return Указатель на предыдущий узел.
    Node* GetPreviousNode() const { return _previousNode; }

    //! \brief Устанавливает указатель на предыдущий узел.
    //! \param node Указатель на предыдущий узел.
    void SetPreviousNode(Node* node) { _previousNode = node; }
};

#endif