using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Space_game.Cards;

namespace Space_game.Interfaces
{
    interface IPlayerHand
    {
        void AddCard(Card newCard);

        int GetNumberOfCards();
    }
}
