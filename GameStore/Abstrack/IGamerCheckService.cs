using GameStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Abstrack
{
    public interface IGamerCheckService

    {
        bool IsThisGamerReal(Gamer gamer);
    }
}
