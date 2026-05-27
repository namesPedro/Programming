using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Contacts.Model
{
	/// <summary>
	/// Представляет контакт с полями имени, номера телефона и email.
	/// Реализует валидацию данных через интерфейс INotifyDataErrorInfo.
	/// </summary>
	public class Contact : INotifyPropertyChanged, INotifyDataErrorInfo
	{
		private string _name = string.Empty;
		private string _phoneNumber = string.Empty;
		private string _email = string.Empty;

		private readonly Dictionary<string, List<string>> _errors = new();

		/// <summary>
		/// Имя контакта. Максимальная длина — 100 символов.
		/// </summary>
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

		/// <summary>
		/// Номер телефона контакта. Максимальная длина — 100 символов.
		/// Допускаются только цифры и символы + - ( ) и пробелы.
		/// </summary>
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

		/// <summary>
		/// Email-адрес контакта. Максимальная длина — 100 символов.
		/// Должен содержать символ @.
		/// </summary>
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
		/// Выполняет валидацию указанного свойства и обновляет коллекцию ошибок.
		/// </summary>
		/// <param name="propertyName">Имя свойства для валидации.</param>
		/// <param name="value">Значение свойства.</param>
		private void ValidateProperty(string propertyName, object value)
		{
			_errors.Remove(propertyName);
			List<string> errors = new List<string>();
			string strValue = value as string ?? string.Empty;

			if (string.IsNullOrWhiteSpace(strValue))
			{
				errors.Add("Поле не может быть пустым или состоять из пробелов");
			}
			else if (propertyName == nameof(Name))
			{
				if (strValue.Length > 100)
					errors.Add("Имя не должно превышать 100 символов");
			}
			else if (propertyName == nameof(PhoneNumber))
			{
				if (strValue.Length > 100)
					errors.Add("Номер не должен превышать 100 символов");
				// Регулярное выражение: только цифры, пробелы, +, -, (, )
				else if (!Regex.IsMatch(strValue, @"^[\d\+\-\(\)\s]*$"))
					errors.Add("Телефон может содержать только цифры и символы + - ( )");
			}
			else if (propertyName == nameof(Email))
			{
				if (strValue.Length > 100)
					errors.Add("Email не должен превышать 100 символов");
				else if (!strValue.Contains("@"))
					errors.Add("Email должен содержать символ @");
			}

			if (errors.Count > 0)
				_errors[propertyName] = errors;

			ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
		}

		#region INotifyPropertyChanged Implementation

		/// <summary>
		/// Событие, возникающее при изменении свойства.
		/// </summary>
		public event PropertyChangedEventHandler? PropertyChanged;

		/// <summary>
		/// Вызывает событие PropertyChanged для указанного свойства.
		/// </summary>
		/// <param name="name">Имя свойства. Если null, используется имя вызывающего метода.</param>
		protected void OnPropertyChanged([CallerMemberName] string? name = null) =>
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

		#endregion

		#region INotifyDataErrorInfo Implementation

		/// <summary>
		/// Возвращает значение, указывающее, есть ли ошибки валидации.
		/// </summary>
		public bool HasErrors => _errors.Count > 0;

		/// <summary>
		/// Событие, возникающее при изменении коллекции ошибок для свойства.
		/// </summary>
		public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

		/// <summary>
		/// Возвращает коллекцию ошибок для указанного свойства.
		/// </summary>
		/// <param name="propertyName">Имя свойства. Если null, возвращает все ошибки.</param>
		/// <returns>Коллекция строк с сообщениями об ошибках.</returns>
		public IEnumerable GetErrors(string? propertyName)
		{
			if (propertyName != null && _errors.ContainsKey(propertyName))
				return _errors[propertyName];
			return Array.Empty<string>();
		}

		#endregion
	}
}