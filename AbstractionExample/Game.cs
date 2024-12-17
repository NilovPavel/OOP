using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrike
{
    internal class Game
    {
        public void StartGame(IPlayer player1, IPlayer player2)
        {
            /*Логика игры*/

            //Скажем стреляет 1 игрок
            
            player1.Shoot();
            
            //Стреляет второй игрок
            player2.Shoot();
        }
    }
}
