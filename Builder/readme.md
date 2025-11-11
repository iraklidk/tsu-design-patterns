# Builder Pattern
## Short Explanation
The **Builder Pattern** separates the construction of a complex object from its representation. It lets you create different types of the same object step by step using the same building process. This is useful when an object has many optional fields or configurations.

## Car Example
This example shows how the Builder Pattern helps build objects (like a `Car`) with various configurations — without needing a massive constructor or tons of subclasses.

- **Product:** `Car` (the object being built)  
- **Builder:** `CarBuilder` (defines methods for step-by-step construction)  
- **Client:** uses the builder to create custom car objects easily

**Why it’s a good example:**
- Simplifies the creation of objects with many optional parameters  
- Enables **method chaining** for clean and readable object creation  
- Keeps construction logic separate from the product itself  

**Usage:**
```csharp
Car myCar = new CarBuilder()
                .SetBrand("Tesla")
                .SetModel("Model S")
                .SetColor("Red")
                .Build();

myCar.ShowInfo(); // Output: Car: Tesla Model S, Color: Red
