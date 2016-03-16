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


            // Add some elements to the hash table. There are no 
            // duplicate keys, but some of the values are duplicates.
            _hashTable.Add("txt", "notepad.exe");
            _hashTable.Add("bmp", "paint.exe");
            _hashTable.Add("dib", "paint.exe");
            _hashTable.Add("rtf", "wordpad.exe");

            // The Add method throws an exception if the new key is 
            // already in the hash table.
            try
            {
                _hashTable.Add("txt", "winword.exe");
            }
            catch
            {
                Console.WriteLine("An element with Key = \"txt\" already exists.");
            }

            // The Item property is the default property, so you 
            // can omit its name when accessing elements. 
            Console.WriteLine("For key = \"rtf\", value = {0}.", _hashTable["rtf"]);

            // The default Item property can be used to change the value
            // associated with a key.
            _hashTable["rtf"] = "winword.exe";
            Console.WriteLine("For key = \"rtf\", value = {0}.", _hashTable["rtf"]);

            // If a key does not exist, setting the default Item property
            // for that key adds a new key/value pair.
            _hashTable["doc"] = "winword.exe";

            // ContainsKey can be used to test keys before inserting 
            // them.
            if (!_hashTable.ContainsKey("ht"))
            {
                _hashTable.Add("ht", "hypertrm.exe");
                Console.WriteLine("Value added for key = \"ht\": {0}", _hashTable["ht"]);
            }

            // When you use foreach to enumerate hash table elements,
            // the elements are retrieved as KeyValuePair objects.
            Console.WriteLine();
            foreach (DictionaryEntry de in _hashTable)
            {
                Console.WriteLine("Key = {0}, Value = {1}", de.Key, de.Value);
            }

            // To get the values alone, use the Values property.
            ICollection valueColl = _hashTable.Values;

            // The elements of the ValueCollection are strongly typed
            // with the type that was specified for hash table values.
            Console.WriteLine();
            foreach (string s in valueColl)
            {
                Console.WriteLine("Value = {0}", s);
            }

            // To get the keys alone, use the Keys property.
            ICollection keyColl = _hashTable.Keys;

            // The elements of the KeyCollection are strongly typed
            // with the type that was specified for hash table keys.
            Console.WriteLine();
            foreach (string s in keyColl)
            {
                Console.WriteLine("Key = {0}", s);
            }

            // Use the Remove method to remove a key/value pair.
            Console.WriteLine("\nRemove(\"doc\")");
            _hashTable.Remove("doc");

            if (!_hashTable.ContainsKey("doc"))
            {
                Console.WriteLine("Key \"doc\" is not found.");
            }


        }
    }
}
