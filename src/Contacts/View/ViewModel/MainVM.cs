using System.ComponentModel;
using System.Runtime.CompilerServices;
using View.Model;

namespace View.ViewModel
{
	public class MainVM : INotifyPropertyChanged
	{
		private Contact _contact = new();
		public Contact Contact
		{
			get => _contact;
			set { _contact = value; OnPropertyChanged(); OnPropertyChanged(nameof(Name)); OnPropertyChanged(nameof(PhoneNumber)); OnPropertyChanged(nameof(Email)); }
		}

		public string Name { get => Contact.Name; set { Contact.Name = value; OnPropertyChanged(); } }
		public string PhoneNumber { get => Contact.PhoneNumber; set { Contact.PhoneNumber = value; OnPropertyChanged(); } }
		public string Email { get => Contact.Email; set { Contact.Email = value; OnPropertyChanged(); } }

		public SaveCommand SaveCommand { get; }
		public LoadCommand LoadCommand { get; }

		public MainVM()
		{
			SaveCommand = new SaveCommand(this);
			LoadCommand = new LoadCommand(this);
		}

		public event PropertyChangedEventHandler? PropertyChanged;
		protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null) =>
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
}