# Chain of Responsibility Pattern

## Short Explanation
The **Chain of Responsibility Pattern** lets multiple objects handle a request without the sender needing to know which one will handle it.  
Each handler either processes the request or passes it along the chain.  
This pattern is super useful when you want to avoid big `if-else` blocks and make request handling flexible.

## Car Service Example
This example demonstrates how car service handlers (like Engine, Tire, and Paint) can process different repair requests dynamically — showing the **Chain of Responsibility pattern** in action.

- **Abstract Handler:** `CarHandler` (defines the interface and stores reference to the next handler)  
- **Concrete Handlers:** `EngineHandler`, `TireHandler`, `PaintHandler` (handle specific tasks)  
- **Client:** sends the request to the first handler in the chain  

**Why it’s a good example:**
- Eliminates long conditional logic  
- Allows handlers to be added or removed easily  
- Decouples the sender of a request from its receivers  

## Usage
```csharp
CarHandler engineHandler = new EngineHandler();
CarHandler tireHandler = new TireHandler();
CarHandler paintHandler = new PaintHandler();

// Set up the chain
engineHandler.SetNext(tireHandler);
tireHandler.SetNext(paintHandler);

string[] requests = { "Engine", "Tire", "Paint", "Windows" };

foreach (var req in requests)
{
    Console.WriteLine($"\nProcessing: {req}");
    engineHandler.Handle(req); // starts at the first handler
}
