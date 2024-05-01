using GameSaleProject.Abstracts;
using GameSaleProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleProject.Concretes
{
    public class CampaignManager : ICampaignManager
    {
        List<Campaign> campaigns;
        public CampaignManager()
        {
            campaigns = new List<Campaign>();
        }

        public void Add(Campaign campaign)
        {
            campaigns.Add(campaign);
            Console.WriteLine($"{campaign.Name} kaydedildi.");
        }

        public void Remove(Campaign campaign)
        {
            Campaign existingCampaign = campaigns.FirstOrDefault(c => c.Id == campaign.Id);
            if (existingCampaign != null)
            {
                campaigns.Remove(campaign);
                Console.WriteLine("Kampanya silindi.");
            }
            else
            {
                Console.WriteLine("Kampanya bulunamadı.");
            }
        }

        public void Update(Campaign campaign)
        {
            Campaign existingCampaign = campaigns.FirstOrDefault(c => c.Id == campaign.Id);
            if (existingCampaign != null)
            {
                existingCampaign.Name = campaign.Name;
                existingCampaign.Discount = campaign.Discount;
                Console.WriteLine("Kampanya başarıyla güncellendi.");
            }
            else
            {
                Console.WriteLine("Kampanya bulunamadı.");
            };
        }
    }
}
