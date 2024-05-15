namespace sppl6z1;

public class Package
{
    public Package(string name, PackageType type)
    {
        Name = name;
        Type = type;
    }

    public string Name{ get; set; }
    public PackageType Type { get; set; }

    public override string ToString()
    {
        return $"{Name},Type: {Type}";
    }
}

public enum PackageType
{
    Indoor,
    Outdoor
}