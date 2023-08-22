namespace DecoratorPattern;

public class AddonMilk : Beverage
{
    private readonly Beverage _beverage;
    private const int BasePrice = 2;

    public AddonMilk(Beverage beverage)
    {
        this._beverage = beverage;
    }

    public override int GetCost()
    {
        return _beverage.GetCost() + BasePrice;
    }
}