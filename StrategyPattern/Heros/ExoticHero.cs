using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Heros
{
    public class ExoticHero : HeroBase
    {
        // Переопределяем метод - экзотический герой 
        public override void Display()
        {
            Console.WriteLine("I am an exotic hero!");
        }

    }
}
