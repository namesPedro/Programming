using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using View.Model.Services;

namespace View.ViewModel
{
	public class LoadCommand : ICommand
	{
		private readonly MainVM _vm;
		public LoadCommand(MainVM vm) => _vm = vm;

		public bool CanExecute(object? parameter) => true;
		public void Execute(object? parameter)
		{
			var serializer = new ContactSerializer();
			var loaded = serializer.LoadContact();
			if (loaded != null)
				_vm.Contact = loaded; // Автоматически обновит все свойства через INotifyPropertyChanged
		}
		public event EventHandler? CanExecuteChanged;
	}
}
