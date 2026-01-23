#include "Node.h"

/// <summary>
///  онструктор узла односв€зного списка.
/// </summary>
/// <param name="data">ƒанные, хранимые в узле.</param>
Node::Node(int data)
{
    _data = data;
    _next = nullptr;
}

/// <summary>
/// ƒеструктор узла. ќсвобождение пам€ти дочерних узлов не выполн€етс€ Ч 
/// управление пам€тью осуществл€етс€ внешним контейнером (например, стеком или очередью).
/// </summary>
Node::~Node()
{
}

/// <summary>
/// ¬озвращает указатель на следующий узел в списке.
/// </summary>
/// <returns>”казатель на следующий узел или nullptr, если текущий узел последний.</returns>
Node* Node::GetNext()
{
    return _next;
}

/// <summary>
/// ”станавливает указатель на следующий узел.
/// </summary>
/// <param name="node">”казатель на новый следующий узел.</param>
void Node::SetNext(Node* node)
{
    _next = node;
}

/// <summary>
/// ¬озвращает данные, хран€щиес€ в узле.
/// </summary>
/// <returns>÷елочисленное значение, содержащеес€ в узле.</returns>
int Node::GetData()
{
    return _data;
}