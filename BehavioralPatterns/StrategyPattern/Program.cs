using StrategyPattern.Models;
using StrategyPattern.Services.Display;
using StrategyPattern.Services.Fly;
using StrategyPattern.Services.Quack;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new Duck();

            duck.SetFlyBehavior(new SimpleFlyBehavior());
            duck.SetQuackBehavior(new SimpleQuackBehavior());
            duck.SetDisplayBehavior(new SimpleDisplayBehavior());

            duck.BeADuck();

            duck.SetQuackBehavior(new ConcreteQuackBehavior());

            duck.BeADuck();
        }
    }
}