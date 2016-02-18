using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWorkArea.ClassObjects
{
    public class CSharpObjects
    {
        private List<int> _list_Int;        
        private List<string> _list_Str;

        private HashSet<int> _hashSet_Int;
        private HashSet<int> _hashSet_Int2;
        private HashSet<string> _hashSet_String;

        private Dictionary<int, string> _dict_IntStr;
        private Dictionary<string, string> _dict_StrStr;

        // constructor
        public CSharpObjects()
        {

            _hashSet_Int = new HashSet<int>();
            for (int i = 1; i < 25; i++)            
                _hashSet_Int.Add(i * 5);
            
            _hashSet_Int2 = new HashSet<int>();
            for (int i = 0; i < 25; i++)
                _hashSet_Int2.Add(i * 3);

            _hashSet_Int2.UnionWith(_hashSet_Int);


        }

        // properties:
        public HashSet<int> HashSet_Int
        {
            get
            {
                return _hashSet_Int;
            }
            set
            {
                _hashSet_Int = value;
            }
        }

        public HashSet<string> HashSet_String
        {
            get
            {
                return _hashSet_String;
            }
            set
            {
                _hashSet_String = value;
            }
        }



    }
}
