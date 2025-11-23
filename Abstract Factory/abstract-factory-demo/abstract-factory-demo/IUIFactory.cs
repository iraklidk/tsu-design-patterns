public interface IUIFactory
{
    IButton CreateButton();
}
public class WinFactory : IUIFactory
{
    public IButton CreateButton() => new WinButton();
}

public class MacFactory : IUIFactory
{
    public IButton CreateButton() => new MacButton();
}