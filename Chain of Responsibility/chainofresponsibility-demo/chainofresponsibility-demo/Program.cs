class Program
{
    static void Main()
    {
        // Create handlers
        CarHandler engineHandler = new EngineHandler();
        CarHandler tireHandler = new TireHandler();
        CarHandler paintHandler = new PaintHandler();

        // Set up chain: Engine -> Tire -> Paint
        engineHandler.SetNext(tireHandler);
        tireHandler.SetNext(paintHandler);

        // Requests
        string[] requests = { "Tire", "Engine", "Paint", "Windows" };

        foreach (var req in requests)
        {
            Console.WriteLine($"\nProcessing request: {req}");
            engineHandler.Handle(req);  // start at the first handler
        }
    }
}