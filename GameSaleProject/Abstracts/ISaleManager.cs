using GameSaleProject.Concretes;
using GameSaleProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleProject.Abstracts
{
    public interface ISaleManager
    {
        void Sale(Campaign campaign, User user, Game game);
    }
}
