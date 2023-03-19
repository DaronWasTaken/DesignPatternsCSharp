using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Services.Quack
{
    internal class SimpleQuackBehavior : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Simple Quack");
        }
    }
}
