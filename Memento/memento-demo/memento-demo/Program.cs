class Program
{
    static void Main()
    {
        var editor = new TextEditor();
        var history = new History(editor);

        editor.Text = "Hello";
        history.Save();

        editor.Text = "Hello World";
        history.Save();

        editor.Text = "Changed again";

        history.Undo(); // undo to "Hello World"
        Console.WriteLine(editor.Text);
    }
}