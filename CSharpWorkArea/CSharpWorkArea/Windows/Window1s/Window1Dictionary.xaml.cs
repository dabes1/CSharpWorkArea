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
// added usings
using CSharpWorkArea.Windows.Windows_Errors;

namespace CSharpWorkArea.Windows.Window1s
{
    /// <summary>
    /// Interaction logic for Window1Dictionary.xaml
    /// </summary>
    public partial class Window1Dictionary : Window
    {
        Label lblAddContent = new Label();
        Dictionary<string, string> openWith = new Dictionary<string, string>();

        public Window1Dictionary()
        {
            InitializeComponent();

            LoadDictionary();
        }

        public void LoadDictionary()
        {

            lblAddContent.Content = "This window demonstrates the use of a Dictionary object \"openWith\"" + '\n' + '\n';

            // Add some elements to the dictionary. There are no duplicate keys, but some of the values are duplicates.
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            lblAddContent.Content += "Intitial items on the dictionary:" + '\n';
            foreach (KeyValuePair<string, string> kvp in openWith)
                lblAddContent.Content += "Key:" + kvp.Key.ToString() + " --  Value:" + kvp.Value.ToString() + '\n';

            lblAddContent.Content += "\n" + "\n";

            // The Add method throws an exception if the new key is already in the dictionary.
            lblAddContent.Content += "Try to Add an element \"txt\" already in the dictionary.\n";
            try
            {
                openWith.Add("txt", "winword.exe");
            }
            catch (ArgumentException)
            {
                lblAddContent.Content += "An element with key = \"txt\" already exists.\n";
                WindowErrorMsg wd = new WindowErrorMsg("An element with key = \"txt\" already exists.");
                wd.Show();
            }
            lblAddContent.Content += "\n";

            // The Item property is another name for the indexer, so you can omit its name when accessing elements. 
            lblAddContent.Content += "Using the \"Item\" property as an indexer \n";
            lblAddContent.Content += "openWith[\"rtf\"]\n";
            lblAddContent.Content += string.Format("For key = \"rtf\", value = {0}.\n\n", openWith["rtf"]);


            // The indexer can be used to change the value associated with a key.
            lblAddContent.Content += "Indexer can be used to change the value associated with a key.\n";
            lblAddContent.Content += "openWith[\"rtf\"] = \"winword.exe\";\n";
            openWith["rtf"] = "winword.exe";
            lblAddContent.Content += string.Format("For key = \"rtf\", value = {0}.\n\n", openWith["rtf"]);
            //Console.WriteLine("For key = \"rtf\", value = {0}.",
            //    openWith["rtf"]);


            // If a key does not exist, setting the indexer for that key adds a new key/value pair.
            lblAddContent.Content += "If a key does not exist, setting the indexer for that key adds a new key/value pair.\n";
            lblAddContent.Content += "openWith[\"doc\"] = \"winword.exe\";\n";
            openWith["doc"] = "winword.exe";
            lblAddContent.Content += string.Format("For key = \"rtf\", value = {0}.\n\n", openWith["doc"]);


            // The indexer throws an exception if the requested key is not in the dictionary.
            lblAddContent.Content += "The indexer throws an exception if the requested key is not in the dictionary.\n";
            lblAddContent.Content += "openWith[\"tif\"]\n";
            try
            {
                lblAddContent.Content += string.Format("For key = \"tif\", value = {0}.\n", openWith["tif"]);
                //Console.WriteLine("For key = \"tif\", value = {0}.", openWith["tif"]);
            }
            catch (KeyNotFoundException)
            {
                lblAddContent.Content += "Key = \"tif\" is not found.\n\n";
                //Console.WriteLine("Key = \"tif\" is not found.");
            }

            // When a program often has to try keys that turn out not to be in the dictionary, TryGetValue can be a more efficient 
            // way to retrieve values.
            lblAddContent.Content += "Using the \"TryGetValue\" to attempt to retrieve values.\n";
            lblAddContent.Content += "openWith.TryGetValue(\"tif\", out value)\n";
            string value = "";
            if (openWith.TryGetValue("tif", out value))
            {
                lblAddContent.Content += string.Format("For key = \"tif\", value = {0}.\n\n", value);
                //Console.WriteLine("For key = \"tif\", value = {0}.", value);
            }
            else
            {
                lblAddContent.Content += "Key = \"tif\" is not found.\n\n";
                //Console.WriteLine("Key = \"tif\" is not found.");
            }

            // ContainsKey can be used to test keys before inserting them.
            lblAddContent.Content += "Using the \"ContainsKey\" to test keys before inserting them.\n";
            lblAddContent.Content += "openWith.ContainsKey(\"ht\") == true/false \n";
            if (!openWith.ContainsKey("ht"))
            {
                openWith.Add("ht", "hypertrm.exe");
                //Console.WriteLine("Value added for key = \"ht\": {0}",
                //    openWith["ht"]);
            }
            lblAddContent.Content += "\n";

            // When you use foreach to enumerate dictionary elements, the elements are retrieved as KeyValuePair objects.
            lblAddContent.Content += "Current Dictionary objects: \n";
            foreach (KeyValuePair<string, string> kvp in openWith)
                lblAddContent.Content += string.Format("Key:{0}, Value:{1} \n", kvp.Key.ToString(),kvp.Value.ToString());
            //Console.WriteLine("Key = {0}, Value = {1}",
            //    kvp.Key, kvp.Value);
            lblAddContent.Content += "\n";


            // To get the keys alone, use the Keys property.
            lblAddContent.Content += "Use the \"Keys\" property to get the collection of keys.\n";
            lblAddContent.Content += "Dictionary<string, string>.KeyCollection keyColl = openWith.Keys;\n";
            Dictionary<string, string>.KeyCollection keyColl =
                openWith.Keys;

            // The elements of the KeyCollection are strongly typed with the type that was specified for dictionary keys.
            lblAddContent.Content += "The key collection consists of:\n";
            foreach (string s in keyColl)
            {
                lblAddContent.Content += string.Format("key:{0}\n", s);
                //Console.WriteLine("Key = {0}", s);
            }
            lblAddContent.Content += "\n";


            // To get the values alone, use the Values property.
            lblAddContent.Content += "Use the \"Values\" property to get the collection of values.\n";
            lblAddContent.Content += "Dictionary<string, string>.ValueCollection valueColl = openWith.Values;\n";
            Dictionary<string, string>.ValueCollection valueColl =
                openWith.Values;

            // The elements of the ValueCollection are strongly typed with the type that was specified for dictionary values.
            lblAddContent.Content += "The value collection consists of:\n";
            foreach (string s in valueColl)
            {
                lblAddContent.Content += string.Format("Value = {0}\n", s);
                //Console.WriteLine("Value = {0}", s);
            }
            lblAddContent.Content += "\n";


            // Use the Remove method to remove a key/value pair.
            lblAddContent.Content += "Use the \"Remove\" method to remove a key/value pair.\n";
            lblAddContent.Content += "openWith.Remove(\"doc\");\n";
            openWith.Remove("doc");
            if (!openWith.ContainsKey("doc"))
            {
                lblAddContent.Content += "Key \"doc\" is not found.\n";
                //Console.WriteLine("Key \"doc\" is not found.");
            }
            lblAddContent.Content += "\n";

            gridDictionary.Children.Add(lblAddContent);
        }

        public void AddCurrentItem()
        {
            try
            {
                openWith.Add("txt", "winword.exe");
            }
            catch (ArgumentException)
            {
                WindowErrorMsg wd = new WindowErrorMsg("An element with key = \"txt\" already exists.");
                wd.Show();
                //Console.WriteLine("An element with Key = \"txt\" already exists.");
            }

        }
    }
}
