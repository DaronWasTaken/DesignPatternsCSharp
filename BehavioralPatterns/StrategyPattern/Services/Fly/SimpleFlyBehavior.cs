using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Services.Fly
{
    internal class SimpleFlyBehavior : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Simple Fly");
        }
    }
}
