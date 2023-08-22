// See https://aka.ms/new-console-template for more information

using DecoratorPattern;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Testing");

        Espresso espresso = new Espresso();
        Milk milk = new Milk(espresso);

        Console.WriteLine(milk.GetCost());
    }
}