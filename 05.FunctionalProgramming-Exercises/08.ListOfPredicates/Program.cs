namespace _08.ListOfPredicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] divisors = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            List<int> numbers = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                numbers.Add(i);
            }

            Func<int[], int, bool> predicate = (arr, i) =>
            {
                bool isDivisible = true;
                foreach (int n in divisors)
                {
                    if (i % n != 0)
                    {
                        isDivisible = false;
                    }
                }
                return isDivisible;
            };

            var result = numbers
                .Where(number => predicate(divisors, number));

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
