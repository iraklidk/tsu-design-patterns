class WeatherStation
{
    private List<IObserver> observers = new List<IObserver>();
    private int temperature;

    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void SetTemperature(int newTemp)
    {
        temperature = newTemp;
        NotifyObservers();
    }

    private void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(temperature);
        }
    }
}