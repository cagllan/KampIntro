using GameStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Abstrack
{
    interface ISalesService
    {
        void Sales(Gamer gamer, Game game);
        void SalesDiscount(Gamer gamer, Game game, Campaign campaign);
        void Refund(Gamer gamer, Game game);
    }
}
