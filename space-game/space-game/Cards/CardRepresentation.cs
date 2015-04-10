using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Space_game.Interfaces;
using Space_game.Enumerations;

namespace Space_game.Cards
{
    interface CardRepresentation : ICardRepresentation
    {

        ICard GetCard(CardDictionary card)
        {
            throw new NotImplementedException();
        }
    }
}
