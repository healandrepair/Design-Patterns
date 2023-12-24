namespace Builder.Models;

public class OldCoffee
{
    public OldCoffee(string name)
    {
        Name = name;
    }
    
    public OldCoffee(string name, string description)
    {
        Name = name;
        Description = description;
    }
    
    public OldCoffee(string name, string description, double price)
    {
        Name = name;
        Description = description;
        Price = price;
    }
    
    public OldCoffee(string name, string description, double price, string type)
    {
        Name = name;
        Description = description;
        Price = price;
        Type = type;
    }

    public double Price { get; set; }

    public string Description { get; set; }

    public string Name { get; set; }
    
    public string Type { get; set; }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Type: {Type}");
    }
}