namespace _04.EvenTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> counter = new Dictionary<int, int>();

            while (n > 0)
            {
                int number = int.Parse(Console.ReadLine());
                if (!counter.ContainsKey(number))
                {
                    counter.Add(number, 0);
                }
                counter[number]++;
                n--;
            }

            foreach (int number in counter.Keys)
            {
                if (counter[number] % 2 == 0)
                {
                    Console.WriteLine(number);
                    break;
                }
            }
        }
    }
}
