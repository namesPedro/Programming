using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;
using System.Windows.Forms;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        private Store _store;

        public MainForm()
        {
            InitializeComponent();
            _store = new Store();

            // Передаем данные из Store во вкладки
            itemsTab1.Items = _store.Items;
            customersTab1.Customers = _store.Customers;
        }
    }
}
