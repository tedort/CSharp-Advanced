namespace _02.SetsOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] lengths = Console.ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
            HashSet<int> firstSet = new HashSet<int>();
            int firstLength = lengths[0];
            HashSet<int> secondSet = new HashSet<int>();
            int secondLength = lengths[1];

            fillSet(firstSet, firstLength);
            fillSet(secondSet, secondLength);

            firstSet.IntersectWith(secondSet);

            Console.WriteLine(string.Join(" ", firstSet));
        }

        private static void fillSet(HashSet<int> numbers, int length)
        {
            while (length > 0)
            {
                int number = int.Parse(Console.ReadLine());
                numbers.Add(number);
                length--;
            }
        }
    }
}
