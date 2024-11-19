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
        { }

        public BaseClass()
        {
            Console.WriteLine("in BaseClass()");
        }
    }
}
