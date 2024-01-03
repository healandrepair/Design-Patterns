namespace Bridge;

public class Playstation : Device
{
    public override void MoveThumbstick()
    {
        Console.WriteLine("Moving playstation thumbstick");
    }

    public override void PressButton()
    {
        Console.WriteLine("Pressing playstation Buttons");
    }
}