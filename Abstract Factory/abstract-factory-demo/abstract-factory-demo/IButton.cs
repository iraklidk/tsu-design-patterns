public interface IButton
{
    void Render();
}

public class WinButton : IButton
{
    public void Render() => Console.WriteLine("Windows Button");
}

public class MacButton : IButton
{
    public void Render() => Console.WriteLine("Mac Button");
}