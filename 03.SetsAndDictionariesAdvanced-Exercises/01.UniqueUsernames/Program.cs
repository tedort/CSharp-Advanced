namespace _01.UniqueUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();

            while (n > 0)
            {
                string input = Console.ReadLine();
                names.Add(input);
                n--;
            }

            Console.WriteLine(string.Join("\n", names));
        }
    }
}
