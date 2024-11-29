using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleExample
{
    /// <summary>
    /// Интерфейс животного
    /// </summary>
    interface IAnimal
    {
        /// <summary>
        /// Издавать звук
        /// </summary>
        void MakeSound();

        /// <summary>
        /// Начиная с 
        /// </summary>
        public decimal Cost { get; }

        public void GetName()
        { }
    }
}
