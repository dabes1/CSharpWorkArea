using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWorkArea.ClassObjects
{

    // Sealed classes can not be inherited because their contents are 'sealed'
    sealed class SealedClass
    {
        int SealedValue1 { get; set; }
        int SealedValue2 { get; set; }

        public SealedClass()
        {
        }

        public void SealedMethod1()
        {
            return;
        }

        public void SealedMethod2()
        {
            return;
        }

    }
}
