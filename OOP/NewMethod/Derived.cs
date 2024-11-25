using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMethod
{
    internal class Derived : Base, IDisposable
    {
        new public void Dispose()
        {
            Console.WriteLine("Derived's Dispose");
        }
    }
}
