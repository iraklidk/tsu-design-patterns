// The Observer interface
interface IObserver
{
    void Update(int temperature);
}

// A Concrete Observer
class Display : IObserver
{
    private string name;

    public Display(string name)
    {
        this.name = name;
    }

    public void Update(int temperature)
    {
        Console.WriteLine($"{name} display: Temperature is now {temperature}°C");
    }
}