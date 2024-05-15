namespace sppl6z1;

public class Order
{
    public Order(Burger burger, Drink drink, Package package)
    {
        Burger = burger;
        Drink = drink;
        Package = package;
    }

    public Burger Burger { get; set; }
    public Drink Drink { get; set; }
    public Package Package { get; set; }

    public override string ToString()
    {
        return $"{Burger}\n{Drink}\n{Package}";
    }
}