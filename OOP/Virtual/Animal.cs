using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual
{
    class Animal
    {
        private string name = "Animal";

        public virtual string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public virtual void Speak()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }
}
