using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Space_game.Cards;
using Space_game.Interfaces;

namespace Space_game.Players
{
    class PlayerHand : IPlayerHand
    {
        List<Card> CardsInHand;

        public PlayerHand()
        {
            CardsInHand = new List<Card>();
        }

        public int GetNumberOfCards()
        {
            return CardsInHand.Count;
        }

        public void AddCard(Card newCard)
        {
            CardsInHand.Add(newCard);
        }
    }
}
