using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Space_game.Interfaces;
using Space_game.Enumerations;

namespace Space_game.Players
{
    class Player : IPlayer
    {
        string PlayerName;

        int totalEnergy;
        int maxEnergy = 10;

        int Hullpoints;
        PlayerDeck Deck;
        PlayerHand Hand;
        PlayerStatus DeadOrAlive;

        public Player(string playerName)
        {
            PlayerName = playerName;
            totalEnergy = 2;
            DeadOrAlive = PlayerStatus.Alive;
            Deck = new PlayerDeck();
            Hand = new PlayerHand();
        }

        public PlayerStatus GetPlayerStatus()
        {
            return DeadOrAlive;
        }

        public void RemoveHullPoints(int damage)
        {
            this.Hullpoints -= damage;
            if(Hullpoints <= 0)
            {
                DeadOrAlive = PlayerStatus.Dead;
            }
        }

        public int GetHullPoints()
        {
            return Hullpoints;
        }

        private void DrawCards(int nCards)
        {
            ICard result = Deck.DrawTopCard();
            Hand.AddCard(result);
        }

    }
}
