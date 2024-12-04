using NotInheritanceSpace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotInheritanceSpace
{
    internal class SomeClass2 : SomeClass
    {
        protected override void SealedMethodTest() //Нельзя переопределить в потомке
        {
        }
    }
}
