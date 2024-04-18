namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            Stack<int> numSum = new Stack<int>();
            foreach (int number in numbers)
            {
                numSum.Push(number);
            }

            string command = Console.ReadLine().ToLower();
            while (command != "end")
            {
                if (command.Contains("add"))
                {
                    List<int> newNumbers = command.Substring(4).Split().Select(int.Parse).ToList();
                    foreach (int number in newNumbers)
                    {
                        numSum.Push(number);
                    }
                }

                else if (command.Contains("remove"))
                {
                    int count = int.Parse(command.Substring(7));
                    while (count > 0 && numSum.Count() >= count)
                    {
                        numSum.Pop();
                        count--;
                    }
                }

                command = Console.ReadLine().ToLower();
            }

            int sum = 0;
            while (numSum.Count > 0)
            {
                sum += numSum.Pop();
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
