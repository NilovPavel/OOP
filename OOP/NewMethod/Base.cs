using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMethod
{
    internal class Base : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Base's Dispose");
        }
    }
}
