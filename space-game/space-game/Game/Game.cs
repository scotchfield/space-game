using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Space_game.Enumerations;
using Space_game.Interfaces;
using Space_game.Players;

namespace Space_game.Game
{
    // Each game is an instantiation of this object.
    class Game : IGame
    {
        ITurn CurrentTurn;
        List<IPlayer> Players;
        public Game()
        {
            Players.Add(new Player("Player1"));
            Players.Add(new Player("Player2"));
        }

        private void PlayTurn()
        {
            do
            {
                CurrentTurn = new Turn();
            } while (PlayersAlive());
        }


        private bool PlayersAlive()
        {
            bool result = true;

            foreach(Player player in Players)
            {
                if(player.GetPlayerStatus() == PlayerStatus.Dead)
                {
                    result = false;
                }
            }

            return result;
        }


    }
}
