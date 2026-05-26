using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace View.Controls
{
	public partial class ContactControl : UserControl
	{
		public ContactControl()
		{
			InitializeComponent();
		}

		// Запрет ввода символов с клавиатуры
		private void PhoneTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
		{
			// Разрешаем только цифры, пробелы и символы + - ( )
			e.Handled = !Regex.IsMatch(e.Text, @"^[\d\+\-\(\)\s]$");
		}

		// Запрет вставки из буфера обмена
		private void PhoneTextBox_DataObjectPasting(object sender, DataObjectPastingEventArgs e)
		{
			if (e.DataObject.GetDataPresent(DataFormats.Text))
			{
				string text = (string)e.DataObject.GetData(DataFormats.Text);
				if (!Regex.IsMatch(text, @"^[\d\+\-\(\)\s]*$"))
				{
					e.CancelCommand();
				}
			}
			else
			{
				e.CancelCommand();
			}
		}
	}
}