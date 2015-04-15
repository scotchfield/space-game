using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Space_game.Interfaces;

namespace Space_game.Cards
{
    public class Card
    {
        protected static int NextCardNumber = 0;

        protected string CardName;
        protected int EnergyCost;
        protected int CardNumber;

        public string GetCardName()
        {
            return CardName;
        }

        public Card()
        {
            SetNextCardNumber();
        }

        public Card(int energyCost, string cardName)
        {
            CardName = cardName;
            EnergyCost = energyCost;
            SetNextCardNumber();
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

        private void SetNextCardNumber()
        {
            CardNumber = NextCardNumber;
            NextCardNumber++;
        }
    }
}
