# Abstract Factory Pattern
## Short Explanation
The Abstract Factory pattern lets you create **families of related objects** without touching their actual classes.  
You just swap factories, and the whole vibe of the created objects changes — perfect when you need consistent product sets (like OS-themed UI components).

## UI Factory Example
This example shows how a single factory can produce UI elements that all match the same environment.

- **Target product:** `IButton`
- **Concrete products:** `WinButton`, `MacButton`
- **Abstract factory:** `IUIFactory`
- **Concrete factories:** `WinFactory`, `MacFactory`

**Why this example is solid:**
- Easy to switch entire object families (Windows → Mac)
- No if-else chaos in the client
- The factory controls the style, not the client code

**Usage**
```csharp

IUIFactory factory = new WinFactory();
var btn = factory.CreateButton();
btn.Render();


factory = new MacFactory();
btn = factory.CreateButton();
btn.Render();
