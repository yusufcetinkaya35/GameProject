using GameProject;

GamerManager gamerManager = new GamerManager(new UserValidationManager());
gamerManager.Add(new Gamer
{
    Id = 1,
    BirthYear = 1990,
    FirstName = "Yusuf",
    LastName = "Türk",
    IdentityNumber = 12345
});

Console.WriteLine();

GamerManager gamerManager2 = new GamerManager(new NewEStateUserValidationManager());
gamerManager2.Add(new Gamer
{
    Id = 3,
    BirthYear = 1993,
    FirstName = "Yusuf",
    LastName = "Türk",
    IdentityNumber = 12345
});

Console.WriteLine();

CampaignManager campaignManager = new CampaignManager();
campaignManager.Delete(new Campaign { ID = 1, Name = "Yaz Etkinliği" });
campaignManager.Update(new Campaign { ID = 1, Name = "Sonbahar Etkinliği" });
campaignManager.Add(new Campaign { ID = 1, Name = "Kış Etkinliği" });

Console.WriteLine();

GameManager gameManager = new GameManager();
gameManager.Add(new Game
{
    Id = 1,
    CategoryId = 2,
    Name = "Fifa 23",
    UnitPrice = 525,
    UnitInStock = 50
});
GameManager gameManager2 = new GameManager();
gameManager.Update(new Game
{
    Id = 2,
    CategoryId = 4,
    Name = "Uncharted 4",
    UnitPrice = 625,
    UnitInStock = 20
});
GameManager gameManager3 = new GameManager();
gameManager.Delete(new Game
{
    Id = 3,
    CategoryId = 9,
    Name = "OMSI 2",
    UnitPrice = 275,
    UnitInStock = 20
});



