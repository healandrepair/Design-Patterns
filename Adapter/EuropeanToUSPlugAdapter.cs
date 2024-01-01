namespace Adapter;

// Inherit from the USPlug class and implement the IPlug interface
public class EuropeanToUSPlugAdapter  : USPlug
{
    private EuropeanPlug plug;

    public EuropeanToUSPlugAdapter(EuropeanPlug plug)
    {
        // Assign the EuropeanPlug to the plug field
        this.plug = plug;
    }
    
    public new void WhatPlugAmI()
    {
        Console.WriteLine("I am an European Plug with an adapter to fit a US Socket");
    }
    
    public int GetProngs()
    {
        // Call the GetProngs method on the US Plug, which is the base class and
        // US socket takes 2 prongs but european takes 3;
        return base.GetProngs();
    }
    
    public int GetVoltage()
    {
        // Call the GetVoltage method on the European Plug, which is the plug field.
        // European socket takes 220 volts but US takes 120; ~ return voltage
        return plug.GetVoltage();
    }
}