using StrategyPattern.Fly;
using StrategyPattern.Heros;
using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My super heros!");
            // Создаём список наших героев
            List<HeroBase> heros = new List<HeroBase>();
            heros.Add(new ExoticHero());
            heros.Add(new SimpleHero());
            heros.Add(new IronHero());

            // Выводим поведение героев
            foreach (var hero in heros)
            {
                hero.Display();
                hero.Move();
                hero.Fly();
                hero.Scream();
                
                Console.WriteLine("---");
            }

            HeroBase upgradableHero = new UpgradableHero();
            upgradableHero.Display();
            upgradableHero.Move();
            upgradableHero.Fly();
            upgradableHero.Scream();
            
            Console.WriteLine("---");
            
            // Замена поведения
            upgradableHero.SetFlyBehavior(new SimpleFly());
            upgradableHero.Fly();

            Console.ReadKey();
        }
    }
}
