namespace Adapter;

public class USSocket
{
    public bool Fits(IPlug plug)
    {
        return plug.GetProngs() == 2 && plug.GetVoltage() == 120;
    }
    
    public void Charge(IPlug plug)
    {
        if (Fits(plug))
        {
            Console.WriteLine($"I am a US Socket and I am charging a {plug.GetType().Name}, with voltage {plug.GetVoltage()}");
        }
    }
}