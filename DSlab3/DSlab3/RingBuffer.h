#ifndef RINGBUFFER_H
#define RINGBUFFER_H

/// <summary>
/// Кольцевой буфер (циклический буфер) фиксированного или расширяемого размера.
/// </summary>
struct RingBuffer
{
private:
    int* _array = nullptr;
    int _headIndex = -1;
    int _tailIndex = -1;
    int _capacity = 0;
    int _size = 0;

public:
    /// <summary>
    /// Конструктор кольцевого буфера.
    /// </summary>
    /// <param name="capacity">Начальная ёмкость буфера (по умолчанию 10).</param>
    RingBuffer(int capacity = 10);

    /// <summary>
    /// Деструктор буфера. Освобождает выделенную память.
    /// </summary>
    ~RingBuffer();

    /// <summary>
    /// Добавляет элемент в конец буфера. При заполнении может автоматически увеличить размер.
    /// </summary>
    /// <param name="data">Данные для добавления.</param>
    void AddElement(int data);

    /// <summary>
    /// Извлекает элемент из начала буфера.
    /// </summary>
    /// <returns>Значение извлечённого элемента или -1, если буфер пуст.</returns>
    int GetElement();

    /// <summary>
    /// Изменяет ёмкость буфера и копирует существующие данные.
    /// </summary>
    /// <param name="newCapacity">Новая ёмкость буфера.</param>
    void Resize(int newCapacity);

    /// <summary>
    /// Очищает буфер, сбрасывая все индексы и размер.
    /// </summary>
    void ClearRingBuf();

    /// <summary>
    /// Возвращает указатель на внутренний массив (предназначен для отладки или внутреннего использования).
    /// </summary>
    /// <returns>Указатель на массив данных.</returns>
    int* GetArray();

    /// <summary>
    /// Возвращает количество свободных ячеек в буфере.
    /// </summary>
    /// <returns>Число свободных мест.</returns>
    int GetFreeSpace();

    /// <summary>
    /// Возвращает текущее количество элементов в буфере.
    /// </summary>
    /// <returns>Размер заполненной части.</returns>
    int GetSize();

    /// <summary>
    /// Проверяет, пуст ли буфер.
    /// </summary>
    /// <returns>true, если буфер пуст; иначе false.</returns>
    bool IsEmpty();

    /// <summary>
    /// Проверяет, заполнен ли буфер.
    /// </summary>
    /// <returns>true, если буфер полон; иначе false.</returns>
    bool IsFull();
};

#endif