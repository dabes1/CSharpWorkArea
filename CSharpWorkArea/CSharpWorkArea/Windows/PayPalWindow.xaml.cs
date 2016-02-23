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
// Added usings


namespace CSharpWorkArea.Windows
{
    /// <summary>
    /// Interaction logic for PayPalWindow.xaml
    /// </summary>
    public partial class PayPalWindow : Window
    {
        public PayPalWindow()
        {
            InitializeComponent();
            InitializeContents();
        }

        void InitializeContents()
        {
            LblDesc.Content = "This window demonstrates the various Paypal functionalities that we may need";

            Btn1.Content = "Launch";
            Lbl1.Content = "Payment with Credit Card";
        }


        public void Btn1_Click(object sender, RoutedEventArgs e)
        {



        }


    }
}
