#pragma once
#pragma once

//! \brief Структура динамического массива.
struct DynamicArray
{
private:
    //! \brief Размер массива.
    int _size;

    //! \brief Вместимость массива.
    int _capacity;

    //! \brief Массив.
    int* _array;

    //! \brief Коэффициент роста массива.
    double _growthFactor;

    //! \brief Увеличивает вместимость массива при необходимости.
    void Resize();

public:
    //! \brief Конструктор по умолчанию.
    DynamicArray();

    //! \brief Деструктор.
    ~DynamicArray();

    //! \brief Возвращает размер массива.
    //! \return Размер массива.
    int GetSize();

    //! \brief Возвращает вместимость массива.
    //! \return Вместимость массива.
    int GetCapacity();

    //! \brief Возвращает массив.
    //! \return Массив.
    int* GetArray();

    //! \brief Добавляет элемент в массив по индексу.
    //! \param index Индекс элемента, куда нужно добавить элемент.
    //! \param value Значение элемента.
    void AddElement(int index, int value);

    //! \brief Удаляет элемент массива по передаваемому индексу.
    //! \param index Индекс элемента, который нужно удалить.
    void RemoveByIndex(int index);

    //! \brief Удаляет значение элемента по его передаваемому значению (первое вхождение).
    //! \param value Посылаемое значение, которое нужно удалить.
    void RemoveByValue(int value);

    //! \brief Возвращает элемент по индексу.
    //! \param index Индекс, по которому нужно получить значение.
    //! \return Возвращает значение, которое находится под индексом.
    int GetElement(int index);

    //! \brief Сортирует массив (Сортировка расчёской - Comb Sort).
    void SortArray();

    //! \brief Линейный поиск индекса элемента по передаваемому значению.
    //! \param value Значение, индекс которого нужно найти.
    //! \return Индекс элемента или -1 если не найден.
    int LinearSearch(int value);

    //! \brief Бинарный поиск индекса элемента по передаваемому значению.
    //! \param value Значение, индекс которого нужно найти.
    //! \return Индекс элемента или -1 если не найден.
    int BinarySearch(int value);

    //! \brief Вставляет элемент в начало массива.
    //! \param value Значение элемента.
    void InsertAtBeginning(int value);

    //! \brief Вставляет элемент в конец массива.
    //! \param value Значение элемента.
    void InsertAtEnd(int value);

    //! \brief Вставляет элемент после определенного элемента.
    //! \param afterValue Значение, после которого нужно вставить.
    //! \param value Значение для вставки.
    void InsertAfterElement(int afterValue, int value);

    //! \brief Выводит массив в консоль.
    void PrintArray();
};