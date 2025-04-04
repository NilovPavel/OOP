﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleExample
{
    internal class Sapper : Human, ISoldier
    {
        public Sapper(string name) : base(name)
        {
        }

        public override void JustGo()
        {
            Console.WriteLine("Пробираюсь по миному полю!");
        }

        /// <summary>
        /// Реализованный метод из интерфейса можно переопределить
        /// </summary>
        internal void SubmitRapport()
        {
            Console.Write($"Сапер {this.GetName()} сдал раппорт!");
        }

        /// <summary>
        /// Реализация метода интерфейса солдата
        /// </summary>
        public void ToDo()
        {
            Console.WriteLine("Явно обезвредить мину!");
        }

        /// <summary>
        /// Определенный только в классе Sapper метод
        /// </summary>
        public void DigGround()
        {
            //todo
        }
    }
}
