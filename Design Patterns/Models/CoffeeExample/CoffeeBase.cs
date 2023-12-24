using Design_Patterns.Interaces;

namespace Design_Patterns;

public abstract class CoffeeBase : ICoffee
{
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }

    public abstract void Brew();

    public abstract void Drink();

    public abstract void ReadDescription();
}