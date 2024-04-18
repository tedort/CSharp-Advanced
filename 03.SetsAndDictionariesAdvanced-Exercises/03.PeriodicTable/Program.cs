namespace _03.PeriodicTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> elements = new SortedSet<string>();

            while (n > 0)
            {
                string[] input = Console.ReadLine().Split();
                for (int i = 0; i < input.Length; i++)
                {
                    elements.Add(input[i]);
                }
                n--;
            }

            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
