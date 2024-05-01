using GameSaleProject.Abstracts;
using GameSaleProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleProject.Concretes
{
    public class GameManager : IGameManager
    {
        List<Game> games;
        public GameManager()
        {
            //Game game1 = new Game { Id = 1, Name = "NFS2", Description = "Car Game", Price = 256 };
            //Game game2 = new Game { Id = 2, Name = "NFS Carbon", Description = "Car Game", Price = 128 };
            //Game game3 = new Game { Id = 1, Name = "NFS", Description = "Car Game", Price = 86 };
            games = new List<Game>();
        }
        public void Add(Game game)
        {
            games.Add(game);
            Console.WriteLine(game.Name + " kaydedildi.");
        }

        public void Delete(Game game)
        {
            Game existingGame = games.FirstOrDefault(c => c.Id == game.Id);
            if (existingGame != null)
            {
                games.Remove(existingGame);
                Console.WriteLine("Oyun silindi.");
            }
            else
            {
                Console.WriteLine("Oyun bulunamadı.");
            }
        }

        public List<Game> GetAllGames()
        {
            return games;
        }

        public void Update(Game game)
        {
            Game existingGame = games.FirstOrDefault(c => c.Id == game.Id);
            if (existingGame != null)
            {
                existingGame.Name = game.Name;
                existingGame.Description = game.Description;
                existingGame.Price = game.Price;
                Console.WriteLine("Oyun başarıyla güncellendi.");
            }
            else
            {
                Console.WriteLine("Oyun bulunamadı.");
            };
        }
    }
}