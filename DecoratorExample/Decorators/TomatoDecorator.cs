




using DecoratorExample;

class TomatoDecorator : PizzaDecorator
{
    public TomatoDecorator(IPizza pizza) : base(pizza)
    {
    }

    public override string GetPizzaType()
    {
        return base.GetPizzaType() + " with tomato";
    }
}
