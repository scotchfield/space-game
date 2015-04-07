using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

using Space_game.Interfaces;
using Space_game.Cards;

namespace Space_game.Players
{
    public class PlayerDeck : IPlayerDeck
    {
        IList<ICard> Deck;

        public void PlayerDeck()
        {
            Deck = new List<ICard>();
        }

        public ICard DrawTopCard()
        {
            ICard result = Deck.ElementAt<ICard>(0);
            Deck.RemoveAt(0);

            return result;
        }

        public void ToString()
        {
            String.Format("{0} cards in the deck.", GetDeckSize());
        }

        private void DiscardTopCard()
        {

        }

        private void PickTopCard()
        {

        }

        public int GetDeckSize()
        {
            return Deck.Count;
        }
    }
}
