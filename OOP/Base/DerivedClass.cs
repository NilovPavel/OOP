using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    public class DerivedClass : BaseClass
    {
        
        public void SomeMethod()
        {
            base.GetInfo();
            Console.WriteLine("Constructor in DerivedClass()");
        }

        public DerivedClass() : base()
        {
            Console.WriteLine($"Constructor in DerivedClass()");
        }

        public DerivedClass(int a) : base(a)
        {
            Console.WriteLine($"Constructor in DerivedClass({a})");
        }

        public DerivedClass(string a) : base()
        {
            Console.WriteLine($"Constructor in DerivedClass({a})");
        }
    }
}
