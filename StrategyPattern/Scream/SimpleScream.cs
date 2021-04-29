using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Scream
{
    public class SimpleScream : IScreamable
    {
        public void Scream()
        {
            Console.WriteLine("Simple hero scream!");
        }
    }
}
