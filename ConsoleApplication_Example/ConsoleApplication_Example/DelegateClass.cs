
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Example
{
    class DelegateClass
    {
        public delegate int myDelegate(int a, int b);
            public myDelegate operationType(string type)
         {
            myDelegate objde = null;
            if(type=="add")
            {
                objde = add;
            }
            else if (type == "sub")
            {
                objde = sub;
            }
            else if (type == "mul")
            {
                objde = mul;
            }
            else if (type == "div")
            {
                objde = div;
            }
            return objde;
        }
        private int add(int a,int b)
        {
            return a + b;
        }
        private int sub(int a, int b)
        {
            return a - b;
        }
        private int mul(int a, int b)
        {
            return a * b;
        }
        private int div(int a, int b)
        {
            return a / b;
        }
    }
}
