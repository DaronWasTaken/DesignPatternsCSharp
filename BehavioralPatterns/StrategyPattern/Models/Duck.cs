using StrategyPattern.Services.Display;
using StrategyPattern.Services.Fly;
using StrategyPattern.Services.Quack;

namespace StrategyPattern.Models
{
    internal class Duck
    {

        private IFlyBehavior? _flyBehavior;
        private IQuackBehavior? _quackBehavior;
        private IDisplayBehavior? _displayBehavior;

        public Duck()
        {

        }

        public Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior, IDisplayBehavior displayBehavior)
        {
            _flyBehavior = flyBehavior;
            _quackBehavior = quackBehavior;
            _displayBehavior = displayBehavior;
        }

        public void Quack()
        {
            _quackBehavior.Quack();
        }

        public void Display()
        {
            _displayBehavior.Display();
        }

        public void Fly()
        {
            _flyBehavior.Fly();
        }

        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            _flyBehavior = flyBehavior;
        }

        public void SetQuackBehavior(IQuackBehavior quackBehavior)
        {
            _quackBehavior = quackBehavior;
        }

        public void SetDisplayBehavior(IDisplayBehavior displayBehavior)
        {
            _displayBehavior = displayBehavior;
        }

        public void BeADuck()
        {
            Fly();
            Quack();
            Display();
        }

    }
}
