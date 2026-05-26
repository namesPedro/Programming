using System.Collections.ObjectModel;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Contacts.Model;

namespace Contacts.ViewModel
{
	// 1. Наследуемся от ObservableObject (вместо INotifyPropertyChanged)
	public partial class MainVM : ObservableObject
	{
		private readonly ContactSerializer _serializer = new();

		// 2. [ObservableProperty] автоматически генерирует свойство Contacts
		// и вызывает уведомление при изменении коллекции
		[ObservableProperty]
		private ObservableCollection<Contact> _contacts = new();

		// 3. NotifyCanExecuteChangedFor обновляет доступность кнопок при смене контакта
		[ObservableProperty]
		[NotifyCanExecuteChangedFor(nameof(EditCommand))]
		[NotifyCanExecuteChangedFor(nameof(RemoveCommand))]
		[NotifyCanExecuteChangedFor(nameof(ApplyCommand))]
		private Contact? _selectedContact;

		// 4. Флаг режима редактирования
		[ObservableProperty]
		private bool _isEditing;

		// Метод, вызываемый ПЕРЕД изменением SelectedContact
		// Здесь мы реализуем логику "Отмены" из Задания 3
		partial void OnSelectedContactChanging(Contact? value)
		{
			if (IsEditing)
			{
				CancelEditing();
			}
		}

		public MainVM()
		{
			LoadContacts();
		}

		private void LoadContacts()
		{
			var list = _serializer.LoadContacts();
			Contacts.Clear();
			foreach (var c in list) Contacts.Add(c);
		}

		private void SaveContacts()
		{
			_serializer.SaveContacts(Contacts.ToList());
		}

		// === КОМАНДЫ (Задание 5, шаг 4) ===

		// Add Command
		[RelayCommand(CanExecute = nameof(CanAdd))]
		private void Add()
		{
			IsEditing = true;
			SelectedContact = new Contact();
			Contacts.Add(SelectedContact);
		}
		private bool CanAdd() => !IsEditing;

		// Edit Command
		[RelayCommand(CanExecute = nameof(CanEdit))]
		private void Edit()
		{
			if (SelectedContact != null) IsEditing = true;
		}
		private bool CanEdit() => SelectedContact != null && !IsEditing;

		// Remove Command
		[RelayCommand(CanExecute = nameof(CanRemove))]
		private void Remove()
		{
			if (SelectedContact == null) return;

			int index = Contacts.IndexOf(SelectedContact);
			Contacts.Remove(SelectedContact);
			SaveContacts();

			if (Contacts.Count > 0)
			{
				if (index >= Contacts.Count) index = Contacts.Count - 1;
				SelectedContact = Contacts[index];
			}
			else
			{
				SelectedContact = null;
			}
		}
		private bool CanRemove() => SelectedContact != null && !IsEditing;

		// Apply Command
		[RelayCommand(CanExecute = nameof(CanApply))]
		private void Apply()
		{
			if (SelectedContact != null && !SelectedContact.HasErrors)
			{
				IsEditing = false;
				SaveContacts();
			}
		}

		// Логика блокировки кнопки Apply
		private bool CanApply() => IsEditing && SelectedContact != null && !SelectedContact.HasErrors;

		// Метод отмены редактирования (вызывается при смене контакта)
		private void CancelEditing()
		{
			// Если контакт был создан только что (Add) и не сохранен — удаляем его
			if (SelectedContact != null && !Contacts.Contains(SelectedContact))
			{
				// В простой реализации просто сбрасываем флаг
				// Но если нужно удалить "черновик", то:
				// Contacts.Remove(SelectedContact); 
			}

			IsEditing = false;
		}
	}
}