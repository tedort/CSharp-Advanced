namespace _06.ReverseAndExclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToList();
            int n = int.Parse(Console.ReadLine());
            Predicate<int> divisible = num => num % n != 0;

            List<int> result = numbers
                .Where(number => divisible(number))
                .ToList();
            result.Reverse();

            Console.WriteLine(string.Join(' ', result));
        }
    }
}
