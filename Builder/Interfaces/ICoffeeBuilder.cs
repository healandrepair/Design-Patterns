using Builder.Models;

namespace Builder.Interfaces;

public interface ICoffeeBuilder
{
    public void SetName();
    public void SetType();
    public void SetDescription();
    public void SetPrice();
    public NewCoffee Build();
}