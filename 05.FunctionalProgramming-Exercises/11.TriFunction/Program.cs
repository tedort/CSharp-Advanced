using System.Globalization;

namespace _11.TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine()
                                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                 .ToList();
            
            string result = FindName(names, (name, sum) => sum >= n);

            Console.WriteLine(result);
        }

        private static string FindName(List<string> names, Func<string, int, bool> condition)
        {
            foreach (string name in names)
            {
                int sum = SumCharacter(name);
                if (condition(name, sum))
                {
                    return name;
                }
            }
            return default;
        }

        private static int SumCharacter(string word)
        {
            int sum = 0;
            for (int i = 0; i < word.Length; i++)
            {
                sum += word[i];
            }
            return sum;
        }
    }
}
