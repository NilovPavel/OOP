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
        /// Получение семейства животных
        /// </summary>
        /// <returns>Возвращает строковое описание</returns>
        public string GetFamily()
        {
            return "Кошачьи";
        }

        /// <summary>
        /// Наследование поведения конструктора из родительского класса
        /// </summary>
        public Cat() : base()
        {
            ;
        }
    }
}
