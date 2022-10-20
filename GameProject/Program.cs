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
