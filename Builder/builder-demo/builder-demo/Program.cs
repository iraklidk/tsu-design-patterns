class Program
{
    static void Main()
    {
        Car myCar = new CarBuilder()
                        .SetBrand("Tesla")
                        .SetModel("Model S")
                        .SetColor("Red")
                        .Build();

        myCar.ShowInfo();  // Output: Car: Tesla Model S, Color: Red
    }
}