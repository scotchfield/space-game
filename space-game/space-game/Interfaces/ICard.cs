using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// every card should be a
namespace Space_game.Interfaces
{
    interface ICard
    {
        void SpecialEffect(IEnumerable<string> effectNames);

    }
}
