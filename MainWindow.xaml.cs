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

            Track t = new Track();

            t.tracks.Add(new Track { TrackName = "Logatec", Type="Rush", ShortDesc="Hiter tempo po ovinkih do idrije", Location="Logatec, SLO", Length=12.8, Diff="mid/high", LongDesc="Lorem Ipsum long Desc long Desc" });
            t.tracks.Add(new Track { TrackName = "Crni Kal", Type="Rush", ShortDesc="Dolgi ovinki, vista na vrhu, restavracija v sredini", Location="Koper, SLO", Length=4.2, Diff="low/mid", LongDesc="Lorem Ipsum long Desc long Desc" });
            t.tracks.Add(new Track { TrackName = "Vrsic", Type="Climb", ShortDesc="Kratki ostri ovinki, vista na vrhu, pozimi sneg", Location="Vrsic, SLO", Length=8.2, Diff="mid", LongDesc="Lorem Ipsum long Desc long Desc" });

            rideType.ItemsSource = t.tracks;
        }

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {

            if (userName.Text.Length == 0)
            {

                MessageBox.Show($"Username cannot be empty", "Error :(", MessageBoxButton.OK, MessageBoxImage.Error);

            }

            else if (userName.Text.Length >= 16)
            {
                MessageBox.Show($"Username should be between 3 and 16 characters", "Error :(", MessageBoxButton.OK, MessageBoxImage.Error);

            }

            else if (userName.Text.Length <= 2)
            {

                MessageBox.Show($"Username should be between 3 and 16 characters", "Error :(", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            else
            {

            MessageBox.Show($"Welcome, {userName.Text}", "Login Successful",MessageBoxButton.OK);
            }
        }
    }
}
