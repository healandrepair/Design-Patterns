namespace Prototype;

public abstract class Shape : ICloneable
{
    public int _x { get; set; }
    public int _y {get; set;}
    public string _colour { get; set; }
    
    public Shape()
    {
    }

    public void printObject()
    {
        Console.WriteLine($"x: {_x}, y: {_y}, colour: {_colour}");
    }

    public abstract object Clone();
}