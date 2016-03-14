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

        public void UnionIntHashSets()
        {
            if (_hashSet_Int != null && _hashSet_Int2 != null)
            _hashSet_Int2.UnionWith(_hashSet_Int);
        }
    }
}
