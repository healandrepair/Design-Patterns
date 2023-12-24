// See https://aka.ms/new-console-template for more information

using Builder;
using Builder.Models;

Console.WriteLine("Create an americano coffee using the old method");

OldCoffee oldAmericano = new OldCoffee("Americano", "Strong coffee", 5.5, "Americano");
oldAmericano.Display();

Console.WriteLine("Create a new coffee with the builder");

Barista barista = new Barista();

barista.SetCoffeeBuilder(new AmericanoBuilder());

barista.CreateCoffee();

NewCoffee americano = barista.GetCoffee();

americano.Display();