namespace Design_Patterns;

public class FlatWhite : CoffeeBase
{
    public FlatWhite()
    {
        Name = "Flat White";
        Description = "Espresso with microfoam (steamed milk with fine, velvety bubbles)";
        Price = 6.5;
    }

    public override void Brew()
    {
        Console.WriteLine($"Brewing {this.Name}");
        // Add flat white-specific brewing steps if needed
    }

    public override void Drink()
    {
        Console.WriteLine($"Drinking {this.Name}");
        // Add flat white-specific drinking steps if needed
    }
    
    public override void ReadDescription()
    {
        Console.WriteLine(Description);
    }

    public void LessMilk()
    {
        Console.WriteLine("Less milk");
    }
}