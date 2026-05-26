using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Contacts.Model
{
	public class Contact : INotifyPropertyChanged, INotifyDataErrorInfo
	{
		// Поля данных
		private string _name = string.Empty;
		private string _phoneNumber = string.Empty;
		private string _email = string.Empty;

		// Словарь для хранения ошибок валидации
		private readonly Dictionary<string, List<string>> _errors = new();

		// Свойство Name
		public string Name
		{
			get => _name;
			set
			{
				_name = value;
				OnPropertyChanged();
				ValidateProperty(nameof(Name), value);
			}
		}

		// Свойство PhoneNumber
		public string PhoneNumber
		{
			get => _phoneNumber;
			set
			{
				_phoneNumber = value;
				OnPropertyChanged();
				ValidateProperty(nameof(PhoneNumber), value);
			}
		}

		// Свойство Email
		public string Email
		{
			get => _email;
			set
			{
				_email = value;
				OnPropertyChanged();
				ValidateProperty(nameof(Email), value);
			}
		}

		/// <summary>
		/// Метод валидации свойств
		/// </summary>
		private void ValidateProperty(string propertyName, object value)
		{
			// Удаляем старые ошибки для этого свойства
			_errors.Remove(propertyName);
			List<string> errors = new List<string>();
			string strValue = value as string ?? string.Empty;

			// Проверка Name
			if (propertyName == nameof(Name))
			{
				if (strValue.Length > 100)
					errors.Add("Имя не должно превышать 100 символов");
			}
			// Проверка PhoneNumber
			else if (propertyName == nameof(PhoneNumber))
			{
				if (strValue.Length > 100)
					errors.Add("Номер не должен превышать 100 символов");
				// Регулярное выражение: только цифры, пробелы, +, -, (, )
				else if (!Regex.IsMatch(strValue, @"^[\d\+\-\(\)\s]*$"))
					errors.Add("Телефон может содержать только цифры и символы + - ( )");
			}
			// Проверка Email
			else if (propertyName == nameof(Email))
			{
				if (strValue.Length > 100)
					errors.Add("Email не должен превышать 100 символов");
				else if (!strValue.Contains("@"))
					errors.Add("Email должен содержать символ @");
			}

			// Если есть ошибки, добавляем их в словарь
			if (errors.Count > 0)
				_errors[propertyName] = errors;

			// Уведомляем интерфейс об изменении ошибок
			ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
		}

		#region INotifyPropertyChanged Implementation

		public event PropertyChangedEventHandler? PropertyChanged;

		protected void OnPropertyChanged([CallerMemberName] string? name = null) =>
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

		#endregion

		#region INotifyDataErrorInfo Implementation

		public bool HasErrors => _errors.Count > 0;

		public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

		public IEnumerable GetErrors(string? propertyName)
		{
			if (propertyName != null && _errors.ContainsKey(propertyName))
				return _errors[propertyName];
			return Array.Empty<string>();
		}

		#endregion
	}
}