using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_game.Cards.Attack
{
    public interface IAttackCard
    {
        void SpecialEffect(IEnumerable<string> effectNames);
        string ToString();
    }
}
