using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
	public class MainVM : INotifyPropertyChanged
	{
		private readonly ContactSerializer _serializer = new();
		private ObservableCollection<Contact> _contacts = new();
		private Contact? _selectedContact;
		private bool _isEditing;

		public ObservableCollection<Contact> Contacts => _contacts;

		public Contact? SelectedContact
		{
			get => _selectedContact;
			set
			{
				if (_selectedContact != value)
				{
					// Если переключаемся во время редактирования -> отменяем изменения
					if (_isEditing) CancelEditing();

					_selectedContact = value;
					OnPropertyChanged();
					OnPropertyChanged(nameof(IsReadOnlyMode));
					CommandManager.InvalidateRequerySuggested();
				}
			}
		}

		public bool IsEditing
		{
			get => _isEditing;
			set
			{
				_isEditing = value;
				OnPropertyChanged();
				OnPropertyChanged(nameof(IsReadOnlyMode));
				CommandManager.InvalidateRequerySuggested();
			}
		}

		public bool IsReadOnlyMode => !_isEditing;

		// Команды
		public ICommand AddCommand { get; }
		public ICommand EditCommand { get; }
		public ICommand RemoveCommand { get; }
		public ICommand ApplyCommand { get; }

		public MainVM()
		{
			LoadContacts();

			AddCommand = new RelayCommand(Add, () => !IsEditing);
			EditCommand = new RelayCommand(Edit, () => !IsEditing && SelectedContact != null);
			RemoveCommand = new RelayCommand(Remove, () => !IsEditing && SelectedContact != null);
			ApplyCommand = new RelayCommand(Apply, () => IsEditing);
		}

		private void LoadContacts()
		{
			var list = _serializer.LoadContacts(); // Теперь вызывает plural-метод
			_contacts.Clear();
			foreach (var c in list) _contacts.Add(c);
		}

		private void SaveContacts()
		{
			_serializer.SaveContacts(_contacts.ToList()); // Теперь вызывает plural-метод
		}

		private void Add()
		{
			IsEditing = true;
			SelectedContact = new Contact();
			Contacts.Add(SelectedContact);
		}

		private void Edit()
		{
			if (SelectedContact != null) IsEditing = true;
		}

		private void Remove()
		{
			if (SelectedContact == null) return;
			int idx = Contacts.IndexOf(SelectedContact);
			Contacts.Remove(SelectedContact);
			SaveContacts();

			if (Contacts.Count > 0)
				SelectedContact = Contacts[idx < Contacts.Count ? idx : Contacts.Count - 1];
			else
				SelectedContact = null;
		}

		private void Apply()
		{
			if (SelectedContact == null) return;
			IsEditing = false;
			SaveContacts();
		}

		private void CancelEditing()
		{
			if (SelectedContact != null && !Contacts.Contains(SelectedContact))
				Contacts.Remove(SelectedContact);
			IsEditing = false;
		}

		public event PropertyChangedEventHandler? PropertyChanged;
		protected void OnPropertyChanged([CallerMemberName] string? name = null) =>
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
	}

	// Встроенный RelayCommand, чтобы не создавать отдельный файл
	public class RelayCommand : ICommand
	{
		private readonly Action _execute;
		private readonly Func<bool> _canExecute;
		public RelayCommand(Action execute, Func<bool>? canExecute = null)
		{
			_execute = execute;
			_canExecute = canExecute ?? (() => true);
		}
		public bool CanExecute(object? parameter) => _canExecute();
		public void Execute(object? parameter) => _execute();
		public event EventHandler? CanExecuteChanged
		{
			add => CommandManager.RequerySuggested += value;
			remove => CommandManager.RequerySuggested -= value;
		}
	}
}