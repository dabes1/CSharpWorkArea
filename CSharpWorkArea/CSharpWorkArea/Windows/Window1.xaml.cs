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

namespace CSharpWorkArea
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            LoadContents();
        }

        public void LoadContents()
        {
            TxtBlk_Desc.Text = "This window demonstrates usage of a HashSet.";



            CSharpWorkArea.ClassObjects.CSharpObjects HashTblClass = new ClassObjects.CSharpObjects();

            HashSet<int> set1 = HashTblClass.HashSet_Int;
            HashSet<int> set2 = HashTblClass.HashSet_Int2;
        }
    }
}
