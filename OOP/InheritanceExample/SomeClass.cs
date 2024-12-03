using InheritanceExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotInheritanceSpace
{
    //Для демонстрации запрета наследования раскомментировать строку наследования
    internal class SomeClass : NotInheritance
    //: SealedClass
    {
        protected sealed override void SealedMethodTest() //Нельзя переопределить в потомке
        {
        }
    }
}
