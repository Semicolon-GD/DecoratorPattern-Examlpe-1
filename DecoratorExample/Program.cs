

using DecoratorExample;

IPizza pizza =new Pizza();

IPizza cheeseDecorator=new ExtraCheese(pizza);
IPizza tomatoDecorator=new TomatoDecorator(cheeseDecorator);
IPizza onionDecorator=new OnionDecorator(tomatoDecorator);


Console.WriteLine(onionDecorator.GetPizzaType());
Console.ReadLine();