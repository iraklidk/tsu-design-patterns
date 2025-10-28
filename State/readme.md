# State Pattern
## Short Explanation
The State pattern allows an object to **change its behavior** when its internal state changes.  
It is useful when an object needs to **behave differently depending on its state**, like a music player (Playing, Paused), a TCP connection (Connected, Disconnected), or a document editor (Editing, ReadOnly).

## Music Player Example

This example shows how a **Music Player** changes its behavior depending on its **state** (Playing or Paused), demonstrating the **State pattern**.

- **Context class:** `Player` (holds a reference to the current state)
- **State interface:** `IPlayerState` (defines behavior for different states)
- **Concrete states:** `PlayingState`, `PausedState` (implement the behavior for each state)
- **State switching:** Player delegates behavior to its current state, which can change the state dynamically

**Why it’s a good example:**
- The object behavior **changes automatically** when its internal state changes
- Adding new states is **easy** without modifying the main Player logic
- Shows **encapsulation of state-specific behavior**, core idea of State pattern

**Usage:**
```csharp
var player = new Player();

player.PressPlay(); // Resuming the music
player.PressPlay(); // Pausing the music
player.PressPlay(); // Resuming again
