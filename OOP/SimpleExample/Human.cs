using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleExample
{
    /// <summary>
    /// Класс асбтрактного человека
    /// </summary>
    abstract class Human
    {
        /// <summary>
        /// Имя 
        /// </summary>
        private string name;
        
        /// <summary>
        /// Абстрактный метод
        /// </summary>
        abstract public void JustGo();

        /// <summary>
        /// Получение имени
        /// </summary>
        /// <returns>Значение переменной name</returns>
        public string GetName()
        {
            return this.name;
        }

        public Human(string name)
        {
            this.name = name;
        }
    }
}
