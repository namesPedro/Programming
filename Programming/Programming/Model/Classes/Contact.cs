public class Contact
{
    private string name;
    private string phoneNumber;
    private string email;
    private string address;

    public string Name
    {
        get => name;
        set => name = value;
    }

    public string PhoneNumber
    {
        get => phoneNumber;
        set => phoneNumber = value;
    }

    public string Email
    {
        get => email;
        set => email = value;
    }

    public string Address
    {
        get => address;
        set => address = value;
    }

    public Contact(string name, string phoneNumber, string email, string address)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        Email = email;
        Address = address;
    }

    public Contact() { }
}
