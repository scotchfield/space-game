using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Space_game.Interfaces;

namespace Space_game.Players
{
    class Player : IPlayer
    {
        int totalEnergy;
        int maxEnergy = 10;

        int Hullpoints;
        PlayerDeck Deck;
        PlayerHand Hand;

        public void RemoveHullPoints(int damage)
        {
            this.Hullpoints -= damage;
        }

        public int GetHullPoints()
        {
            return Hullpoints;
        }

    }
}
