namespace sppl6z1;

public class BuildIndoorPackage : PackageBuilder
{
    public override Package Build()
    {
        return new Package("Indoor package", PackageType.Indoor);
    }
}

public class BuildOutdoorPackage : PackageBuilder
{
    public override Package Build()
    {
        return new Package("Outdoor package", PackageType.Outdoor);
    }
}