using Newtonsoft.Json;
using System.IO;
using System.Xml;
using View.Model;

namespace View.Model.Services
{
	public class ContactSerializer
	{
		public string FilePath { get; } = Path.Combine(
			Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
			"Contacts", "contacts.json");

		public void SaveContact(Contact contact)
		{
			var dir = Path.GetDirectoryName(FilePath);
			if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

			var json = JsonConvert.SerializeObject(contact, Newtonsoft.Json.Formatting.Indented);
			File.WriteAllText(FilePath, json);
		}

		public Contact? LoadContact()
		{
			if (!File.Exists(FilePath)) return null;
			var json = File.ReadAllText(FilePath);
			return JsonConvert.DeserializeObject<Contact>(json);
		}
	}
}