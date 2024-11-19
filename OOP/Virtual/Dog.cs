using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual
{
    class Dog : Animal
    {
        public override string Name { get; set; }

        //Если сделать метод запечатанным,
        //то переопределение не будет возможным
        //sealed
        public override void Speak()
        {
            Console.WriteLine("Dog barks");
        }
    }
}
