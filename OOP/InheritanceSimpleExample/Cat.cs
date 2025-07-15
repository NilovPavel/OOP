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
        /// Наследование поведения конструктора из родительского класса
        /// </summary>
        public Cat() : base()
        {
            ;
        }
    }
}
