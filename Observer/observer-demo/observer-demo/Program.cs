class Program
{
    static void Main()
    {
        var station = new WeatherStation();
        var phoneDisplay = new Display("Phone");
        var carDisplay = new Display("Car");
        station.AddObserver(phoneDisplay);
        station.AddObserver(carDisplay);
        station.SetTemperature(25);
        station.SetTemperature(30);
    }
}