using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Reflection;

namespace WPFTuts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
                
            Person x = new Person();

            x.people.Add(new Person { firstName = "Jozo", lastName = "Bozo" });
            x.people.Add(new Person { firstName = "Hanzo", lastName = "Panzo" });
            x.people.Add(new Person { firstName = "Fidi", lastName = "Dido" });

            cBox.ItemsSource = x.people;
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hello {userName.Text}", "Greeting");
        }

        private void nextWin_Click(object sender, RoutedEventArgs e)
        {
            Window1 win1 = new Window1();
            this.Close();
            win1.Show();
        }
    }
}
