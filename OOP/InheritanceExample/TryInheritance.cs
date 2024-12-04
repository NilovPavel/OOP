using NotInheritanceSpace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotInheritanceSpace
{
    internal class TryInheritance : NotInheritance
        /*, SealedClass*/                           //Запечатанный класс
    {
        //переопределить можно только 
        new static void StaticMethod()
        {
            Console.WriteLine("StaticMethod() класса TryInheritance");
        }
        
        public TryInheritance() : base()
        {
            Console.WriteLine("Выполнение кода конструктора TryInheritance без параметров");
        }

        public TryInheritance(int x)
        {
            a = x;
            Console.WriteLine("Выполнение кода конструктора TryInheritance с передачей 1 параметра");
        }

        public TryInheritance(int number, int number2)
        {
            Console.WriteLine("Выполнение кода конструктора TryInheritance с передачей 2 параметров");
            //this.privateField = number;
        }
    }
}
