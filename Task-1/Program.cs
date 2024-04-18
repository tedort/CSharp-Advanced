using System.IO.Pipes;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] strToArr = text.ToCharArray();
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < strToArr.Length; i++)
            {
                stack.Push(strToArr[i]);
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
