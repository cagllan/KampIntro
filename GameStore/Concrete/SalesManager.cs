using GameStore.Abstrack;
using GameStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Concrete
{
    public class SalesManager : ISalesService
    {
        public void Refund(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.FirstName + " " + game.Name + " oyununu iade etti.");
        }

        public void Sales(Gamer gamer, Game game)
        {

            Console.WriteLine(gamer.FirstName + " " + game.Name + " oyununu " + game.Price + " fiyatına aldı.");
        }

        public void SalesDiscount(Gamer gamer, Game game, Campaign campaign)
        {
            game.Price -= game.Price * (campaign.Discount / 100);
            if (game.Price <= 0)
            {
                game.Price = 0;
                Console.WriteLine(gamer.FirstName + " " + game.Name + " oyununu " + campaign.Name + " ile " + game.Price + " TL fiyatına aldı.");

            }
            else
            {
                Console.WriteLine(gamer.FirstName + " " + game.Name + " oyununu " + campaign.Name + " ile %" + campaign.Discount + " indirimli olarak " + game.Price + " TL fiyatına aldı.");
            }

        }
    }
}
