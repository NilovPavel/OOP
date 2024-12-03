using NotInheritanceSpace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    internal class TryInheritance : NotInheritance
        /*, SealedClass*/                           //Запечатанный класс
    {
        private void SomeMethod()
        {
            int getViaPublicMethod = this.GetPrivateField();

            this.SetPrivateField(100);
        }

        public TryInheritance(int a) 
        {
            //2. Попытка доступа к sealed

            this.SomeMethod();
        }
    }
}
