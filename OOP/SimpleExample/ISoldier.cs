using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleExample
{
    /// <summary>
    /// Интерфейс солдата
    /// </summary>
    interface ISoldier
    {
        /// <summary>
        /// Чем бы солдат не занимался, лишь бы задолбался
        /// </summary>
        public void ToDo();

        /// <summary>
        /// Здоровье солдата
        /// В C# 8 появилась возможность реализации члена интерфейса по умолчанию:
        /// </summary>
        public int Health
        { 
            get 
            { 
                return 100; 
            } 
        }

        /// <summary>
        /// Сдать раппорт
        /// </summary>
        public void SubmitRapport()
        {
            Console.WriteLine("Солдат сдал раппорт!");
        }
    }
}
