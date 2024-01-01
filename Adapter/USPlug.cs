namespace Adapter;

public class USPlug : IPlug
{
    private int prongs = 2;
    
    private int voltage = 120;

    public void WhatPlugAmI()
    {
        Console.WriteLine("I am a US Plug");
    }
    
    public int GetProngs()
    {
        return prongs;
    }

    public int GetVoltage()
    {
        return voltage;
    }
}

