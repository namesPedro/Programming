public class Flight
{
    private string departure;
    private string destination;
    private int flightTimeMinutes;

    public string Departure
    {
        get => departure;
        set => departure = value;
    }

    public string Destination
    {
        get => destination;
        set => destination = value;
    }

    public int FlightTimeMinutes
    {
        get => flightTimeMinutes;
        set => flightTimeMinutes = value;
    }

    public Flight(string departure, string destination, int flightTimeMinutes)
    {
        Departure = departure;
        Destination = destination;
        FlightTimeMinutes = flightTimeMinutes;
    }

    public Flight() { }
}