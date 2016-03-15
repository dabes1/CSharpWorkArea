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

        // constructor
        public CSharpObjects()
        {

        }


    }

    public class HashSetClass
    {
        private HashSet<int> _hashSet_Int;
        private HashSet<int> _hashSet_Int2;
        private HashSet<string> _hashSet_String;

        // constructors
        public HashSetClass()
        {
        }

        // properties:
        public HashSet<int> HashSet_Int
        {
            get
            {
                if (_hashSet_Int != null)
                    return _hashSet_Int;
                return null;
            }
            set
            {
                _hashSet_Int = value;
            }
        }

        public HashSet<int> HashSet_Int2
        {
            get
            {
                if (_hashSet_Int2 != null)
                    return _hashSet_Int2;
                return null;
            }
            set
            {
                _hashSet_Int2 = value;
            }
        }


        public HashSet<string> HashSet_String
        {
            get
            {
                if (_hashSet_String != null)
                    return _hashSet_String;
                return null;
            }
            set
            {
                _hashSet_String = value;
            }
        }


        // public methods
        public void BuildHashSetInt()
        {
            _hashSet_Int = new HashSet<int>();
            for (int i = 1; i < 25; i++)
                _hashSet_Int.Add(i * 5);
        }

        public void BuildHashSetInt2()
        {
            _hashSet_Int2 = new HashSet<int>();
            for (int i = 0; i < 25; i++)
                _hashSet_Int2.Add(i * 3);
        }

        public HashSet<int> UnionIntHashSets(HashSet<int> inSet1, HashSet<int> inSet2)
        {
            HashSet<int> _set1 = new HashSet<int>();
            _set1 = inSet1;
            HashSet<int> _set2 = new HashSet<int>();
            _set2 = inSet2;

            _set1.UnionWith(_set2);
            return _set1;
        }

    }

    public class DictionaryClass
    {
        private Dictionary<int, string> _dict_IntStr;
        private Dictionary<string, string> _dict_StrStr;


        // constructor
        public DictionaryClass()
        {
        }

        // properties
        public Dictionary<int, string> Get_IntStr
        {
            get
            {
                if (_dict_IntStr != null)
                    return _dict_IntStr;
                return null;
            }
            set { _dict_IntStr = value; }
        }
            
        public Dictionary<string, string> Get_StrStr
        {
            get
            {
                if (_dict_StrStr != null)
                    return _dict_StrStr;
                return null;
            }
            set
            {
                _dict_StrStr = value;
            }
        }
            
            


    }
}
