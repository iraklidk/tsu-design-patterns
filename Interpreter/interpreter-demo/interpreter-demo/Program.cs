class Program
{
    static void Main()
    {
        // Represents: 5 + 3
        IExpression five = new NumberExpression(5);
        IExpression three = new NumberExpression(3);

        IExpression add = new AddExpression(five, three);

        Console.WriteLine(add.Interpret()); // 8
    }
}
