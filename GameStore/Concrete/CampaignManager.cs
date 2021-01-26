using GameStore.Abstrack;
using GameStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " eklendi.");
        }

        public double Calculation(Game game, Campaign campaign)
        {
            return game.Price - game.Price * 20 / 100;
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " kaldırıldı.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " güncellendi.");
        }
    }
}
