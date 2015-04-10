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
        AttackType WeaponType;
        int WeaponDamage;
        int MaxTurnsDelay;

        AttackCard()
            : base()
        {
            EnergyCost = 0;
            WeaponType = AttackType.beam;
            WeaponDamage = 1;
            MaxTurnsDelay = 0;
            CardName = "Beam Attack";
        }

        AttackCard(int energyCost, string cardName, AttackType weaponType, int weaponDamage, int weaponDelay) : base(energyCost, cardName)
        {
            WeaponType = weaponType;
            WeaponDamage = weaponDamage;
            MaxTurnsDelay = weaponDelay;
        }

        public void ToString()
        {
            String.Format("Energy Cost:{0}\tWeapon Type:{1}\tWeapon Damage:{2}\tMaxTurnsDelay:{3}\tCard Name:{4}",
                EnergyCost, WeaponType.ToString(), WeaponDamage.ToString(), MaxTurnsDelay.ToString(), CardName);
        }
    }
}
