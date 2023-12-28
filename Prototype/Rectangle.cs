namespace Prototype;

public class Rectangle : Shape
{
    public int width { get; set; }
    
    public int height { get; set; }

    public Rectangle()
    {
        
    }

    public Rectangle(int widthToCreate, int heightToCreate)
    {
        width = widthToCreate;
        height = heightToCreate;
    }

    public void printObject()
    {
        base.printObject();
        Console.WriteLine($"width: {width}, height: {height}");
    }
    
    // subclass clone method
    public override object Clone()
    {
        return new Rectangle(width, height);
    }
}

