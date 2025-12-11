using OAManage.Command;
using OAManage.models;
using OAManage.ViewModels;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OAManage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AccountViewModel accountViewModel;
        public MainWindow()
        {
            InitializeComponent();
            accountViewModel = new AccountViewModel();
            this.DataContext = accountViewModel;
        }

       



       
    }
}