using _01.GenericBoxOfString;

namespace _03.GenericSwapMethodsStrings
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Box<string> box = new Box<string>();

            while (n > 0)
            {
                box.Add(Console.ReadLine());
                n--;
            }

            int[] indexes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            box.Swap(indexes[0], indexes[1]);

            Console.WriteLine(box);
        }
    }
}
