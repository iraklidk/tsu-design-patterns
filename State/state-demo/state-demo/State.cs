// Concrete state: Playing
public class PlayingState : IPlayerState
{
    public void PressPlay(Player player)
    {
        Console.WriteLine("Pausing the music");
        player.SetState(new PausedState());
    }
}

// Concrete state: Paused
public class PausedState : IPlayerState
{
    public void PressPlay(Player player)
    {
        Console.WriteLine("Resuming the music");
        player.SetState(new PlayingState());
    }
}