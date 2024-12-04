using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotInheritanceSpace
{
    /// <summary>
    /// Класс демонстрирующий отсутствие наследования
    /// </summary>
    /*sealed*/ public class NotInheritance
    {
        public static int a = 0;

        /// <summary>
        /// Конструктор не наследуется
        /// </summary>
        public NotInheritance() 
        {
            Console.WriteLine("Выполнение кода конструктора NotInheritance");
        }

        /// <summary>
        /// Виртуальный метод
        /// </summary>
        protected virtual void SealedMethodTest()   //Наследуется в SomeClass
        { }

        /// <summary>
        /// Статичный метод
        /// </summary>
        public static void StaticMethod()
        {
            Console.WriteLine("StaticMethod() класса NotInheritance");
        }

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
