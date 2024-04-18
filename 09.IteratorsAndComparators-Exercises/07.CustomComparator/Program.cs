namespace _07.CustomComparator
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Array.Sort(numbers, CompareEvenOdd);

            Console.WriteLine(string.Join(' ', numbers));
        }

        public static int CompareEvenOdd(int a, int b)
        {
            if (a % 2 == 0 && b % 2 != 0)
            {
                return -1;
            }
            else if (a % 2 != 0 && b % 2 == 0)
            {
                return 1;
            }
            else
            {
                return a.CompareTo(b);
            }
        }
    }
}
