using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Space_game.Interfaces;

namespace Space_game.Cards
{
    class Card
    {
        protected int energyCost;

        virtual public void SpecialEffect(IEnumerable<string> effectNames)
        {
            if (effectNames != null)
            {
                foreach (string effect in effectNames)
                {
                    // call functions specific to that card's special abilities
                }
            }
        }
    }
}
