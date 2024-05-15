namespace sppl6z1;

public class Director
{
    private BurgerBuilder _burgerBuilder;
    private DrinkBuilder _drinkBuilder;
    private PackageBuilder _packageBuilder;

    public Director(BurgerBuilder burgerBuilder, DrinkBuilder drinkBuilder, PackageBuilder packageBuilder)
    {
        _burgerBuilder = burgerBuilder;
        _drinkBuilder = drinkBuilder;
        _packageBuilder = packageBuilder;
    }

    public Order MakeOrder()
    {
        var burger = _burgerBuilder.Build();
        var drink = _drinkBuilder.Build();
        var package = _packageBuilder.Build();
        return new Order(burger, drink, package);
    }
}