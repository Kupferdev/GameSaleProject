using GameSaleProject.Abstracts;
using GameSaleProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleProject.Concretes
{
    public class UserManager : IUserManager
    {
        IUserCheckManager _userCheckManager;
        List<User> users;
        public UserManager(IUserCheckManager userCheckManager)
        {
            users = new List<User>();
            _userCheckManager = userCheckManager;

        }

        public void Add(User user)
        {
            if (_userCheckManager.IfRealUser(user) == true)
            {
                users.Add(user);
                Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Gerçek kişi değil. Kayıt başarısız!");
            }
        }

        public void Delete(User user)
        {
            User existingUser = users.FirstOrDefault(c => c.Id == user.Id);
            if (existingUser != null)
            {
                users.Remove(existingUser);
                Console.WriteLine("Kullanıcı silindi.");
            }
            else
            {
                Console.WriteLine("Kullanıcı bulunamadı.");
            }
        }

        public void Update(User user)
        {
            User existingUser = users.FirstOrDefault(c => c.Id == user.Id);
            if (existingUser != null)
            {
                existingUser.NatId = user.NatId;
                existingUser.FirstName = user.FirstName;
                existingUser.LastName = user.LastName;
                existingUser.BirthYear = user.BirthYear;
                Console.WriteLine("Kullanıcı başarıyla güncellendi.");
            }
            else
            {
                Console.WriteLine("Kullanıcı bulunamadı.");
            };
        }
    }
}
