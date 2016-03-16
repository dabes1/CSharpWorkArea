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

namespace CSharpWorkArea.Windows.Windows_Errors
{
    /// <summary>
    /// Interaction logic for WindowErrorMsg.xaml
    /// </summary>
    public partial class WindowErrorMsg : Window
    {
        public WindowErrorMsg()
        {
            InitializeComponent();
        }

        public WindowErrorMsg(string inMsg)
            : this()
        {
            lblMessage.Content = inMsg;
        }
    }
}
