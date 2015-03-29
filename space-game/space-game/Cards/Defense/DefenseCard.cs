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
        AttackType defendsAgainst;
        int defenseStrength;
        int maxTurnsToDelay;


    }
}
