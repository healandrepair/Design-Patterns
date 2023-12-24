using Builder.Interfaces;
using Builder.Models;

namespace Builder;

public class AmericanoBuilder : ICoffeeBuilder
{
    private NewCoffee _coffee = new NewCoffee();

    public void SetName()
    {
        _coffee.Name = "Americano";
    }

    public void SetType()
    {
        _coffee.Type = "Americano";
    }

    public void SetDescription()
    {
        _coffee.Description = "Americano is a black coffee filled up with water.";
    }

    public void SetPrice()
    {
        _coffee.Price = 5.5;
    }

    public NewCoffee Build()
    {
        return _coffee;
    }
}