using GameSaleProject.Concretes;
using GameSaleProject.Entities;

//Kullanıcı Doğrulama (!)
UserCheckManager userCheckManager = new UserCheckManager();
User user = new User();
user.Id = 1;
user.NatId = "74185209631";
user.FirstName = "Ahmet";
user.LastName = "Bakır";
user.BirthYear = "2000";
userCheckManager.IfRealUser(user); //True

//Kullanıcı ekleme
UserManager userManager = new UserManager();
userManager.Add(user);

//Kampanya ekleme
CampaignManager campaignManager = new CampaignManager();
Campaign campaign = new Campaign { Id = 1, Name = "Black Friday", Discount = 45};
campaignManager.Add(campaign);

//Oyun ekleme
GameManager gameManager = new GameManager();
Game game1 = new Game { Id = 1, Name = "NFS2", Description = "Car Game", Price = 256 };
gameManager.Add(game1);

//Satış 
SaleManager saleManager = new SaleManager();
saleManager.Sale(campaign, user, game1);