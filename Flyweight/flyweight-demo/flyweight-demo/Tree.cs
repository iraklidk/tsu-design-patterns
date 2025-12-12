// Client
class Tree
{
    private int x;
    private int y;
    private TreeType type;

    public Tree(int x, int y, TreeType type)
    {
        this.x = x;
        this.y = y;
        this.type = type;
    }

    public void Display()
    {
        type.Display(x, y);
    }
}

// Flyweight Factory
class TreeFactory
{
    private static Dictionary<string, TreeType> treeTypes = new Dictionary<string, TreeType>();

    public static TreeType GetTreeType(string name, string color)
    {
        string key = name + "-" + color;
        if (!treeTypes.ContainsKey(key))
        {
            treeTypes[key] = new TreeType(name, color);
        }
        return treeTypes[key];
    }
}