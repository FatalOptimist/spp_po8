namespace sppl6z1;

public class Drink
{
    public Drink(string name, DrinkType type)
    {
        Name = name;
        Type = type;
    }

    public string Name { get; set; }
    public DrinkType Type { get; set; }

    public override string ToString()
    {
        return $"{Name},Type: {Type}";
    }
}

public enum DrinkType
{
    Cold,
    Warm
}