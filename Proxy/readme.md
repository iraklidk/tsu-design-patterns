# Proxy Pattern
## Short Explanation
The Proxy Pattern provides a placeholder or middleman that controls access to another object.  
It’s useful when the real object is expensive, slow to create, or needs extra control like lazy loading or access restriction.

## Video Example

This example shows how a proxy delays creating a heavy object (a video that loads from a server) until it’s actually needed.

- **Interface:** `IVideo` (defines `Display()`)
- **Real subject:** `RealVideo` (loads and plays the actual video)
- **Proxy:** `ProxyVideo` (controls when the real video is created and displayed)

**Why it’s a good example:**
- Demonstrates **lazy loading** (loads only when needed)  
- Keeps the client and real object **decoupled**  
- The proxy adds control without changing the real class  

**Usage:**
```csharp
IVideo video = new ProxyVideo("funny-cat-video.mp4");

Console.WriteLine("Video object created, but not loaded yet.");

video.Display(); // Loads and plays
video.Display(); // Plays again, doesn’t reload
