using GameStore.Abstrack;
using GameStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Concrete
{
    public class GamerCheckManager : IGamerCheckService
    {
        public bool IsThisGamerReal(Gamer gamer)
        {
            if (gamer.NationalityId.Length == 11 && gamer.FirstName != null && gamer.LastName != null && gamer.DateOfBirth.Year  > 1900)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
