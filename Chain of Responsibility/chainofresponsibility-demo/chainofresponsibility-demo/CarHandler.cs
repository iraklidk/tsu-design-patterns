// ----- Handler abstract class -----
abstract class CarHandler
{
    protected CarHandler nextHandler;

    public void SetNext(CarHandler next)
    {
        nextHandler = next;
    }

    public abstract void Handle(string request);
}

// ----- Concrete Handlers -----
class EngineHandler : CarHandler
{
    public override void Handle(string request)
    {
        if (request == "Engine")
        {
            Console.WriteLine("EngineHandler: Handling engine issue.");
        }
        else if (nextHandler != null)
        {
            nextHandler.Handle(request);
        }
    }
}