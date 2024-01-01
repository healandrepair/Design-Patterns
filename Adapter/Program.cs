// See https://aka.ms/new-console-template for more information

using Adapter;

Console.WriteLine("Hello, World!");

USPlug usPlug = new USPlug();

EuropeanPlug europeanPlug = new EuropeanPlug();

USSocket usSocket = new USSocket();

// Check if US plug fits US socket - true
usSocket.Fits(usPlug);

// Check if European plug fits US socket - false 
usSocket.Fits(europeanPlug);

// Create an adapter to make the European plug fit the US socket

EuropeanToUSPlugAdapter adapter = new EuropeanToUSPlugAdapter(europeanPlug);
adapter.WhatPlugAmI();

// Check if the adapter fits the US socket - true
usSocket.Fits(adapter);

Console.WriteLine("Attempt charge...");
// Charge the European plug with the US socket
usSocket.Charge(adapter);



