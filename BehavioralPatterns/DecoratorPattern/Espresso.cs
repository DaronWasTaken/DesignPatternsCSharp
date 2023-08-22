namespace DecoratorPattern;

public class Espresso : Beverage
{
    private const int BasePrice = 4;

    public override int GetCost()
    {
        return BasePrice;
    }
}