

using DecoratorExample;

class OnionDecorator : PizzaDecorator
{
    public OnionDecorator(IPizza pizza) : base(pizza)
    {
    }

    public override string GetPizzaType()
    {
        return base.GetPizzaType() + " with onion";
    }
}