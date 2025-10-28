using System.Collections;

// Our Song class
public class Song
{
    public string Title { get; }

    public Song(string title)
    {
        Title = title;
    }
}

// Playlist (the collection)
public class Playlist : IEnumerable<Song>
{
    private List<Song> _songs = new List<Song>();

    public void AddSong(Song song)
    {
        _songs.Add(song);
    }

    // This returns a custom iterator
    public IEnumerator<Song> GetEnumerator()
    {
        return new PlaylistIterator(_songs);
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}