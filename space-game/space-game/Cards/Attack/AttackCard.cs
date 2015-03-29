using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Space_game.Interfaces;
using Space_game.Enumerations;

namespace Space_game.Cards.Attack
{
    class AttackCard : Card, IAttackCard
    {
        AttackType typeOfAttack;
        int damage;
        int maxTurnsToDelay;

        AttackCard(int weaponCost, AttackType weaponType, int weaponDamage, int weaponDelay)
        {
            this.energyCost = weaponCost;
        }
    }
}
