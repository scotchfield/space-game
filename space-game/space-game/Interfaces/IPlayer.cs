﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_game.Interfaces
{
    interface IPlayer
    {
        void RemoveHullPoints(int damage);
        int GetHullPoints();

    }
}
