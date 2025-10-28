# Iterator Pattern
## Short Explanation
The Iterator Pattern provides a way to access elements of a collection sequentially without exposing its underlying structure.  
It’s useful when you want to loop through objects without caring how they’re stored internally.

## Playlist Example

This example shows how a playlist can be iterated through using a custom iterator class.

- **Item:** `Song` (represents each song)
- **Collection:** `Playlist` (stores songs and returns an iterator)
- **Iterator:** `PlaylistIterator` (loops through the songs)

**Why it’s a good example:**
- Provides **sequential access** to elements  
- Hides the **internal structure** of the collection  
- Works naturally with `foreach` syntax in C#

**Usage:**
```csharp
var playlist = new Playlist();
playlist.AddSong(new Song("Night Changes"));
playlist.AddSong(new Song("As It Was"));
playlist.AddSong(new Song("Style"));

foreach (var song in playlist)
    Console.WriteLine(song.Title);
