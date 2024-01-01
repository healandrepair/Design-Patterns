namespace Adapter;

public interface IPlug 
{
    public void WhatPlugAmI();
    
    public int GetProngs();

    public int GetVoltage();
}