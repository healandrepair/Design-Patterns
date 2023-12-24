namespace Design_Patterns;

public class Cappuccino : CoffeeBase
{
    public Cappuccino()
    {
        Name = "Cappuccino";
        Description = "Espresso with steamed milk and a layer of frothed milk";
        Price = 6.0;
    }

    public override void Brew()
    {
        Console.WriteLine($"Brewing {this.Name}");
        // Add cappuccino-specific brewing steps if needed
    }

    public override void Drink()
    {
        Console.WriteLine($"Drinking {this.Name}");
        // Add cappuccino-specific drinking steps if needed
    }
    
    public override void ReadDescription()
    {
        Console.WriteLine(Description);
    }
}