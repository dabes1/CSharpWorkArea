using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWorkArea.ClassObjects
{
    public abstract class AbstractClass
    {
        int _abstractValue1 = 0;

        AbstractClass()
        {
            _abstractValue1 = 0;
        }

        AbstractClass(int inVal1)
            : this()
        {
            _abstractValue1 = inVal1;
        }

        void AbstractClassMethod1()
        {

        }

        void AbstractClassMethod2()
        {
        }

    }
}
