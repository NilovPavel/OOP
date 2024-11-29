using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdHocPolymorphism
{
    internal class AdHoc
    {
        public decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public string Add(string a, string b)
        {
            return a + b;
        }
    }
}
