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

namespace CSharpWorkArea.Windows.Window1s
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
            #region HashSet Class
            HashSetClass HashSetClass = new HashSetClass();

            HashSetClass.BuildHashSetInt();
            HashSetClass.BuildHashSetInt2();


            lblHashSet1.Content = "Hash Set# 1:";
            lblHashData1.Content = string.Empty;
            HashSet<int> set1 = HashSetClass.HashSet_Int;
            foreach (int value in set1)
                lblHashData1.Content += string.IsNullOrEmpty((string)(lblHashData1.Content)) ? Convert.ToString(value) : ", " + Convert.ToString(value);


            lblHashSet2.Content = "Hash Set# 2:";
            lblHashData2.Content = string.Empty;
            HashSet<int> set2 = HashSetClass.HashSet_Int2;
            foreach (int value in set2)
                lblHashData2.Content += string.IsNullOrEmpty((string)(lblHashData2.Content)) ? Convert.ToString(value) : ", " + Convert.ToString(value);


            lblUnionSet1_2.Content = "HashSet Set1 Union Set 2";
            lblUnionSet1_2Data.Content = string.Empty;
            HashSet<int> setUnion = HashSetClass.UnionIntHashSets(set1, set2);
            foreach (int value in setUnion)
                lblUnionSet1_2Data.Content += string.IsNullOrEmpty((string)(lblUnionSet1_2Data.Content)) ? Convert.ToString(value) : ", " + Convert.ToString(value);



            lblHashSet3.Content = "Hash Set# 1:";
            lblHashData3.Content = string.Empty;
            set1 = HashSetClass.HashSet_Int;
            foreach (int value in set1)
                lblHashData3.Content += string.IsNullOrEmpty((string)(lblHashData3.Content)) ? Convert.ToString(value) : ", " + Convert.ToString(value);


            lblHashSet4.Content = "Hash Set# 2:";
            lblHashData4.Content = string.Empty;
            set2 = HashSetClass.HashSet_Int2;
            foreach (int value in set2)
                lblHashData4.Content += string.IsNullOrEmpty((string)(lblHashData4.Content)) ? Convert.ToString(value) : ", " + Convert.ToString(value);


            setUnion = HashSetClass.UnionIntHashSets(set2, set1);
            int i = 10;

            #endregion
        }

    }
}
