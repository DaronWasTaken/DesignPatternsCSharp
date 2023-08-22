// See https://aka.ms/new-console-template for more information

using DecoratorPattern;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Testing");

        Espresso espresso = new Espresso();
        AddonMilk addonMilk = new AddonMilk(espresso);

        Console.WriteLine(addonMilk.GetCost());
    }
}