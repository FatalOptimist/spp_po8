namespace sppl5z1;

public abstract class PublicTransport : Transport
{
    public string Name { get; set; }
    public int MaxSpeed { get; set; }
    public int NumberOfPassenger { get; set; } 
    public virtual void Move()
    {
        Console.WriteLine("PublicTransport move");
    }

    public virtual void SelectRoute()
    {
        Console.WriteLine("PublicTransport select route");
    }
}