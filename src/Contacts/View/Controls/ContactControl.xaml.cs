using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Contacts.View.Controls
{
	/// <summary>
	/// Пользовательский элемент управления для отображения и редактирования данных контакта.
	/// Содержит поля ввода имени, телефона и email, а также логику фильтрации ввода телефона.
	/// </summary>
	public partial class ContactControl : UserControl
	{
		/// <summary>
		/// Инициализирует новый экземпляр класса ContactControl.
		/// </summary>
		public ContactControl()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Обрабатывает событие предварительного ввода текста в поле телефона.
		/// Блокирует ввод символов, не соответствующих формату номера телефона.
		/// </summary>
		/// <param name="sender">Источник события.</param>
		/// <param name="e">Аргументы события ввода текста.</param>
		private void PhoneTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
		{
			// Разрешаем только цифры, пробелы и символы + - ( )
			e.Handled = !Regex.IsMatch(e.Text, @"^[\d\+\-\(\)\s]$");
		}

		/// <summary>
		/// Обрабатывает событие вставки текста из буфера обмена в поле телефона.
		/// Отменяет вставку, если текст содержит недопустимые символы.
		/// </summary>
		/// <param name="sender">Источник события.</param>
		/// <param name="e">Аргументы события вставки.</param>
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