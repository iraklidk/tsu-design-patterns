class Program
{
    static void Main()
    {
        Playlist playlist = new Playlist();
        playlist.AddSong(new Song("Night Changes"));
        playlist.AddSong(new Song("As It Was"));
        playlist.AddSong(new Song("Style"));

        Console.WriteLine("My Playlist:");
        foreach (var song in playlist)
        {
            Console.WriteLine($"- {song.Title}");
        }
    }
}