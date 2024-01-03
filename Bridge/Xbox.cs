namespace Bridge;

public class Xbox : Device
{
    public override void MoveThumbstick()
    {
        Console.WriteLine("Moving xbox thumbstick");
    }

    public override void PressButton()
    {
        Console.WriteLine("Pressing xbox button");
    }
}