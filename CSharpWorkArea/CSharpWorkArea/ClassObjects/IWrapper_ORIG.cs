using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWorkArea.ClassObjects
{
    interface IWrapper
    {
        int Value1 { get; set; }
        int Value2 { get; set; }

        void GetValue1();
        void GetValue2();
        int ReturnInValue(int inValue);
    }
}
