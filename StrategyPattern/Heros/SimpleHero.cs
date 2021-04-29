using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Heros
{
    public class SimpleHero : HeroBase
    {
        public override void Display()
        {
            Console.WriteLine("I am a simple hero!");
        }

    }
}
