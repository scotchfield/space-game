using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Space_game.Enumerations;

namespace Space_game.Interfaces
{
    public interface ICardRepresentation
    {
        ICard GetCard(int card);
    }
}
