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

namespace CSharpWorkArea.Windows
{
    /// <summary>
    /// Interaction logic for Window1HashSet.xaml
    /// </summary>
    public partial class Window1HashSet : Window
    {
        public Window1HashSet()
        {
            InitializeComponent();

            LoadHashSet();
        }

        public void LoadHashSet()
        {
            CSharpObjects HashTblClass = new CSharpObjects();

            HashTblClass.BuildHashSetInt();
            HashTblClass.BuildHashSetInt2();
            HashTblClass.UnionIntHashSets();

            HashSet<int> set1 = HashTblClass.HashSet_Int;
            HashSet<int> set2 = HashTblClass.HashSet_Int2;

        }
    }
}
