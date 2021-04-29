using StrategyPattern.Fly;
using StrategyPattern.Scream;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Heros
{
    public class IronHero : HeroBase
    {
        public IronHero()
        {
            flyBehavior = new NoFly();
            screamBehavior = new NoScream();
        }
        public override void Display()
        {
            Console.WriteLine("I am an iron hero!");
        }
    }
}
