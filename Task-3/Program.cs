using System.Collections;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            string[] tokens = expression.Split();
            
            Stack<string> stack = new Stack<string>();
            for (int i = tokens.Length - 1; i >= 0; i--)
            {
                stack.Push(tokens[i]);
            }

            int result = 0;
            result += int.Parse(stack.Pop());
            while (stack.Count > 0)
            {
                string num = stack.Pop();
                num += stack.Pop();
                result += int.Parse(num);
            }
            Console.WriteLine(result);
        }
    }
}
