using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Contacts.Model
{
	/// <summary>
	/// Сервис для сохранения и загрузки коллекции контактов в файл JSON.
	/// </summary>
	public class ContactSerializer
	{
		/// <summary>
		/// Путь к файлу хранения контактов в формате JSON.
		/// По умолчанию: %MyDocuments%\Contacts\contacts.json
		/// </summary>
		public string FilePath { get; } = Path.Combine(
			Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
			"Contacts", "contacts.json");

		/// <summary>
		/// Сохраняет коллекцию контактов в файл JSON.
		/// Автоматически создаёт директорию, если она не существует.
		/// </summary>
		/// <param name="contacts">Список контактов для сохранения.</param>
		public void SaveContacts(List<Contact> contacts)
		{
			var dir = Path.GetDirectoryName(FilePath);
			if (!string.IsNullOrEmpty(dir)) Directory.CreateDirectory(dir);
			File.WriteAllText(FilePath, JsonConvert.SerializeObject(contacts, Formatting.Indented));
		}

		/// <summary>
		/// Загружает коллекцию контактов из файла JSON.
		/// Если файл не существует, возвращает пустой список.
		/// </summary>
		/// <returns>Список загруженных контактов или пустой список.</returns>
		public List<Contact> LoadContacts()
		{
			if (!File.Exists(FilePath)) return new List<Contact>();
			return JsonConvert.DeserializeObject<List<Contact>>(File.ReadAllText(FilePath)) ?? new List<Contact>();
		}
	}
}