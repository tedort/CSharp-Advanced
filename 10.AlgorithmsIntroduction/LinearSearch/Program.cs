namespace LinearSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int element = int.Parse(Console.ReadLine());
            int index = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == element)
                {
                    index = i;
                    break;
                }
            }

            Console.WriteLine(index > -1 ? "Found at index " + index : "Not found");
        }
    }
}
