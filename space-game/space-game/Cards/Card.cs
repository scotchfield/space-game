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
        protected string CardName;
        protected int EnergyCost;

        public string GetCardName()
        {
            return CardName;
        }

        public Card()
        {
            EnergyCost = 0;
        }

        public Card(int energyCost)
        {
            EnergyCost = energyCost;
        }

        public Card(string cardName)
        {
            CardName = cardName;
        }

        public Card(int energyCost, string cardName)
        {
            CardName = cardName;
            EnergyCost = energyCost;
        }

        virtual public void SpecialEffect(IEnumerable<string> effectNames)
        {
            if (effectNames != null)
            {
                foreach (string effect in effectNames)
                {
                    // call functions specific to that card's special abilities
                    throw new NotImplementedException();
                }
            }
        }
    }
}
