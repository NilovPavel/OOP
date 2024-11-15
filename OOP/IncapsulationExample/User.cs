using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncapsulationExample
{
    /// <summary>
    /// Класс пользователя
    /// </summary>
    public class User
    {
        /// <summary>
        /// Приватные поля с именем
        /// </summary>
        private string name;
        private bool isAdmin;

        /// <summary>
        /// Метод получения имени (по сути - интерфейс)
        /// </summary>
        /// <returns>Возвращает значение поля name</returns>
        public string GetName()
        { 
            return name; 
        }

        /// <summary>
        /// Приватный метод - используется только во внутренней работе класса
        /// </summary>
        private void Initialization()
        {
            this.isAdmin = false;
        }

        public User(string name)
        {
            this.name = name;
            this.Initialization();
        }
    }
}
