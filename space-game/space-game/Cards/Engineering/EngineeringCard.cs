using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Space_game.Enumerations;
using Space_game.Interfaces;

namespace Space_game.Cards.Engineering
{
    class EngineeringCard : Card, IEngineeringCard
    {
        public EngineeringCard()
            : base()
        {

        }

        public EngineeringCard(string cardName, int energyCost, SpecialEffects cardEffect)
            : base()
        {

        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
