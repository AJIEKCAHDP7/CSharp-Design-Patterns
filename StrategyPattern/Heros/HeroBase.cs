using StrategyPattern.Fly;
using StrategyPattern.Scream;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Heros
{
    // Базовый класс - герой
    public abstract class HeroBase
    {
        protected IFlyable flyBehavior;
        protected IScreamable screamBehavior;
        
        public HeroBase()
        {
            flyBehavior = new SimpleFly();
            screamBehavior = new SimpleScream();
        }

        public void SetScreamBehavior(IScreamable newScreamBehavior)
        {
            screamBehavior = newScreamBehavior;
        }

        public void SetFlyBehavior(IFlyable newFlyBehavior)
        {
            flyBehavior = newFlyBehavior;
        }

        // Герой может двигаться
        public void Move()
        {
            Console.WriteLine("I can move...");
        }

        // Герой может кричать
        public void Scream() 
        {
            screamBehavior.Scream();
        }

        // Герой летать
        public void Fly()
        {
            flyBehavior.Fly();
        }

        // Абстрактный метод - Вывод героя 
        public abstract void Display();
    }
}
