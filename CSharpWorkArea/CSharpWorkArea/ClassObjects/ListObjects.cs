using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWorkArea.ClassObjects
{

    // simple ListObject class for testing with a List<T> object
    public class ListObjects : IEquatable<ListObjects>
    {
        public string PartName { get; set; }
        public int PartId { get; set; }

        //public override bool Equals(object obj)
        //{
        //    if (obj == null)
        //        return false;
        //    ListObjects objA = obj as ListObjects;
        //    if (objA == null)
        //        return false;
        //    return base.Equals(objA);
        //}

        public bool Equals(ListObjects other)
        {
            if (other == null)
                return false;

            return this.PartId.Equals(other.PartId);
            //throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
