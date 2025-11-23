public abstract class Logistics
{
    public abstract ITransport CreateTransport();

    public void StartDelivery()
    {
        var transport = CreateTransport();
        transport.Deliver();
    }
}

public class RoadLogistics : Logistics
{
    public override ITransport CreateTransport() => new Truck();
}

public class SeaLogistics : Logistics
{
    public override ITransport CreateTransport() => new Ship();
}