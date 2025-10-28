// Main Program
class Program
{
    static void Main()
    {
        IVideo video = new ProxyVideo("funny-cat-video.mp4");

        // Not loaded yet
        Console.WriteLine("Video created but not loaded yet.");

        // Now actually display it (loads only now)
        video.Display();

        // Second time won’t load again
        video.Display();
    }
}