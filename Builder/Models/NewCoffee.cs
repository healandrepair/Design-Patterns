namespace Builder.Models;

public class NewCoffee
{
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public string Type { get; set; }
    
    public void Display()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Type: {Type}");
    }
}