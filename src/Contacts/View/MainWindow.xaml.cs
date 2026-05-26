using System.Windows;
using View.ViewModel;

namespace View
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