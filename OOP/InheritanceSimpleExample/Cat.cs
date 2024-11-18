using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsInheritance
{
    /// <summary>
    /// Дочерний класс
    /// </summary>
    class Cat : Animal
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="name">Передает кличку животного</param>
        public Cat(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Наследование поведения конструктора из родительского класса
        /// </summary>
        public Cat() : base()
        {
        }
    }
}
