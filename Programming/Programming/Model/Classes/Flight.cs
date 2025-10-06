using System;

/// <summary>
/// Представляет информацию о рейсе между двумя пунктами.
/// </summary>
public class Flight
{
    private string departure;
    private string destination;
    private int flightTimeMinutes;

    /// <summary>
    /// Возвращает или задает пункт отправления рейса.
    /// </summary>
    /// <value>Название города или аэропорта отправления.</value>
    public string Departure
    {
        get => departure;
        set => departure = value;
    }

    /// <summary>
    /// Возвращает или задает пункт назначения рейса.
    /// </summary>
    /// <value>Название города или аэропорта назначения.</value>
    public string Destination
    {
        get => destination;
        set => destination = value;
    }

    /// <summary>
    /// Возвращает или задает продолжительность полета в минутах.
    /// </summary>
    /// <exception cref="ArgumentException">
    /// Выбрасывается, если значение отрицательное или превышает разумные пределы (более 24 часов).
    /// </exception>
    public int FlightTimeMinutes
    {
        get => flightTimeMinutes;
        set => flightTimeMinutes = value;
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="Flight"/> с указанными параметрами.
    /// </summary>
    /// <param name="departure">Пункт отправления (не может быть пустым).</param>
    /// <param name="destination">Пункт назначения (не может быть пустым).</param>
    /// <param name="flightTimeMinutes">Продолжительность полета в минутах (1-1440).</param>
    /// <exception cref="ArgumentException">
    /// Выбрасывается, если параметры не соответствуют требованиям.
    /// </exception>
    public Flight(string departure, string destination, int flightTimeMinutes)
    {
        Departure = departure;
        Destination = destination;
        FlightTimeMinutes = flightTimeMinutes;
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="Flight"/> с пустыми значениями.
    /// </summary>
    public Flight() { }

    /// <summary>
    /// Возвращает продолжительность полета в формате "Xh Ym".
    /// </summary>
    /// <returns>Строковое представление продолжительности полета.</returns>
    public string GetFormattedFlightTime()
    {
        return $"{flightTimeMinutes / 60}h {flightTimeMinutes % 60}m";
    }
}