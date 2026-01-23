#ifndef DYNAMICARRAY_H
#define DYNAMICARRAY_H

/// <summary>
/// Класс динамического массива для сравнения со списком.
/// </summary>
class DynamicArray
{
private:
    int* _data;

    int _size;

    int _capacity;

    /// <summary>
    /// Увеличивает ёмкость массива вдвое при нехватке места.
    /// </summary>
    void Resize();

public:
    /// <summary>
    /// Конструктор по умолчанию. Создаёт массив начальной ёмкостью 10.
    /// </summary>
    DynamicArray();

    /// <summary>
    /// Деструктор. Освобождает выделенную память.
    /// </summary>
    ~DynamicArray();

    /// <summary>
    /// Возвращает текущий размер массива (количество элементов).
    /// </summary>
    /// <returns>Текущий размер массива.</returns>
    int GetSize() const
    {
        return _size;
    }

    /// <summary>
    /// Проверяет, пуст ли массив.
    /// </summary>
    /// <returns>true, если массив пуст; иначе false.</returns>
    bool IsEmpty() const
    {
        return _size == 0;
    }

    /// <summary>
    /// Возвращает значение элемента по указанному индексу.
    /// </summary>
    /// <param name="index">Индекс запрашиваемого элемента.</param>
    /// <returns>Значение элемента.</returns>
    /// <exception cref="std::out_of_range">Выбрасывается, если индекс вне допустимого диапазона [0, размер).</exception>
    int Get(int index) const;

    /// <summary>
    /// Устанавливает новое значение элемента по указанному индексу.
    /// </summary>
    /// <param name="index">Индекс изменяемого элемента.</param>
    /// <param name="value">Новое значение.</param>
    /// <exception cref="std::out_of_range">Выбрасывается, если индекс вне допустимого диапазона [0, размер).</exception>
    void Set(int index, int value);

    /// <summary>
    /// Добавляет элемент в конец массива. При необходимости увеличивает ёмкость.
    /// </summary>
    /// <param name="value">Значение для добавления.</param>
    void Add(int value);

    /// <summary>
    /// Вставляет элемент по указанному индексу с последующим сдвигом элементов.
    /// </summary>
    /// <param name="index">Индекс для вставки (от 0 до размера включительно).</param>
    /// <param name="value">Значение для вставки.</param>
    /// <returns>true, если вставка выполнена успешно; иначе false.</returns>
    bool Insert(int index, int value);

    /// <summary>
    /// Удаляет элемент по указанному индексу с последующим сдвигом элементов.
    /// </summary>
    /// <param name="index">Индекс удаляемого элемента.</param>
    /// <returns>true, если удаление выполнено успешно; иначе false.</returns>
    bool Remove(int index);

    /// <summary>
    /// Очищает массив, устанавливая размер в 0 (память не освобождается).
    /// </summary>
    void Clean();

    /// <summary>
    /// Выводит содержимое массива в стандартный поток вывода.
    /// </summary>
    void Print() const;
};

#endif