using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace View.Model.Services
{
	public class ContactSerializer
	{
		public string FilePath { get; } = Path.Combine(
			Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
			"Contacts", "contacts.json");

		public void SaveContacts(List<Contact> contacts)
		{
			var dir = Path.GetDirectoryName(FilePath);
			if (!string.IsNullOrEmpty(dir)) Directory.CreateDirectory(dir);
			File.WriteAllText(FilePath, JsonConvert.SerializeObject(contacts, Formatting.Indented));
		}

		public List<Contact> LoadContacts()
		{
			if (!File.Exists(FilePath)) return new List<Contact>();
			return JsonConvert.DeserializeObject<List<Contact>>(File.ReadAllText(FilePath)) ?? new List<Contact>();
		}
	}
}