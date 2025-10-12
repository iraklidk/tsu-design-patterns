// Target interface
interface IMediaPlayer
{
    void Play(string filename);
}

// Adaptee (incompatible class)
class VideoPlayer
{
    public void PlayVideo(string filename)
    {
        Console.WriteLine($"Playing video file: {filename}");
    }
}

// Adapter (makes VideoPlayer work with IMediaPlayer)
class MediaAdapter : IMediaPlayer
{
    private VideoPlayer _videoPlayer = new VideoPlayer();

    public void Play(string filename)
    {
        _videoPlayer.PlayVideo(filename);
    }
}