using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace View.Model
{
	public class Contact : INotifyPropertyChanged
	{
		private string _name = string.Empty;
		private string _phoneNumber = string.Empty;
		private string _email = string.Empty;

		public string Name { get => _name; set { _name = value; OnPropertyChanged(); } }
		public string PhoneNumber { get => _phoneNumber; set { _phoneNumber = value; OnPropertyChanged(); } }
		public string Email { get => _email; set { _email = value; OnPropertyChanged(); } }

		public event PropertyChangedEventHandler? PropertyChanged;
		protected void OnPropertyChanged([CallerMemberName] string? name = null) =>
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
	}
}