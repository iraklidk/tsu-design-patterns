using System.Collections.Generic;

// ----- Memento -----
public class TextMemento
{
    public string SavedText { get; }

    public TextMemento(string text) => SavedText = text;
}

// ----- Originator -----
public class TextEditor
{
    public string Text { get; set; }

    public TextMemento Save() => new TextMemento(Text);

    public void Restore(TextMemento memento) => Text = memento.SavedText;
}

// ----- Caretaker with Undo -----
public class History
{
    private Stack<TextMemento> _stack = new Stack<TextMemento>();
    private TextEditor _editor;

    public History(TextEditor editor) => _editor = editor;

    public void Save() => _stack.Push(_editor.Save());
    public void Undo()
    {
        if (_stack.Count == 0)
            return;

        var memento = _stack.Pop();
        _editor.Restore(memento);
    }
}