using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    public class DerivedClass : BaseClass
    {
        
        private void SomeMethod()
        {
            base.GetInfo();
        }

        public DerivedClass() : base()
        {
        }
    }
}
