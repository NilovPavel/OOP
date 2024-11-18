using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsInheritance
{
    /// <summary>
    /// Родительский класс
    /// </summary>
    class Animal
    {
        /// <summary>
        /// Возраст
        /// </summary>
        private int age;        //не будет доступен для наследования, так как private
        
        /// <summary>
        /// Переменная, содержащая имя
        /// </summary>
        protected string name;  //Доступен только внутри класса наследника

        /// <summary>
        /// Получение имени животного
        /// </summary>
        /// <returns>Возвращает переменную name</returns>
        public string GetName()
        {
            return this.name;
        }

        /// <summary>
        /// Конструктор, может наследоваться
        /// </summary>
        public Animal()
        {
            this.name = this.GetType().Name;
        }
    }
}
