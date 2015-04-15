using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Space_game.Interfaces;

namespace Space_game.Players
{
    // For cards that have had their energy cost paid, but not used yet.
    class PlayedCards
    {
        private List<int> _cardsWaiting = new List<int>();

        public void PutCardDown(int cardRepresentation)
        {
            _cardsWaiting.Add(cardRepresentation);
            throw new NotImplementedException();
        }

        public void PlayCard(int cardRepresentation)
        {
            _cardsWaiting.Remove(cardRepresentation);
            throw new NotImplementedException();
        }
    }
}
