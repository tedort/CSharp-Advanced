namespace _04.FindEvenOrOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int lowerBound = range[0];
            int upperBound = range[1];
            string inputPredicate = Console.ReadLine();

            Predicate<int> predicate = num => num % 2 != 0;
            if (inputPredicate == "even")
            {
                predicate = num => num % 2 == 0;
            }

            List<int> numbers = new List<int>();

            for (int i = lowerBound; i <= upperBound; i++)
            {
                numbers.Add(i);
            }

            numbers = numbers.Where(num => predicate(num)).ToList();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
