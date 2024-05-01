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
        List<User> users;
        public UserManager()
        {
            users = new List<User>();
        }

        public void Add(User user)
        {
            users.Add(user);
            Console.WriteLine(user.FirstName + " kullanıcısı eklendi.");
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
