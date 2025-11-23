class Program
{
    static void Main()
    {
        IUIFactory factory = new WinFactory();
        var button = factory.CreateButton();
        button.Render();

        factory = new MacFactory();
        button = factory.CreateButton();
        button.Render();
    }
}