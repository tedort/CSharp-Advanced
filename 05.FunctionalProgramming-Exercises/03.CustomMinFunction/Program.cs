namespace _03.CustomMinFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToHashSet();

            Func<HashSet<int>, int> smallestNum = num => numbers.Min();

            Console.WriteLine(smallestNum(numbers));
        }
    }
}
