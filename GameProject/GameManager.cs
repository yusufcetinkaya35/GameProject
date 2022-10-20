using System;

namespace GameProject
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name + " Eklendi.");
        }
        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + " Kütüphane'den Silindi.");
        }
        public void Update(Game game)
        {
            Console.WriteLine($"{game.Name} {game.UnitPrice} TL olarak Güncellendi.");
        }
    }
}
