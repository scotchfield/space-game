using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Space_game.Enumerations;

namespace Space_game.Interfaces
{
    interface ITurn
    {
        TurnActions ChooseAction();

        void UsePlayedCard();
    }
}
