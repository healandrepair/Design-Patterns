namespace Prototype;

public class Circle : Shape
{
    public int radius { get; set; }

    public Circle()
    {
        
    } 
    
    public Circle(int radius1)
    {
        radius = radius1;
    }
    
    public void printObject()
    {
        base.printObject();
        Console.WriteLine($"radius: {radius}");
    }

    public override object Clone()
    {
        return new Circle(radius);
    }
}