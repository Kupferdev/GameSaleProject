using GameSaleProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleProject.Abstracts
{
    public interface IUserManager
    {
        void Add(User user);
        void Update(User user);
        void Delete(User user);
    }
}
