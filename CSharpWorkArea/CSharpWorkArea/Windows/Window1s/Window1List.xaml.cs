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
    /// Interaction logic for Window1List.xaml
    /// </summary>
    public partial class Window1List : Window
    {
        Label lblAddContent = new Label();
        List<string> _listStrings = new List<string>();
        List<ListObjects> _listObjects = new List<ListObjects>();

        public Window1List()
        {
            InitializeComponent();

            LoadList();
        }

        public void LoadList()
        {
            // List examples from the following link: https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.110).aspx

            lblAddContent.Content += "This demonstrates the use of a List<T> object.\n";
            lblAddContent.Content += "Demo uses various objects as the Type \"T\" in use with the List<T>.\n";
            lblAddContent.Content += "\n";

            lblAddContent.Content += "Part 1 ****************************************\n";
            lblAddContent.Content += "Use of a standard type \"string\" for List<string> object.\n";
            lblAddContent.Content += "This part demonstrated under the context of an organization's hierarchy and managment.\n";

            _listStrings.Add("Mike Brown");
            _listStrings.Add("Troy Blackburn");
            _listStrings.Add("Katie Blackburn");
            _listStrings.Add("Marvin Lewis");
            _listStrings.Add("Ken Zampese");
            _listStrings.Add("Paul Guenther");

            lblAddContent.Content += "Display of the upper management and coaching hierarchy.\n";
            foreach (string item in _listStrings)
                lblAddContent.Content += string.Format("{0}\n", item);
            lblAddContent.Content += "\n";

            lblAddContent.Content += "Using \"Contains\" to determine if an object is in the list.\n";
            lblAddContent.Content += "_listStrings.Contains(\"Ken Zampese\") == true/false";
            if (_listStrings.Contains("Ken Zampese"))
                lblAddContent.Content += "Ken Zampese Found!\n";
            lblAddContent.Content += "\n";

            lblAddContent.Content += "Using \"Capacity\" to get/set the total # of elements the internal data structure can hodl without resizing.\n";
            lblAddContent.Content += "_listStrings.Capacity";
            lblAddContent.Content += string.Format("_listStrings.Capacity : {0}\n", _listStrings.Capacity);
            lblAddContent.Content += "\n";

            lblAddContent.Content += "Using \"Count\" to get the # of elements contained in the List<T>.\n";
            lblAddContent.Content += "_listStrings.Count";
            lblAddContent.Content += string.Format("_listStrings.Count : {0}\n", _listStrings.Count);
            lblAddContent.Content += "\n";


            lblAddContent.Content += "Using \"Insert\" to insert an entry into a specified index.\n";
            lblAddContent.Content += "_listStrings.Insert(3, \"Paul Brown\");\n";
            _listStrings.Insert(3, "Paul Brown");
            lblAddContent.Content += "Re-display of the upper management and coaching hierarchy.\n";
            foreach (string item in _listStrings)
                lblAddContent.Content += string.Format("{0}\n", item);
            lblAddContent.Content += "\n";

            lblAddContent.Content += "Accessing the list using the Item property.\n";
            lblAddContent.Content += string.Format("_listStrings[4]:{0}\n", _listStrings[4]);
            lblAddContent.Content += "\n";

            lblAddContent.Content += "Using \"Remove\" property to remove a specific entry.\n";
            lblAddContent.Content += "_listStrings.Remove(\"Paul Brown\");\n";
            _listStrings.Remove("Paul Brown");
            lblAddContent.Content += "Re-display of the upper management and coaching hierarchy.\n";
            foreach (string item in _listStrings)
                lblAddContent.Content += string.Format("{0}\n", item);
            lblAddContent.Content += "\n";

            lblAddContent.Content += "Using \"TrimExcess()\" property to set the capacity to the actual number of elements in the List<T>, if that number is less than a threshold value.\n";
            lblAddContent.Content += "_listStrings.TrimExcess();\n";
            _listStrings.TrimExcess();
            lblAddContent.Content += string.Format("Capacity: {0}\n", _listStrings.Capacity);
            lblAddContent.Content += string.Format("Count: {0}\n", _listStrings.Count);
            lblAddContent.Content += "\n";

            lblAddContent.Content += "Using \"Clear()\" property to empty out the list\n";
            lblAddContent.Content += "_listStrings.Clear();\n";
            _listStrings.Clear();
            lblAddContent.Content += string.Format("Capacity: {0}\n", _listStrings.Capacity);
            lblAddContent.Content += string.Format("Count: {0}\n", _listStrings.Count);
            lblAddContent.Content += "\n\n";








            lblAddContent.Content += "Part 2 ****************************************\n";
            lblAddContent.Content += "Use of ListObject class which has properties PartName(string), PartId(int).\n";
            lblAddContent.Content += "This part demonstrated undert the predicted starting offense for the 2016 season.\n";

            _listObjects.Add(new ListObjects() { PartName = "QB-A.Dalton",  PartId=14 });
            _listObjects.Add(new ListObjects() { PartName = "RB-G.Bernard", PartId = 25 });
            _listObjects.Add(new ListObjects() { PartName = "RB-J.Hill", PartId = 32 });
            _listObjects.Add(new ListObjects() { PartName = "WR-A.J.Green", PartId = 18 });
            _listObjects.Add(new ListObjects() { PartName = "LT-A.Whitworth", PartId = 77 });
            _listObjects.Add(new ListObjects() { PartName = "LG-K.Zeitler", PartId = 68 });
            _listObjects.Add(new ListObjects() { PartName = "C-R.Bodine", PartId = 61 });
            _listObjects.Add(new ListObjects() { PartName = "RG-C.Boling", PartId = 65 });
            _listObjects.Add(new ListObjects() { PartName = "RT-C.Ogbuehi", PartId = 70 });
            _listObjects.Add(new ListObjects() { PartName = "TE-T.Eifert", PartId = 85 });
            _listObjects.Add(new ListObjects() { PartName = "WR-Rookie", PartId = 82 });

            lblAddContent.Content += "Display of the starting offense:\n";
            foreach (ListObjects item in _listObjects)
                lblAddContent.Content += string.Format("Position: {0},  #{1}\n",item.PartName, item.PartId );
            lblAddContent.Content += "\n";





            // Check the list for _listObject PartId=14. This calls the IEquitable.Equals method of the Part class, which checks the PartId for equality.
            ListObjects test = new ListObjects() { PartName = "QB-A.Dalton", PartId = 14 };
            //Console.WriteLine("\nContains(\"1734\"): {0}",
            if (_listObjects.Contains(test))
            {
                lblAddContent.Content += "Found!\n";
            }


            //for (int i = 0; i < 500; i++)
            //    lblAddContent.Content += string.Format("Current i value:{0}\n", i);



            gridList.Children.Add(lblAddContent);
            return;
        }
    }
}
