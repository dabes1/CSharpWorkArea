using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWorkArea.ClassObjects
{
    public class BaseClass
    {

        public int BaseClassValue1 { get; set; }
        public int BaseClassValue2 { get; set; }

        // Constructor
        public BaseClass()
        {
        }

        public virtual void BaseClassMethod1()
        {
            return;
        }

        public virtual void BaseClassMethod2()
        {
            return;
        }
    }
}
