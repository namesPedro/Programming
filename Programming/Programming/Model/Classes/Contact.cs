using System.Text.RegularExpressions;
using System;

public class Contact
{
    private string _name;
    private string _surname;
    private string _phoneNumber;

    public string Name
    {
        get => _name;
        set
        {
            AssertStringContainsOnlyLetters(value, nameof(Name));
            _name = value;
        }
    }

    public string Surname
    {
        get => _surname;
        set
        {
            AssertStringContainsOnlyLetters(value, nameof(Surname));
            _surname = value;
        }
    }

    public string PhoneNumber
    {
        get => _phoneNumber;
        set => _phoneNumber = value;
    }

    private void AssertStringContainsOnlyLetters(string value, string propertyName)
    {
        if (string.IsNullOrWhiteSpace(value) || !Regex.IsMatch(value, @"^[A-Za-z]+$"))
        {
            throw new ArgumentException($"Property {propertyName} must contain only English letters.");
        }
    }

    public Contact() { }

    public Contact(string name, string surname, string phoneNumber)
    {
        Name = name;
        Surname = surname;
        PhoneNumber = phoneNumber;
    }
}
