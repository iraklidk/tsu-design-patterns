class Program
{
    static void Main()
    {
        List<Tree> forest = new List<Tree>();

        // Reuse same TreeType objects
        TreeType oakType = TreeFactory.GetTreeType("Oak", "Green");
        TreeType pineType = TreeFactory.GetTreeType("Pine", "DarkGreen");

        forest.Add(new Tree(10, 20, oakType));
        forest.Add(new Tree(15, 25, oakType));
        forest.Add(new Tree(5, 5, pineType));

        foreach (var tree in forest)
        {
            tree.Display();
        }
    }
}