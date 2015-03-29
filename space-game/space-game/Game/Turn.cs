using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Space_game.Enumerations;
using Space_game.Interfaces;

namespace Space_game.Game
{
    class Turn : ITurn
    {
        public TurnActions ChooseAction()
        {
            return TurnActions.Gain2Energy;
        }

        public void UsePlayedCard()
        {

        }

        private void BeginTurn()
        {

        }

        private void EndTurn()
        {

        }


    }
}
