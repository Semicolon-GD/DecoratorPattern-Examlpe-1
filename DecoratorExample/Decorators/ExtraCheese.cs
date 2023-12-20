




using DecoratorExample;

class ExtraCheese : PizzaDecorator
{
    public ExtraCheese(IPizza pizza) : base(pizza)
    {
    }

    public override string GetPizzaType()
    {
        return base.GetPizzaType() + " with extra cheese";
    }
}
