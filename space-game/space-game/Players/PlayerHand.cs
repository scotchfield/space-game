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
        IList<ICard> CardsInHand;

        public PlayerHand()
        {
            CardsInHand = new List<ICard>();
        }

        public int GetNumberOfCards()
        {
            return CardsInHand.Count;
        }

        public void AddCard(ICard newCard)
        {
            CardsInHand.Add(newCard);
        }

        public void ToString()
        {
            short cardNumber = 1;
            foreach (ICard card in CardsInHand)
            {
                String.Format("{0}.{1}\n", cardNumber.ToString(), card.ToString());
                cardNumber++;
            }
        }
    }
}
