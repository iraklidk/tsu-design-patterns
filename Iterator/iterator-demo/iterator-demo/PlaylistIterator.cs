using System.Collections;

// The Iterator itself
public class PlaylistIterator : IEnumerator<Song>
{
    private List<Song> _songs;
    private int _position = -1;

    public PlaylistIterator(List<Song> songs)
    {
        _songs = songs;
    }

    public Song Current => _songs[_position];

    object IEnumerator.Current => Current;

    public bool MoveNext()
    {
        _position++;
        return _position < _songs.Count;
    }

    public void Reset()
    {
        _position = -1;
    }

    public void Dispose() { }
}