using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMethod
{
    internal class DevDerived : Derived, IDisposable
    {
        new public void Dispose()
        {
            Console.WriteLine("DevDerived's Dispose");
        }
    }
}
