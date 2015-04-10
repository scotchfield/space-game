using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Describes the axiomatic card, all cards in the player's hands, decks, and in play refer to one object that is a child of ICard.
namespace Space_game.Interfaces
{
    public interface ICard
    {
        void SpecialEffect(IEnumerable<string> effectNames);
    }
}
