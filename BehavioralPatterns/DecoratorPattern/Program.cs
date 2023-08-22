// See https://aka.ms/new-console-template for more information

using DecoratorPattern;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Testing");

        Beverage beverage = new Milk(new Espresso());

        Console.WriteLine(beverage.GetCost());
    }
}