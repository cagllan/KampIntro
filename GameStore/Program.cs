using GameStore.Abstrack;
using GameStore.Concrete;
using GameStore.Entities;
using System;

namespace GameStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game();
            game1.Id = 1;
            game1.Name = "World Of Warcraft: Shadowlands";
            game1.Price = 475;

            Game game2 = new Game();
            game2.Id = 2;
            game2.Name = "Ori and the Blind Forest";
            game2.Price = 31.25;

            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.NationalityId = "12345678901";
            gamer1.FirstName = "Henry";
            gamer1.LastName = "Cavill";
            gamer1.DateOfBirth = new DateTime(1983, 5, 5);

            

            IGamerService gamerManager1 = new GamerManager(new GamerCheckManager()); 
            gamerManager1.Add(gamer1);


            Campaign winterSale = new Campaign();
            winterSale.Id = 2;
            winterSale.Name = "Kış indirimi";
            winterSale.Discount = 50;


            ISalesService salesManager = new SalesManager();
            salesManager.SalesDiscount(gamer1, game1, winterSale);
            salesManager.Sales(gamer1, game2);



        }
    }
}
