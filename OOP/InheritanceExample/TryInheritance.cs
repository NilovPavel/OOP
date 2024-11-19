using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    internal class TryInheritance : NotInheritance
    {
        private void SomeMethod()
        {
            int getViaPublicMethod = this.GetPrivateField();

            this.SetPrivateField(100);
        }


        public TryInheritance(int a) 
        {
            this.SomeMethod();
        }
    }
}
