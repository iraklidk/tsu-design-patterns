class Program
{
    static void Main()
    {
        var player = new Player();

        player.PressPlay(); // Resuming
        player.PressPlay(); // Pausing
        player.PressPlay(); // Resuming again
    }
}