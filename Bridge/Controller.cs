namespace Bridge;

public class Controller
{
    // Delegate the functionality to the device, that would contain the implementation, decouples abstraction away from the implementation 
    // Can be changed at run time, is able to pass in different 'Device's 
    private Device device;

    public Controller(Device device)
    {
        this.device = device;
    }

    public void ControlLeftThumbstick()
    {
        this.device.MoveThumbstick();
    }
    
    public void ControlRightThumbstick()
    {
        this.device.PressButton();
    }
    
    
}