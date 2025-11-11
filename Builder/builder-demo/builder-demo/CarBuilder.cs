// The Builder
class CarBuilder
{
    private Car car = new Car();

    public CarBuilder SetBrand(string brand)
    {
        car.Brand = brand;
        return this; // enable chaining
    }

    public CarBuilder SetModel(string model)
    {
        car.Model = model;
        return this;
    }

    public CarBuilder SetColor(string color)
    {
        car.Color = color;
        return this;
    }

    public Car Build()
    {
        return car;
    }
}