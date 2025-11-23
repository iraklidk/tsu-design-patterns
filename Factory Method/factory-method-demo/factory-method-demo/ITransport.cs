public interface ITransport
{
    void Deliver();
}

public class Truck : ITransport
{
    public void Deliver() => Console.WriteLine("Delivering by truck");
}

public class Ship : ITransport
{
    public void Deliver() => Console.WriteLine("Delivering by ship");
}
