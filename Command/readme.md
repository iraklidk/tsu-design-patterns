# Command Pattern

## Short Explanation
The Command pattern lets you **encapsulate an action as an object**, turning a request into something you can store, queue, undo, or swap out easily.  
It is useful when you want to **decouple the object that sends a request** from the one that actually performs the work — like a remote control, UI buttons, or command history (undo/redo).

## Light Switch Example

This example shows how a **Remote Control** triggers commands (TurnOn / TurnOff) without knowing how a **Light** actually performs the action, demonstrating the **Command pattern**.

- **Receiver class:** `Light` (the actual worker)  
- **Command interface:** `ICommand` (defines the Execute action)  
- **Concrete commands:** `TurnOnCommand`, `TurnOffCommand` (wrap the receiver actions)  
- **Invoker:** `RemoteControl` (executes whatever command it’s holding)  

**Why it’s a good example:**
- The invoker has **no clue** how the action is done — total decoupling  
- Adding new commands is **super easy** (no need to change existing code)  
- Shows **encapsulation of an action**, core idea of the Command pattern  

**Usage:**

```csharp
var light = new Light();

var turnOn = new TurnOnCommand(light);
var turnOff = new TurnOffCommand(light);

var remote = new RemoteControl();

remote.SetCommand(turnOn);
remote.PressButton(); // Light is ON

remote.SetCommand(turnOff);
remote.PressButton(); // Light is OFF
