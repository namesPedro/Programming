using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace View.Model
{
	public class Contact : INotifyPropertyChanged, INotifyDataErrorInfo
	{
		private string _name = string.Empty;
		private string _phoneNumber = string.Empty;
		private string _email = string.Empty;
		private readonly Dictionary<string, List<string>> _errors = new();

		public string Name
		{
			get => _name;
			set { _name = value; OnPropertyChanged(); ValidateProperty(nameof(Name), value); }
		}
		public string PhoneNumber
		{
			get => _phoneNumber;
			set { _phoneNumber = value; OnPropertyChanged(); ValidateProperty(nameof(PhoneNumber), value); }
		}
		public string Email
		{
			get => _email;
			set { _email = value; OnPropertyChanged(); ValidateProperty(nameof(Email), value); }
		}

		private void ValidateProperty(string propertyName, object value)
		{
			var errors = new List<string>();
			var str = value as string ?? string.Empty;

			if (propertyName == nameof(Name))
			{
				if (str.Length > 100) errors.Add("Длина не более 100 символов");
			}
			else if (propertyName == nameof(PhoneNumber))
			{
				if (str.Length > 100) errors.Add("Длина не более 100 символов");
				else if (!Regex.IsMatch(str, @"^[\d\+\-\(\)\s]*$")) errors.Add("Только цифры и символы + - ( )");
			}
			else if (propertyName == nameof(Email))
			{
				if (str.Length > 100) errors.Add("Длина не более 100 символов");
				else if (!str.Contains("@")) errors.Add("Должен содержать символ @");
			}

			if (errors.Count > 0)
				_errors[propertyName] = errors;
			else
				_errors.Remove(propertyName);

			ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
		}

		public bool HasErrors => _errors.Count > 0;
		public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;
		public IEnumerable GetErrors(string? propertyName) =>
			propertyName != null && _errors.ContainsKey(propertyName) ? _errors[propertyName] : Array.Empty<string>();

		public event PropertyChangedEventHandler? PropertyChanged;
		protected void OnPropertyChanged([CallerMemberName] string? name = null) =>
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
	}
}