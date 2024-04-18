using System;
using System.Collections.Generic;
using System.Text;

class TextManipulator
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        StringBuilder text = new StringBuilder();
        Stack<string> undoStack = new Stack<string>();

        for (int i = 0; i < n; i++)
        {
            string[] operation = Console.ReadLine().Split();

            switch (operation[0])
            {
                case "1":
                    AppendOperation(text, undoStack, operation[1]);
                    break;

                case "2":
                    EraseOperation(text, undoStack, int.Parse(operation[1]));
                    break;

                case "3":
                    int index = int.Parse(operation[1]) - 1;
                    Console.WriteLine(text[index]);
                    break;

                case "4":
                    UndoOperation(text, undoStack);
                    break;
            }
        }
    }

    static void AppendOperation(StringBuilder text, Stack<string> undoStack, string someString)
    {
        undoStack.Push(text.ToString());
        text.Append(someString);
    }

    static void EraseOperation(StringBuilder text, Stack<string> undoStack, int count)
    {
        undoStack.Push(text.ToString());
        int length = text.Length;
        text.Remove(length - count, count);
    }

    static void UndoOperation(StringBuilder text, Stack<string> undoStack)
    {
        if (undoStack.Count > 0)
        {
            text.Clear();
            text.Append(undoStack.Pop());
        }
    }
}
