using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            CharacterDirector director = new CharacterDirector();

            ICharacterBuilder heroBuilder = new HeroBuilder();
            Character hero = director.CreateHero(heroBuilder);
            Console.WriteLine("HERO:");
            Console.WriteLine(hero);

            ICharacterBuilder enemyBuilder = new EnemyBuilder();
            Character enemy = director.CreateEnemy(enemyBuilder);
            Console.WriteLine("\nENEMY:");
            Console.WriteLine(enemy);

            Console.ReadLine();
        }
    }
}
