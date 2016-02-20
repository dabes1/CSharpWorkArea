using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWorkArea.ClassObjects
{
    public class Class1FromBaseClass : BaseClass
    {
        private int? _class1Variable1 = null;
        private int? _class2Variable2 = null;

        // constructor
        public Class1FromBaseClass()
            : base()
        {

        }

        public Class1FromBaseClass(int inValue)
            : base()
        {
            base.BaseClassValue1 = inValue;
        }


        public override void BaseClassMethod1()
        {
            if (_class1Variable1 != null  && _class2Variable2 != null)
                _class1Variable1 += _class2Variable2;
        }

    }
}
