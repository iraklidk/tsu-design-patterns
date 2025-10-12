class Program
{
    static void Main()
    {
        ICar sportsCar = new SportsCar(new BasicCar());
        sportsCar.Assemble();
        Console.WriteLine();
    }
}