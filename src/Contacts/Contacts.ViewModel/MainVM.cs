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
		private bool _skipCancelOnSelectionChange;
		private Contact? _prevContact;

		private Contact? _editSnapshot;
		private bool _isAddingNew;

		private readonly ContactSerializer _serializer = new();

		[ObservableProperty]
		private Contact? _editingContact;

        partial void OnEditingContactChanged(Contact? value)
        {
			if (value != null)
				value.ErrorsChanged += EditingContact_ErrorsChanged;
			ApplyCommand.NotifyCanExecuteChanged();
        }

		private void EditingContact_ErrorsChanged(object sender, System.ComponentModel.DataErrorsChangedEventArgs e) =>
			ApplyCommand.NotifyCanExecuteChanged();

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
			if (IsEditing && !_skipCancelOnSelectionChange)
			{
				if (_isAddingNew && SelectedContact != null)
					Contacts.Remove(SelectedContact);
				else if(_editSnapshot != null && SelectedContact != null)
				{
					SelectedContact.Name = _editSnapshot.Name;
					SelectedContact.PhoneNumber = _editSnapshot.PhoneNumber;
					SelectedContact.Email = _editSnapshot.Email;
				}

				IsEditing = false;
				_editSnapshot = null;
				_isAddingNew = false;
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
			_skipCancelOnSelectionChange = true;
            SelectedContact = new Contact();
			_skipCancelOnSelectionChange = false;

            _isAddingNew = true;
			_editSnapshot = null;
			IsEditing = true;
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
			if(SelectedContact != null)
			{
				_isAddingNew = false;
				_editSnapshot = new Contact
				{
					Name = SelectedContact.Name,
					PhoneNumber = SelectedContact.PhoneNumber,
					Email = SelectedContact.Email
				};
				IsEditing = true;
			}
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

			_skipCancelOnSelectionChange = true;
			if (Contacts.Count > 0)
			{
				if (index >= Contacts.Count) index = Contacts.Count - 1;
				SelectedContact = Contacts[index];
			}
			else
			{
				SelectedContact = null;
			}
			_skipCancelOnSelectionChange = false;
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
			if(EditingContact != null && !EditingContact.HasErrors)
			{
				if (SelectedContact!= null)
				{
					SelectedContact.Name = EditingContact.Name;
					SelectedContact.PhoneNumber = EditingContact.PhoneNumber;
					SelectedContact.Email = EditingContact.Email;
				}
				else
				{
					SelectedContact = EditingContact;
				}
				IsEditing = false;
			}
		}

		/// <summary>
		/// Определяет, доступна ли команда применения изменений.
		/// </summary>
		/// <returns>True, если активен режим редактирования, контакт выбран и не имеет ошибок валидации.</returns>
		private bool CanApply() => IsEditing && EditingContact != null && !EditingContact.HasErrors;

        partial void OnSelectedContactChanged(Contact? value)
		{
			if (_prevContact != null) _prevContact.ErrorsChanged -= OnContactErrorsChanged;
			if (value != null) value.ErrorsChanged += OnContactErrorsChanged;
			_prevContact = value;

			ApplyCommand.NotifyCanExecuteChanged();

            if (!IsEditing)
            {
                EditingContact = value;
            }
        }

		private void OnContactErrorsChanged(object? sender, System.ComponentModel.DataErrorsChangedEventArgs e) =>
			ApplyCommand.NotifyCanExecuteChanged();

        partial void OnIsEditingChanged(bool value)
        {
			if (value)
			{
				EditingContact = SelectedContact != null ? new Contact
				{
					Name = SelectedContact.Name,
					PhoneNumber = SelectedContact.PhoneNumber,
					Email = SelectedContact.Email
				}
				: new Contact();
			}
			else
			{
				EditingContact = SelectedContact;
			}
        }

		private void CancelEditing()
		{
			IsEditing = false;
		}
    }
}