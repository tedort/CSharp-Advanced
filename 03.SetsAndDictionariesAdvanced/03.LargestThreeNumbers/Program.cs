namespace _03.LargestThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .OrderByDescending(num => num)
                                .Take(3)
                                .ToList();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
