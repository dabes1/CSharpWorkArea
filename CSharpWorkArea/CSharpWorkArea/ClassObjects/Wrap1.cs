using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWorkArea.ClassObjects
{
    public class Wrap1 : IWrapper
    {
        public int Value1 { get; set; }
        public int Value2 { get; set; }

        public Wrap1()
        {
            Value1 = 1;
            Value2 = 2;
        }

        public  void GetValue1()
        {
            return;
        }

        public void GetValue2()
        {
            return;
        }

        public int ReturnInValue(int inValue)
        {
            return inValue;
        }
    }
}
