namespace DecoratorPattern;

public class Milk : AddonDecorator
{
    private readonly Beverage _beverage;
    private const int BasePrice = 2;

    public Milk(Beverage beverage)
    {
        this._beverage = beverage;
    }

    public override int GetCost()
    {
        return _beverage.GetCost() + BasePrice;
    }
}