namespace sppl6z1;

public class BuildColdDrink : DrinkBuilder
{
    public override Drink Build()
    {
        Drink drink = new Drink("Cold drink", DrinkType.Cold);
        return drink;
    }
}

public class BuildWarmDrink : DrinkBuilder
{
    public override Drink Build()
    {
        Drink drink = new Drink("Warm drink", DrinkType.Warm);
        return drink;
    }
}