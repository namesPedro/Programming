#ifndef DYNAMICARRAY_H
#define DYNAMICARRAY_H

//! \brief Класс динамического массива для сравнения со списком.
class DynamicArray
{
private:
    //! \brief Указатель на массив данных.
    int* _data;

    //! \brief Текущий размер массива.
    int _size;

    //! \brief Текущая емкость массива.
    int _capacity;

    //! \brief Увеличивает емкость массива при необходимости.
    void Resize();

public:
    //! \brief Конструктор по умолчанию.
    DynamicArray();

    //! \brief Деструктор.
    ~DynamicArray();

    //! \brief Возвращает текущий размер массива.
    //! \return Размер массива.
    int GetSize() const { return _size; }

    //! \brief Проверяет, пуст ли массив.
    //! \return true если массив пуст.
    bool IsEmpty() const { return _size == 0; }

    //! \brief Возвращает элемент по индексу.
    //! \param index Индекс элемента.
    //! \return Значение элемента.
    int Get(int index) const;

    //! \brief Устанавливает значение элемента по индексу.
    //! \param index Индекс элемента.
    //! \param value Новое значение.
    void Set(int index, int value);

    //! \brief Добавляет элемент в конец массива.
    //! \param value Значение для добавления.
    void Add(int value);

    //! \brief Вставляет элемент по указанному индексу.
    //! \param index Индекс для вставки.
    //! \param value Значение для вставки.
    //! \return true если вставка успешна.
    bool Insert(int index, int value);

    //! \brief Удаляет элемент по индексу.
    //! \param index Индекс удаляемого элемента.
    //! \return true если удаление успешно.
    bool Remove(int index);

    //! \brief Очищает массив.
    void Clean();

    //! \brief Выводит массив в консоль.
    void Print() const;
};

#endif