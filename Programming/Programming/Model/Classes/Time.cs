using System;

/// <summary>
/// Представляет время с точностью до секунд.
/// </summary>
public class Time
{
    private int hours;
    private int minutes;
    private int seconds;

    /// <summary>
    /// Возвращает или задает часы. Допустимый диапазон: 0-23.
    /// </summary>
    /// <exception cref="ArgumentException">Выбрасывается, если значение вне допустимого диапазона.</exception>
    public int Hours
    {
        get => hours;
        set
        {
            Validator.AssertValueInRange(value, 0, 23, nameof(Hours));
            hours = value;
        }
    }

    /// <summary>
    /// Возвращает или задает минуты. Допустимый диапазон: 0-59.
    /// </summary>
    /// <exception cref="ArgumentException">Выбрасывается, если значение вне допустимого диапазона.</exception>
    public int Minutes
    {
        get => minutes;
        set
        {
            Validator.AssertValueInRange(value, 0, 59, nameof(Minutes));
            minutes = value;
        }
    }

    /// <summary>
    /// Возвращает или задает секунды. Допустимый диапазон: 0-59.
    /// </summary>
    /// <exception cref="ArgumentException">Выбрасывается, если значение вне допустимого диапазона.</exception>
    public int Seconds
    {
        get => seconds;
        set
        {
            Validator.AssertValueInRange(value, 0, 59, nameof(Seconds));
            seconds = value;
        }
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="Time"/> с указанными значениями.
    /// </summary>
    /// <param name="hours">Часы (0-23).</param>
    /// <param name="minutes">Минуты (0-59).</param>
    /// <param name="seconds">Секунды (0-59).</param>
    public Time(int hours, int minutes, int seconds)
    {
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="Time"/> со значениями по умолчанию (00:00:00).
    /// </summary>
    public Time() : this(0, 0, 0) { }
}