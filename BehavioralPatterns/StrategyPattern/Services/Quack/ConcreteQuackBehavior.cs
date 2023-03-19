namespace StrategyPattern.Services.Quack
{
    internal class ConcreteQuackBehavior : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Concrete Quack");
        }
    }
}
