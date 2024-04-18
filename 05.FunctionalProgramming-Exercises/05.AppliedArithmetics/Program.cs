namespace _05.AppliedArithmetics
{
    internal class Program
    {
        public delegate List<int> Combine(List<int> numbers);
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Func<int, int> function = x => x;
            Action<List<int>> print = numbers => Console.WriteLine(string.Join(" ", numbers));

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "add")
                {
                    function = x => x + 1;
                }
                else if (command == "multiply")
                {
                    function = x => x * 2;
                }
                else if (command == "subtract")
                {
                    function = x => x - 1;
                }
                else if (command == "print")
                {
                    print(numbers);
                    continue;
                }
                numbers = numbers.Select(x => function(x)).ToList();
            }
        }
    }
}
