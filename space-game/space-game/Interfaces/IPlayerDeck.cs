using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Space_game.Cards;

namespace Space_game.Interfaces
{
    public interface IPlayerDeck
    {
        ICardRepresentation DrawTopCard();
    }
}
