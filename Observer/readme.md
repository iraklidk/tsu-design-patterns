# Observer Pattern
## Short Explanation
The Observer Pattern defines a one-to-many relationship between objects — when one object (the subject) changes, all its dependent objects (observers) are automatically notified and updated.
It’s useful when multiple parts of a program need to react to the same event or change — like UI updates when data changes, notifications when a value updates, or event systems in games.
## WeatherStation Example

This example demonstrates how multiple **observers** automatically get updated when one **subject** changes, showing the **Observer pattern**.

- **Subject class:** `WeatherStation` (manages observers and sends updates)
- **Observer interface:** `IObserver` (defines an `Update()` method)
- **Concrete observers:** `Display` (reacts when temperature changes)

**Why it’s a good example:**
- When the **weather changes**, all displays automatically update  
- Demonstrates a **one-to-many relationship** (one subject → many observers)  
- Shows **loose coupling**, where the subject doesn’t depend on specific observers  

**Usage:**
```csharp
var station = new WeatherStation();

var phoneDisplay = new Display("Phone");
var carDisplay = new Display("Car");

station.AddObserver(phoneDisplay);
station.AddObserver(carDisplay);

station.SetTemperature(25);
station.SetTemperature(30);
