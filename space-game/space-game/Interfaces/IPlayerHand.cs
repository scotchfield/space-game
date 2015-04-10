using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Space_game.Cards;

namespace Space_game.Interfaces
{
    public interface IPlayerHand
    {
        void AddCard(ICardRepresentation newCard);

        int GetNumberOfCards();

        void ToString();
    }
}
