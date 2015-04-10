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
        IEnumerable<ICardRepresentation> CardsWaiting;
    }
}
