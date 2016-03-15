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
// added using
using CSharpWorkArea.ClassObjects;
using CSharpWorkArea.Windows;

namespace CSharpWorkArea.Windows.Window1s
{
    /// <summary>
    /// Interaction logic for TempWindow.xaml
    /// </summary>
    public partial class TempWindow : Window
    {
        public TempWindow()
        {
            InitializeComponent();

            LoadContents();
        }

        public void LoadContents()
        {

            Btn1.Content = "Launch";
            Lbl1.Content = "HashSet Demonstration";

            Btn2.Content = "Launch";
            Lbl2.Content = "List Demonstration";

            Btn3.Content = "Launch";
            Lbl3.Content = "Dictionary Demonstration";

            TxtBlk_Desc.Text = "This window demonstrates the use of various C# Collections (HashSet<T>, List<T>, Dictionary<T, T>, )";

        }

        public void LaunchHashSet(object e, RoutedEventArgs arg)
        {
            Window1HashSet wd = new Window1HashSet();
            wd.Show();
        }
    }
}
