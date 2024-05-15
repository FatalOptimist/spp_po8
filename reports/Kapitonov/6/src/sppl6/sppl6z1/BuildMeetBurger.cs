namespace sppl6z1;

public class BuildMeetBurger : BurgerBuilder
{
    public override Burger Build()
    {
        Burger burger = new Burger("Meet burger");
        burger.Ingredients.Add("meet");
        return burger;
    }
}

public class BuildVeganBurger : BurgerBuilder
{
    public override Burger Build()
    {
        Burger burger = new Burger("Vegan burger");
        burger.Ingredients.Add("Soy");
        return burger;
    }
}