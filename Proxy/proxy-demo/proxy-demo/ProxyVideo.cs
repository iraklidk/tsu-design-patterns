// Proxy object
public class ProxyVideo : IVideo
{
    private string _fileName;
    private RealVideo _realVideo;

    public ProxyVideo(string fileName)
    {
        _fileName = fileName;
    }

    public void Display()
    {
        // only load when needed
        if (_realVideo == null)
        {
            _realVideo = new RealVideo(_fileName);
        }
        _realVideo.Display();
    }
}