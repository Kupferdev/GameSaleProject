using GameSaleProject.Abstracts;
using GameSaleProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleProject.Concretes
{
    public class UserCheckManager : IUserCheckManager
    {
        public bool IfRealUser(User user)
        {
            if (user.NatId == "74185209631")
            {
                Console.WriteLine($"{user.FirstName} {user.LastName} gerçek bir kullanıcı.");
                return true;
            }
            else return false;
        }
    }
}