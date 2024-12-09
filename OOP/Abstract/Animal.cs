using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    /// <summary>
    /// Абстрактный класс
    /// </summary>
    public abstract class Animal
    {
        private string name;
        public abstract void MakeSound();
        public string GetName()
        {
            return this.name;
        }
        public Animal(string name)
        { 
            this.name = name; 
        }
    }
}
