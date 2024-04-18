namespace _06.RecordUniqueNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();

            while (n > 0)
            {
                string name = Console.ReadLine();
                names.Add(name);
                n--;
            }

            Console.WriteLine(string.Join("\n", names));
        }
    }
}
