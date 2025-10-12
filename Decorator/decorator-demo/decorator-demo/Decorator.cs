
// Component interface
interface ICar
{
    void Assemble();
}

// Concrete Component
class BasicCar : ICar
{
    public void Assemble() => Console.Write("Basic Car");
}

// Decorator
class CarDecorator : ICar
{
    protected ICar car;
    public CarDecorator(ICar car) => this.car = car;
    public virtual void Assemble() => car.Assemble();
}

// Concrete Decorator
class SportsCar : CarDecorator
{
    public SportsCar(ICar car) : base(car) { }
    public override void Assemble()
    {
        base.Assemble();
        Console.Write(" + Sports features");
    }
}