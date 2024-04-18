namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int startPosition = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int minIndex = FindMinElementIndex(startPosition, array);
                if (array[minIndex] != array[startPosition])
                {
                    int temp = array[minIndex];
                    array[minIndex] = array[startPosition];
                    array[startPosition] = temp;
                }
                startPosition++;
            }

            Console.WriteLine(string.Join(' ', array));
        }

        public static int FindMinElementIndex(int startPosition, int[] array)
        {
            int min = int.MaxValue;
            int index = 0;
            for (int i = startPosition; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    index = i;
                }
            }
            return index;
        }
    }
}
