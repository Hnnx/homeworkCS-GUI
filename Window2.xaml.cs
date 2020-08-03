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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        
        private void TextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {


            TextBox tb = sender as TextBox;

            statusWindow.Text = "Selection length: " + tb.SelectionLength + Environment.NewLine;
            statusWindow.Text += "Selection index: " + tb.SelectionStart + Environment.NewLine;
            statusWindow.Text += "Selected text: " + tb.SelectedText + "";
        }

        private void prevPage_Click(object sender, RoutedEventArgs e)
        {

            //previous Window:
            Window1 w = new Window1();
            w.Show();
            this.Close();

        }

        private void nextPage_Click(object sender, RoutedEventArgs e)
        {

            Window3 w = new Window3();
            w.Show();
            this.Close();

        }
    }
}
