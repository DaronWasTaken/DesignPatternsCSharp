namespace DecoratorPattern;

public abstract class AddonDecorator : Beverage
{
    public override int GetCost()
    {
        return 2;
    }
}