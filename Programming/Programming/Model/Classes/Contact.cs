using System.Text.RegularExpressions;
using System;

/// <summary>
/// Представляет контактную информацию человека.
/// </summary>
public class Contact
{
    private string _name;
    private string _surname;
    private string _phoneNumber;

    /// <summary>
    /// Получает или задает имя контакта.
    /// Должно содержать только буквы английского алфавита.
    /// </summary>
    public string Name
    {
        get => _name;
        set
        {
            AssertStringContainsOnlyLetters(value, nameof(Name));
            _name = value;
        }
    }

    /// <summary>
    /// Получает или задает фамилию контакта.
    /// Должна содержать только буквы английского алфавита.
    /// </summary>
    public string Surname
    {
        get => _surname;
        set
        {
            AssertStringContainsOnlyLetters(value, nameof(Surname));
            _surname = value;
        }
    }

    /// <summary>
    /// Получает или задает номер телефона контакта.
    /// </summary>
    public string PhoneNumber
    {
        get => _phoneNumber;
        set => _phoneNumber = value;
    }

    /// <summary>
    /// Проверяет, что строка содержит только буквы английского алфавита.
    /// </summary>
    /// <param name="value">Проверяемая строка.</param>
    /// <param name="propertyName">Название свойства для сообщения об ошибке.</param>
    /// <exception cref="ArgumentException">
    /// Выбрасывается, если строка содержит символы, отличные от английских букв.
    /// </exception>
    private void AssertStringContainsOnlyLetters(string value, string propertyName)
    {
        if (string.IsNullOrWhiteSpace(value) || !Regex.IsMatch(value, @"^[A-Za-z]+$"))
        {
            throw new ArgumentException($"Property {propertyName} must contain only English letters.");
        }
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="Contact"/> с пустыми значениями.
    /// </summary>
    public Contact() { }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="Contact"/> с указанными значениями.
    /// </summary>
    /// <param name="name">Имя контакта (только английские буквы).</param>
    /// <param name="surname">Фамилия контакта (только английские буквы).</param>
    /// <param name="phoneNumber">Номер телефона.</param>
    public Contact(string name, string surname, string phoneNumber)
    {
        Name = name;
        Surname = surname;
        PhoneNumber = phoneNumber;
    }
}