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
using System.Collections;

namespace CSharpWorkArea.Windows.Window1s
{
    /// <summary>
    /// Interaction logic for Window1HashTable.xaml
    /// </summary>
    public partial class Window1HashTable : Window
    {
        Label lblAddContent = new Label();
        Hashtable _hashTable = new Hashtable();

        public Window1HashTable()
        {
            InitializeComponent();

            LoadHashTable();
        }

        public void LoadHashTable()
        {
            lblAddContent.Content = "This window demonstrates the use of a HashTable object \"_hashTable\"" + '\n' + '\n';

            // Add some elements to the hash table. There are no duplicate keys, but some of the values are duplicates.
            _hashTable.Add("txt", "notepad.exe");
            _hashTable.Add("bmp", "paint.exe");
            _hashTable.Add("dib", "paint.exe");
            _hashTable.Add("rtf", "wordpad.exe");

            // When you use foreach to enumerate hash table elements, the elements are retrieved as KeyValuePair elements in a DictionaryEntry object.
            lblAddContent.Content += "When you use foreach to enumerate hash table elements, the elements are retrieved as KeyValuePair elements in a DictionaryEntry object." + '\n' + '\n';
            lblAddContent.Content += "Intitial items on the HashTable:" + '\n';
            foreach (DictionaryEntry de in _hashTable)
                lblAddContent.Content += string.Format("Key = {0}, Value = {1}\n", de.Key, de.Value);
            lblAddContent.Content += "\n";

            // The Add method throws an exception if the new key is already in the hash table.
            lblAddContent.Content += "Try to Add an element \"txt\" already in the HashTable.\n";
            lblAddContent.Content += "_hashTable.Add(\"txt\", \"winword.exe\");.\n";
            try
            {
                _hashTable.Add("txt", "winword.exe");
            }
            catch
            {
                lblAddContent.Content += "An element with Key = \"txt\" already exists.\n";
                //Console.WriteLine("An element with Key = \"txt\" already exists.");
            }
            lblAddContent.Content += "\n";

            // The Item property is the default property, so you can omit its name when accessing elements.
            lblAddContent.Content += "The \"Item\" property is the default property, so you can omit its name when accessing elements.\n";
            lblAddContent.Content += "_hashTable[\"rtf\"];\n";
            lblAddContent.Content += string.Format("For key = \"rtf\", value = {0}.\n", _hashTable["rtf"]);
            //Console.WriteLine("For key = \"rtf\", value = {0}.", _hashTable["rtf"]);
            lblAddContent.Content += "\n";

            // The default Item property can be used to change the value associated with a key.
            lblAddContent.Content += "The \"default Item\" property can be used to change the value associated with a key.\n";
            lblAddContent.Content += "_hashTable[\"rtf\"] = \"winword.exe\";\n";
            _hashTable["rtf"] = "winword.exe";
            lblAddContent.Content += string.Format("For key = \"rtf\", value = {0}.\n", _hashTable["rtf"]);
            //Console.WriteLine("For key = \"rtf\", value = {0}.", _hashTable["rtf"]);
            lblAddContent.Content += "\n";

            // If a key does not exist, setting the default Item property for that key adds a new key/value pair.
            lblAddContent.Content += "If a key does not exist, setting the default Item property for that key adds a new key/value pair.\n";
            lblAddContent.Content += "_hashTable[\"doc\"] = \"winword.exe\";\n";
            _hashTable["doc"] = "winword.exe";
            lblAddContent.Content += "So now the items on the HashTable include:" + '\n';
            foreach (DictionaryEntry de in _hashTable)
                lblAddContent.Content += string.Format("Key = {0}, Value = {1}\n", de.Key, de.Value);
            lblAddContent.Content += "\n";

            // ContainsKey can be used to test keys before inserting them.
            lblAddContent.Content += "The \"ContainsKey\" can be used to test keys before inserting them.\n";
            lblAddContent.Content += "if (!_hashTable.ContainsKey(\"ht\") == false) \n";
            lblAddContent.Content += "_hashTable.Add(\"ht\", \"hypertrm.exe\");\n";
            if (!_hashTable.ContainsKey("ht"))
            {
                _hashTable.Add("ht", "hypertrm.exe");
                lblAddContent.Content += string.Format("Value added for key = \"ht\": {0}\n", _hashTable["ht"]);
                //Console.WriteLine("Value added for key = \"ht\": {0}", _hashTable["ht"]);
            }
            lblAddContent.Content += "\n";

            // To get the values alone, use the Values property.
            lblAddContent.Content += "To get the values alone, use the \"Values\" property.\n";
            lblAddContent.Content += "ICollection valueColl = _hashTable.Values;\n";
            ICollection valueColl = _hashTable.Values;
            // The elements of the ValueCollection are strongly typed with the type that was specified for hash table values.
            foreach (string s in valueColl)
                lblAddContent.Content += string.Format("Value = {0}\n", s);
            lblAddContent.Content += "\n";

            // To get the keys alone, use the Keys property.
            lblAddContent.Content += "To get the keys alone, use the \"Keys\" property.\n";
            lblAddContent.Content += "ICollection keyColl = _hashTable.Keys;\n";
            ICollection keyColl = _hashTable.Keys;
            // The elements of the KeyCollection are strongly typed with the type that was specified for hash table keys.
            foreach (string s in keyColl)
                lblAddContent.Content += string.Format("Key = {0}\n", s);
            lblAddContent.Content += "\n";


            // Use the Remove method to remove a key/value pair.
            lblAddContent.Content += "Use the \"Remove\" method to remove a key/value pair.\n";
            lblAddContent.Content += "_hashTable.Remove(\"doc\");\n";
            _hashTable.Remove("doc");
            lblAddContent.Content += "_hashTable.ContainsKey(\"doc\") == false\n";
            if (!_hashTable.ContainsKey("doc"))
            {
                lblAddContent.Content += "Key \"doc\" is not found.\n";
                //Console.WriteLine("Key \"doc\" is not found.");
            }
            lblAddContent.Content += "\n";


            gridHashTable.Children.Add(lblAddContent);

            return;
        }
    }
}
