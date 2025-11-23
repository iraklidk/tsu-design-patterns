
class TireHandler : CarHandler
{
    public override void Handle(string request)
    {
        if (request == "Tire")
        {
            Console.WriteLine("TireHandler: Handling tire issue.");
        }
        else if (nextHandler != null)
        {
            nextHandler.Handle(request);
        }
    }
}

class PaintHandler : CarHandler
{
    public override void Handle(string request)
    {
        if (request == "Paint")
        {
            Console.WriteLine("PaintHandler: Handling paint issue.");
        }
        else if (nextHandler != null)
        {
            nextHandler.Handle(request);
        }
    }
}