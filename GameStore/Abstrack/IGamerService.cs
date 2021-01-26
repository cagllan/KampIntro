using GameStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Abstrack
{
    
        public interface IGamerService
        {
            void Add(Gamer gamer);
            void Update(Gamer gamer);
            void Delete(Gamer gamer);
        }
    
}
