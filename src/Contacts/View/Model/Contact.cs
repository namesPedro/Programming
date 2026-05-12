namespace View.Model
{
	public class Contact
	{
		public string Name { get; set; } = string.Empty;
		public string PhoneNumber { get; set; } = string.Empty;
		public string Email { get; set; } = string.Empty;

		public Contact() { }
		public Contact(string name, string phone, string email)
		{
			Name = name;
			PhoneNumber = phone;
			Email = email;
		}
	}
}