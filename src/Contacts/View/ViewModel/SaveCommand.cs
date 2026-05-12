using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using View.Model.Services;

namespace View.ViewModel
{
	public class SaveCommand : ICommand
	{
		private readonly MainVM _vm;
		public SaveCommand(MainVM vm) => _vm = vm;

		public bool CanExecute(object? parameter) => true;
		public void Execute(object? parameter)
		{
			var serializer = new ContactSerializer();
			serializer.SaveContact(_vm.Contact);
		}
		public event EventHandler? CanExecuteChanged;
	}
}
