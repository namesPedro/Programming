using System;

public static class Validator
{
    public static void AssertOnPositiveValue(int value, string propertyName)
    {
        if (value <= 0)
            throw new ArgumentException($"Property {propertyName} must be a positive integer.");
    }

    public static void AssertOnPositiveValue(double value, string propertyName)
    {
        if (value <= 0.0)
            throw new ArgumentException($"Property {propertyName} must be a positive number.");
    }

    public static void AssertValueInRange(int value, int min, int max, string propertyName)
    {
        if (value < min || value > max)
            throw new ArgumentException($"Property {propertyName} must be between {min} and {max}.");
    }

    public static void AssertValueInRange(double value, double min, double max, string propertyName)
    {
        if (value < min || value > max)
            throw new ArgumentException($"Property {propertyName} must be between {min} and {max}.");
    }
}