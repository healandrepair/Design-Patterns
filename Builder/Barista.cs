using Builder.Interfaces;
using Builder.Models;

namespace Builder;

// This is the Director class, which is responsible for calling the builder methods in the correct order.
// Baristas are cool man
public class Barista
{
    private ICoffeeBuilder _coffeeBuilder;

    public void CreateCoffee()
    {
        _coffeeBuilder.SetName();
        _coffeeBuilder.SetDescription();
        _coffeeBuilder.SetPrice();
        _coffeeBuilder.SetType();
    }
    
    public NewCoffee GetCoffee()
    {
        return _coffeeBuilder.Build();
    }

    public void SetCoffeeBuilder(ICoffeeBuilder coffeeBuilder)
    {
        _coffeeBuilder = coffeeBuilder;
    }
}