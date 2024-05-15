namespace sppl6z1;

public class Burger
{
    public Burger(string name)
    {
        Name = name;
        Ingredients = new List<string>();
    }

    public string Name { get; set; }
    public List<string> Ingredients { get; set; }

    public override string ToString()
    {
        return $"{Name},Ingredients: {string.Join(", ", Ingredients)}";
    }
} 