using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Contacts.View.Converters
{
	/// <summary>
	/// Конвертер значений, преобразующий логическое значение в видимость элемента интерфейса.
	/// True → Visible, False → Collapsed.
	/// </summary>
	public class BoolToVisibilityConverter : IValueConverter
	{
		/// <summary>
		/// Преобразует значение bool в значение Visibility.
		/// </summary>
		/// <param name="value">Входное значение (bool).</param>
		/// <param name="targetType">Целевой тип (не используется).</param>
		/// <param name="parameter">Дополнительный параметр (не используется).</param>
		/// <param name="culture">Культура (не используется).</param>
		/// <returns>Visibility.Visible, если значение true; иначе Visibility.Collapsed.</returns>
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
			=> (value is bool b && b) ? Visibility.Visible : Visibility.Collapsed;

		/// <summary>
		/// Преобразует значение Visibility в значение bool.
		/// </summary>
		/// <param name="value">Входное значение (Visibility).</param>
		/// <param name="targetType">Целевой тип (не используется).</param>
		/// <param name="parameter">Дополнительный параметр (не используется).</param>
		/// <param name="culture">Культура (не используется).</param>
		/// <returns>True, если значение равно Visibility.Visible; иначе false.</returns>
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
			=> value is Visibility v && v == Visibility.Visible;
	}
}