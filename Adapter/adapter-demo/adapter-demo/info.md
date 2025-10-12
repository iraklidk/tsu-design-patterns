# Adapter Pattern — `MediaAdapter` Example

This example demonstrates how an **adapter** allows incompatible classes to work together, showcasing the **Adapter pattern**.

- **Target interface:** `IMediaPlayer` (defines `Play()` method)  
- **Adaptee:** `VideoPlayer` (existing class with `PlayVideo()` method)  
- **Adapter class:** `MediaAdapter` (makes `VideoPlayer` compatible with `IMediaPlayer`)  

**Why it’s a good example:**
- Lets an existing class (`VideoPlayer`) work with a new interface (`IMediaPlayer`) without modifying either  
- Shows how to **bridge incompatible interfaces**  
- Demonstrates a **translator-like pattern** in code  

**Usage:**
```csharp
IMediaPlayer player = new MediaAdapter();
player.Play("movie.mp4");
