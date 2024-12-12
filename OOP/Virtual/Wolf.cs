using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual
{
    internal class Wolf : Dog
    {
        /*public override string Name
        {
            get { return "Wolf"; }
        }*/

        public override void Speak()
        {
            Console.WriteLine("Wolf howls");
        }
    }
}
