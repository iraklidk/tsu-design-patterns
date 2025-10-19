# Decorator Pattern
## Short Explanation
The Decorator Pattern allows behavior to be added to an object dynamically without modifying its class. It’s useful when you want to extend functionality in a flexible way — like adding toppings to a pizza: the base object stays the same, but new features are added on top.
# SportsCar Example

This example demonstrates how behavior can be added to an object dynamically, showcasing the **Decorator pattern**.

- **Component interface:** `ICar` (defines `Assemble()` method)  
- **Concrete component:** `BasicCar` (original object)  
- **Decorator class:** `CarDecorator` (base decorator that wraps an object)  
- **Concrete decorator:** `SportsCar` (adds extra behavior dynamically)

**Why it’s a good example:**
- Lets you **extend functionality** without modifying the original class  
- Demonstrates **dynamic behavior addition**  
- Useful for **wrapping objects with extra features** in a flexible way

**Usage:**
```csharp
ICar sportsCar = new SportsCar(new BasicCar());
sportsCar.Assemble();
