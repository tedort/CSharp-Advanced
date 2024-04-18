namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int endPosition = array.Length - 1;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 1; j <= endPosition; j++)
                {
                    if (array[j - 1] > array[j])
                    {
                        int temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
                }
                endPosition--;
            }

            Console.WriteLine(string.Join(' ', array));
        }
    }
}
