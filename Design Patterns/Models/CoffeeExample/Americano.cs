namespace Design_Patterns;

public class Americano : CoffeeBase
{
    public Americano()
    {
        Name = "Americano";
        Description = "Black coffee with water";
        Price = 5.5;
    }
    
    public override void Brew()
    {
        Console.WriteLine($"Brewing {this.Name}");
    }

    public override void Drink()
    {
        Console.WriteLine($"Drinking {this.Name}");
    }

    public override void ReadDescription()
    {
        Console.WriteLine(Description);
    }
}   