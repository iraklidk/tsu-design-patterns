class Program
{
    static void Main()
    {

        /* client */
        IMediaPlayer player = new MediaAdapter();
        player.Play("movie.mp4");
    }
}