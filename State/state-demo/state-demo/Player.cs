// State interface
public interface IPlayerState
{
    void PressPlay(Player player);
}

// Context
public class Player
{
    private IPlayerState _state;

    public Player()
    {
        _state = new PausedState(); // start paused
    }

    public void SetState(IPlayerState state)
    {
        _state = state;
    }

    public void PressPlay()
    {
        _state.PressPlay(this);
    }
}