// The Product
class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }

    public void ShowInfo()
    {
        Console.WriteLine($"Car: {Brand} {Model}, Color: {Color}");
    }
}