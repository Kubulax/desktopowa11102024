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

namespace desktopowa
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

        private void ChangePersonImage(object sender, RoutedEventArgs e)
        {
            int idNumber = int.Parse(personNumber.Text);

            //source images/000-zdjecie.jpg
            if (idNumber == 000)
            {
                personImage.Source = new BitmapImage(new Uri("img/000-zdjecie.jpg", UriKind.RelativeOrAbsolute));
                fingerPrintImage.Source = new BitmapImage(new Uri("img/000-odcisk.jpg", UriKind.RelativeOrAbsolute));
            }
            else if (idNumber == 111)
            {
                personImage.Source = new BitmapImage(new Uri("img/111-zdjecie.jpg", UriKind.RelativeOrAbsolute));
                fingerPrintImage.Source = new BitmapImage(new Uri("img/111-odcisk.jpg", UriKind.RelativeOrAbsolute));

            }
            else if (idNumber == 333)
            {
                personImage.Source = new BitmapImage(new Uri("img/333-zdjecie.jpg", UriKind.RelativeOrAbsolute));
                fingerPrintImage.Source = new BitmapImage(new Uri("img/333-odcisk.jpg", UriKind.RelativeOrAbsolute));
            }
            else
            {
                personImage.Source = null;
                fingerPrintImage.Source = null;
            }
        }

        private void DisplayAddedData(object sender, RoutedEventArgs e)
        {
            string name = personName.Text;
            string surname = personSurname.Text;
            string eyeColor = "";

            if (blue.IsChecked == true)
            {
                eyeColor = "niebieskie";
            }
            else if (green.IsChecked == true)
            {
                eyeColor = "zielone";
            }
            else if (peony.IsChecked == true)
            {
                eyeColor = "piwne";
            }
            else
            {
                eyeColor = "nie wybrano";
            }

            string message = name + " " + surname + " " + "kolor oczu " + eyeColor;

            MessageBox.Show(message, "", MessageBoxButton.OK);
        }
    }
}