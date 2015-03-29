using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_game.Interfaces
{
    interface ITurn
    {
        void BeginTurn();
        void ChooseAction();

        void PlayCard();
        void Gain1Energy1Card();
        void Gain2Energy();

        void UsePlayedCard();
        void EndTurn();
    }
}
