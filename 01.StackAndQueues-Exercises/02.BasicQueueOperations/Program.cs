namespace _02.BasicQueueOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> conditions = Console.ReadLine().Split().Select(int.Parse).ToList();
            int n = conditions[0];
            int s = conditions[1];
            int x = conditions[2];
            Queue<int> numbers = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            for (int i = 0; i < s; i++)
            {
                numbers.Dequeue();
            }

            bool isFound = false;
            foreach (int number in numbers)
            {
                if (number == x)
                {
                    isFound = true;
                    Console.WriteLine("true");
                    break;
                }
            }

            if (!isFound)
            {
                if (numbers.Count > 0)
                {
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
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
