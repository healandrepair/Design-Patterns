namespace Adapter;

public class EuropeanPlug : IPlug
{
    private int prongs = 3;
    
    private int voltage = 220;
    
    public void WhatPlugAmI()
    {
        Console.WriteLine("I am an European Plug");
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