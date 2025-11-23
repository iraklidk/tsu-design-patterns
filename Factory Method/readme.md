# Factory Method Pattern
## Short Explanation
The Factory Method pattern lets subclasses decide **which object gets created**, while the base class controls the main flow.  
It’s useful when the overall process stays the same, but different versions of an object need to be created depending on the subclass.

## Logistics Example
This example shows how the base class defines the delivery process while each subclass decides which transport gets created, making the workflow consistent but the created object flexible.
- **Product interface:** `ITransport`  
- **Concrete products:** `Truck`, `Ship`  
- **Creator class:** `Logistics` (defines the factory method)  
- **Concrete creators:** `RoadLogistics`, `SeaLogistics`  

**Why it’s a solid example:**
- Clearly shows that the **workflow is fixed**, but object creation changes  
- Keeps logic clean — no `if/else` to choose transport  
- Super easy to extend (add `AirLogistics` → done)  
- Demonstrates the **core Factory Method idea** without extra noise  
- Client code depends only on the **creator**, not the concrete products  

**Usage**
```csharp
Logistics logistics = new RoadLogistics();
logistics.StartDelivery();

logistics = new SeaLogistics();
logistics.StartDelivery();
