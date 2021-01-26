using GameStore.Abstrack;
using GameStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Concrete
{
    public class GamerManager : IGamerService
    {
        IGamerCheckService _gamerCheck;

        public GamerManager(IGamerCheckService gamerCheck)
        {
            _gamerCheck = gamerCheck;
        }
        public void Add(Gamer gamer)
        {
            if (_gamerCheck.IsThisGamerReal(gamer))
            {
                Console.WriteLine(gamer.FirstName + " kayıt oldu.");
            }
            else
            {
                throw new Exception("Kullanıcı doğrulanamadı.");


            }

        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " kaydını sildi.");

        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " güncellendi.");
        }
    }
}
