class Program
{
    static void Main()
    {
        Logistics logistics = new RoadLogistics();
        logistics.StartDelivery();

        logistics = new SeaLogistics();
        logistics.StartDelivery();
    }
}