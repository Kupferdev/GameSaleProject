using GameSaleProject.Abstracts;
using GameSaleProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleProject.Concretes
{
    public class SaleManager : ISaleManager
    {
        public void Sale(Campaign campaign, User user, Game game)
        {
            decimal discountPrice = game.Price * (1 - (campaign.Discount / 100));
            Console.WriteLine($"{user.FirstName} {campaign.Name} kampanyasından yararlanarak {game.Name} oyununu {discountPrice}TL ile aldı!");
        }
    }
}
