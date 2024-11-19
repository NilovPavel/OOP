using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    /// <summary>
    /// Класс демонстрирующий отсутствие наследования
    /// </summary>
    public class NotInheritance
    {
        /// <summary>
        /// Конструктор не наследуется
        /// </summary>
        public NotInheritance() 
        {
            ;
        }
     
        /// <summary>
        /// Статичный метод (не доступен)
        /// </summary>
        public static void StaticMethod()
        { }

        /// <summary>
        /// Приватный метод
        /// </summary>
        private void Get()
        { }

        /// <summary>
        /// Приватное поле
        /// </summary>
        private int privateField;

        /// <summary>
        /// Получение значения приватного поля
        /// </summary>
        /// <returns></returns>
        public int GetPrivateField()
        {
            return privateField;
        }

        /// <summary>
        /// Запись значения приватного поля
        /// </summary>
        /// <param name="privateValue"></param>
        protected void SetPrivateField(int privateValue) 
        {
            this.privateField = privateValue;
        }
    }
}
