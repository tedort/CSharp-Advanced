namespace _07.PredicateForNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Predicate<string> predicate = name => name.Length <= n;

            names = names.Where(name => predicate(name)).ToArray();

            Console.WriteLine(string.Join("\n", names));
        }
    }
}
