public interface IVideo
{
    void Display();
}

// 🎬 Real object
public class RealVideo : IVideo
{
    private string _fileName;

    public RealVideo(string fileName)
    {
        _fileName = fileName;
        LoadFromServer();
    }

    private void LoadFromServer()
    {
        Console.WriteLine($"Loading video '{_fileName}' from server...");
    }

    public void Display()
    {
        Console.WriteLine($"Playing video '{_fileName}'");
    }
}
