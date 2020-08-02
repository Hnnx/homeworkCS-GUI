using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFTuts
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
        }

        private void openPage2_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                Window2 w = new Window2();
                w.Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Prislo je do napake: " + ex.Message, "Napaka", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }
    }
}
