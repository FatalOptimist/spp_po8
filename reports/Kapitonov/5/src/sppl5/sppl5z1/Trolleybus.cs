namespace sppl5z1;

public class Trolleybus : PublicTransport
{
    public Trolleybus(string name, int maxSpeed, int numOfPass)
    {
        Name = name;
        MaxSpeed = maxSpeed;
        NumberOfPassenger = numOfPass;
    }

    public override void Move()
    {
        Console.WriteLine("Trolleybus move");
    }

    public override void SelectRoute()
    {
        Console.WriteLine("Trolleybus select route");
    }

    public void ConnectToWires()
    {
        Console.WriteLine("Trolleybus was connected to wires");
    }
}