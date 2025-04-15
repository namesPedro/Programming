using System;

public class Time
{
    private int hours;
    private int minutes;
    private int seconds;

    public int Hours
    {
        get => hours;
        set
        {
            Validator.AssertValueInRange(value, 0, 60, nameof(Hours));

            hours = value;
        }
    }

    public int Minutes
    {
        get => minutes;
        set
        {
            Validator.AssertValueInRange(value, 0, 60, nameof(Minutes));

            minutes = value;
        }
    }

    public int Seconds
    {
        get => seconds;
        set
        {
            Validator.AssertValueInRange(value, 0, 60, nameof(Seconds));

            seconds = value;
        }
    }

    public Time(int hours, int minutes, int seconds)
    {
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }

    public Time() { }
}