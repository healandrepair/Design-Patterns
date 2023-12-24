// See https://aka.ms/new-console-template for more information

// Coffees are needed to be created, and using the factory pattern with CoffeeFactory creating the coffee objects.
// This decouples the responsibility of the client creating the objects and delegates it to the CoffeeFactory

using Design_Patterns;
using Design_Patterns_Base;

CoffeeFactory coffeeFactory = new CoffeeFactory();

// create americano
CoffeeBase americano = coffeeFactory.CreateCoffee(CoffeeType.Americano);
americano.Drink();

// Create Flat white
CoffeeBase flatWhite = coffeeFactory.CreateCoffee(CoffeeType.FlatWhite);
flatWhite.Drink();
                
if (flatWhite is FlatWhite)
{
    FlatWhite flatWhiteCoffee = (FlatWhite) flatWhite;
    // TIpAway is unique to flatwhite
    flatWhiteCoffee.LessMilk();
}

CoffeeBase cappuccino = coffeeFactory.CreateCoffee(CoffeeType.Cappuccino);
cappuccino.Drink();