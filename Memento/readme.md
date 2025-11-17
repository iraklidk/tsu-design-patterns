# Memento Pattern

## Short Explanation
The Memento pattern lets an object **save and restore its internal state** without exposing how that state works.  
It’s perfect for features like **Undo**, **snapshots**, and **history tracking** where you want to roll back changes safely.

## Text Editor Example

This example shows how a **Text Editor** can save its text and restore it using a real **Undo()** method, demonstrating the Memento pattern.

- **Originator:** `TextEditor` (the object whose state gets saved)
- **Memento:** `TextMemento` (stores the state snapshot)
- **Caretaker:** `History` (keeps snapshots + performs Undo)
- **Undo behavior:** calling `Undo()` rolls the editor back to the previous saved state

**Why it's a good example:**
- The editor can **restore previous states** without exposing its internals  
- Undo logic is **clean and separate** from the editor itself  
- You can add **multiple levels of undo** easily with a stack  

### Usage:
```csharp
var editor = new TextEditor();
var history = new History(editor);

editor.Text = "Hello";
history.Save();

editor.Text = "Hello World";
history.Save();

editor.Text = "Oops, typo!";

history.Undo(); // Restores to: "Hello World"
