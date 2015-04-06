using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Space_game.Enumerations;
using Space_game.Interfaces;

namespace Space_game.Cards.Defense
{
    class DefenseCard : Card, IDefenseCard
    {
        AttackType DefendsAgainst;
        int DefenseStrength;
        int MaxTurnsToDelay;
        int DefenseLength;

        public DefenseCard()
        {
            EnergyCost = 1;
            DefendsAgainst = AttackType.missile;
            DefenseStrength = 1;
            MaxTurnsToDelay = 0;
            DefenseLength = 1;
            CardName = "Evasive Manuevering";
        }

        public DefenseCard(int energyCost, string cardName, AttackType defendsAgainst, int defenseStrength, int maxTurnsToDelay, int defenseLength)
            : base(energyCost, cardName)
        {
            DefendsAgainst = defendsAgainst;
            DefenseStrength = defenseStrength;
            MaxTurnsToDelay = maxTurnsToDelay;
            DefenseLength = defenseLength;
        }

        public void ToString()
        {
            String.Format("Energy Cost:{0}\tDefends Against:{1}\tDefense Strength:{2}\tDefense Legnth:{3}\tCard Name:{4}",
                EnergyCost, DefendsAgainst.ToString(), DefenseStrength.ToString(), DefenseLength.ToString(), CardName);
        }
    }
}
