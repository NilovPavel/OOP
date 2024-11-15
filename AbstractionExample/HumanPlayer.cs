using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionExample
{
    abstract internal class HumanPlayer : IPlayer
    {
        private string name;
        public string GetName()
        {
            return this.name;
        }

        public abstract void SaySomethngToOtherPlayer();

        public string Shoot()
        {
            throw new NotImplementedException();
        }

        public HumanPlayer(string name)
        { 
            this.name = name;
        }
    }
}
