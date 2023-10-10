using MementoPattern;

var editor = new Editor();
var history = new History();

// Simulate typing into editor.
editor.SetContent("Two people walked down a street.");
history.Push(editor.CreateState());

// Simulate typing into editor.
editor.SetContent("They were wearing red clothes.");
history.Push(editor.CreateState());

// Simulate typing into editor.
editor.SetContent("It was raining.");
history.Push(editor.CreateState());

// Simulate the undo button press.
editor.Restore(history.Pop());

// Prints "They were wearing red clothes.".
Console.WriteLine(editor.GetContent());

// Simulate the undo button press.
editor.Restore(history.Pop());

// Prints "Two people walked down a street.".
Console.WriteLine(editor.GetContent());