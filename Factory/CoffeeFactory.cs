using Design_Patterns;

namespace Design_Patterns_Base;

class CoffeeFactory
{
    public CoffeeBase CreateCoffee(CoffeeType coffeeType)
    {
        switch (coffeeType) {

            case CoffeeType.Cappuccino:
                return new Cappuccino();
            case CoffeeType.Americano:
                return new Americano();
            case CoffeeType.FlatWhite:
                return new FlatWhite();
            default:
                throw new Exception("Coffee not in stock");
        }
    }
}