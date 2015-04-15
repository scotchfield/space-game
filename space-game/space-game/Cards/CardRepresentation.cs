using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Space_game.Interfaces;
using Space_game.Enumerations;

namespace Space_game.Cards
{
    public class CardRepresentation : ICardRepresentation
    {
        private Dictionary<int, Card> _representations = new Dictionary<int, Card>();

        public void AddCardRepresentation(int cardNum, Card card)
        {
            _representations.Add(cardNum, card);
        }

        public Card GetCard(int card)
        {
            return _representations[card];
        }
    }
}
