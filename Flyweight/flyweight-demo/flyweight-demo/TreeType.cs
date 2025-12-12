class TreeType
{
    public string Name { get; private set; }
    public string Color { get; private set; }

    public TreeType(string name, string color)
    {
        Name = name;
        Color = color;
    }
    public void Display(int x, int y)
    {
        Console.WriteLine($"Tree: {Name}, Color: {Color}, Position: ({x},{y})");
    }
}