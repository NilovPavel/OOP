using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    public class BaseClass
    {
        private int field;
        protected void GetInfo()
        {
            Console.WriteLine("GetInfo() in BaseClass()");
        }

        public BaseClass()
        {
            Console.WriteLine("Constructor in BaseClass()");
        }

        public BaseClass(int a)
        {
            Console.WriteLine($"Constructor in BaseClass({a})") ;
        }
    }
}
