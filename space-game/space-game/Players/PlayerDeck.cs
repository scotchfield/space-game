using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Space_game.Interfaces;
using Space_game.Cards;

namespace Space_game.Players
{
    public class PlayerDeck : IPlayerDeck
    {
        private List<ICardRepresentation> _deck;

        public PlayerDeck()
        {
            _deck = new List<ICardRepresentation>();
        }

        public ICardRepresentation DrawTopCard()
        {
            ICardRepresentation result = _deck.ElementAt<ICardRepresentation>(0);
            _deck.RemoveAt(0);

            return result;
        }

        public List<ICardRepresentation> DrawTopCards(int nCards)
        {
            IEnumerable<ICardRepresentation> result = _deck.Take(nCards);
            _deck.RemoveRange(0, nCards);

            return result.ToList();
        }

        public void ToString()
        {
            String.Format("{0} cards in the deck.", GetDeckSize());
        }

        public ICardRepresentation DiscardTopCard()
        {
            return DrawTopCard();
        }

        public int GetDeckSize()
        {
            return _deck.Count;
        }
    }
}
