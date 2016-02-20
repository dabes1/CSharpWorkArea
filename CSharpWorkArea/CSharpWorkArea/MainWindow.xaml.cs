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
using System.Windows.Navigation;
using System.Windows.Shapes;
// Added usings
using CSharpWorkArea.Windows;


namespace CSharpWorkArea
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
            string _content = "test";
        public MainWindow()
        {
            InitializeContents();

            InitializeComponent();
        }

        public void InitializeContents()
        {
            // The following is causing a null refernce error!!   I HAVE NO IDEA WHY???
            //Btn1.Content = "BTN1";
            //Label1.Content = _content; // "This demonstrates the use of various C# Collections (HashSet<T>, List<T>, Dictionary<T, T>, )";
            //Label2.Content = _content; // "This demonstrates the use of various C# classes (abstract, partial, sealed, static, interface, )";
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Window1 wd1 = new Window1();
            wd1.Show();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Window2 wd2 = new Window2();
            wd2.Show();
        }
    }
}
