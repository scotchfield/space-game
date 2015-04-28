using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Space_game.Game;

namespace Space_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Game.Game HotSeat = new Space_game.Game.Game();
            HotSeat.PlayGame();

        }
    }
}
