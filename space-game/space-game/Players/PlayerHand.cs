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
        IList<ICardRepresentation> CardsInHand;

        public PlayerHand()
        {
            CardsInHand = new List<ICardRepresentation>();
        }

        public PlayerHand(int startingCardNumber)
        {
            CardsInHand = new List<ICardRepresentation>(startingCardNumber);
            for (int i = 0; i < startingCardNumber; i++)
            {
                //draft cards
                throw new NotImplementedException();
            }
        }

        public int GetNumberOfCards()
        {
            return CardsInHand.Count;
        }

        public void AddCard(ICardRepresentation newCard)
        {
            CardsInHand.Add(newCard);
        }

        public void ToString()
        {
            short cardNumber = 1;
            foreach (ICardRepresentation card in CardsInHand)
            {
                String.Format("{0}.{1}\n", cardNumber.ToString(), card.ToString());
                cardNumber++;
            }
        }
    }
}
