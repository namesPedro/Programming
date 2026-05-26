using System.Collections.ObjectModel;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Contacts.Model;

namespace Contacts.ViewModel
{
	/// <summary>
	/// ViewModel для управления коллекцией контактов.
	/// Реализует добавление, редактирование, удаление и сохранение контактов.
	/// </summary>
	public partial class MainVM : ObservableObject
	{
		private readonly ContactSerializer _serializer = new();

		/// <summary>
		/// Коллекция контактов, привязанная к списку в интерфейсе.
		/// </summary>
		[ObservableProperty]
		private ObservableCollection<Contact> _contacts = new();

		/// <summary>
		/// Выбранный в списке контакт. Используется для отображения и редактирования данных.
		/// </summary>
		[ObservableProperty]
		[NotifyCanExecuteChangedFor(nameof(EditCommand))]
		[NotifyCanExecuteChangedFor(nameof(RemoveCommand))]
		[NotifyCanExecuteChangedFor(nameof(ApplyCommand))]
		private Contact? _selectedContact;

		/// <summary>
		/// Флаг, указывающий, активен ли режим редактирования или добавления контакта.
		/// </summary>
		[ObservableProperty]
		private bool _isEditing;

		/// <summary>
		/// Вызывается перед изменением свойства SelectedContact.
		/// Отменяет незавершённое редактирование при смене выбора.
		/// </summary>
		/// <param name="value">Новое значение выбранного контакта.</param>
		partial void OnSelectedContactChanging(Contact? value)
		{
			if (IsEditing)
			{
				CancelEditing();
			}
		}

		/// <summary>
		/// Инициализирует новый экземпляр класса MainVM и загружает контакты из файла.
		/// </summary>
		public MainVM()
		{
			LoadContacts();
		}

		/// <summary>
		/// Загружает контакты из файла и заполняет коллекцию.
		/// </summary>
		private void LoadContacts()
		{
			var list = _serializer.LoadContacts();
			Contacts.Clear();
			foreach (var c in list) Contacts.Add(c);
		}

		/// <summary>
		/// Сохраняет текущую коллекцию контактов в файл.
		/// </summary>
		private void SaveContacts()
		{
			_serializer.SaveContacts(Contacts.ToList());
		}

		/// <summary>
		/// Создает новый пустой контакт и переходит в режим редактирования.
		/// </summary>
		[RelayCommand(CanExecute = nameof(CanAdd))]
		private void Add()
		{
			IsEditing = true;
			SelectedContact = new Contact();
			Contacts.Add(SelectedContact);
		}

		/// <summary>
		/// Определяет, доступна ли команда добавления контакта.
		/// </summary>
		/// <returns>True, если не активен режим редактирования.</returns>
		private bool CanAdd() => !IsEditing;

		/// <summary>
		/// Переводит выбранный контакт в режим редактирования.
		/// </summary>
		[RelayCommand(CanExecute = nameof(CanEdit))]
		private void Edit()
		{
			if (SelectedContact != null) IsEditing = true;
		}

		/// <summary>
		/// Определяет, доступна ли команда редактирования.
		/// </summary>
		/// <returns>True, если контакт выбран и не активен режим редактирования.</returns>
		private bool CanEdit() => SelectedContact != null && !IsEditing;

		/// <summary>
		/// Удаляет выбранный контакт из коллекции и сохраняет изменения.
		/// </summary>
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

		/// <summary>
		/// Определяет, доступна ли команда удаления.
		/// </summary>
		/// <returns>True, если контакт выбран и не активен режим редактирования.</returns>
		private bool CanRemove() => SelectedContact != null && !IsEditing;

		/// <summary>
		/// Завершает редактирование и сохраняет изменения контакта.
		/// </summary>
		[RelayCommand(CanExecute = nameof(CanApply))]
		private void Apply()
		{
			if (SelectedContact != null && !SelectedContact.HasErrors)
			{
				IsEditing = false;
				SaveContacts();
			}
		}

		/// <summary>
		/// Определяет, доступна ли команда применения изменений.
		/// </summary>
		/// <returns>True, если активен режим редактирования, контакт выбран и не имеет ошибок валидации.</returns>
		private bool CanApply() => IsEditing && SelectedContact != null && !SelectedContact.HasErrors;

		/// <summary>
		/// Отменяет незавершённое редактирование или добавление контакта.
		/// </summary>
		private void CancelEditing()
		{
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