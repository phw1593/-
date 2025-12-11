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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Son son = new Son();
            son.MyEvent += ShowSometing;
            son.MyEvent += ShowSometing1;
            son.Show();
        }

        public void ShowSometing(object s,EventArgs e)
        {
            this.text.Text += "OK！！！！";
        }
        public void ShowSometing1(object s, EventArgs e)
        {
            this.text.Text += "NO！！！！";
        }
    }
}