using System.Globalization;

namespace _03.MaximumAndMinimumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();
            while (n > 0)
            {
                string input = Console.ReadLine();
                n--;
                int query = int.Parse(input.Substring(0, 1));
                if (query == 1)
                {
                    int num = int.Parse(input.Substring(2));
                    numbers.Push(num);
                }
                else if (query == 2)
                {
                    numbers.Pop();
                }
                else if (query == 3)
                {
                    if (numbers.Count == 0)
                    {
                        continue;
                    }
                    int max = int.MinValue;
                    foreach (int number in numbers)
                    {
                        if (number > max)
                        {
                            max = number;
                        }
                    }
                    Console.WriteLine(max);
                }
                else if (query == 4)
                {
                    if (numbers.Count == 0)
                    {
                        continue;
                    }
                    int min = int.MaxValue;
                    foreach (int number in numbers)
                    {
                        if (number < min)
                        {
                            min = number;
                        }
                    }
                    Console.WriteLine(min);
                }
            }

            while (numbers.Count > 0)
            {
                if (numbers.Count == 1)
                {
                    Console.Write(numbers.Pop());
                    break;
                }
                Console.Write(numbers.Pop() + ", ");
            }
        }
    }
}
