namespace sppl5z1;

public interface Transport
{
    public string Name { get; set; }
    public int MaxSpeed { get; set; }
    public void Move();
}