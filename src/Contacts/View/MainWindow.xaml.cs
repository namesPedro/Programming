using System.Windows;
using Contacts.ViewModel;

namespace Contacts.View
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			DataContext = new MainVM();
		}
	}
}