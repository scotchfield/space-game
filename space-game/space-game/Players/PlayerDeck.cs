using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Space_game.Interfaces;

namespace Space_game.Players
{
    public class PlayerDeck : IPlayerDeck
    {
        public void DrawCard()
        {
            PickTopCard();
        }

        private void DiscardTopCard()
        {

        }

        private void PickTopCard()
        {

        }

    }
}
