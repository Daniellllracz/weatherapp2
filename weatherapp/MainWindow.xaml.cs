using System.IO;
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

namespace weatherapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Class1> cities;
        public MainWindow()
        {
            InitializeComponent();
            cities = new List<Class1>();
            var sr = new StreamReader("../../../src/cities.txt");
            _ = sr.ReadLine();
            while (!sr.EndOfStream) cities.Add(new Class1(sr.ReadLine(),","));

            varosList.ItemsSource = cities; 

            
        }

    }
}