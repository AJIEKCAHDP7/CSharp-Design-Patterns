using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Fly
{
    public class SimpleFly : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I can fly!");
        }
    }
}
