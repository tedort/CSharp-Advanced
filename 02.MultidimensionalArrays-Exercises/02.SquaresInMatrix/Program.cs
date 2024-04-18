namespace _02.SquaresInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = size[0];
            int cols = size[1];

            char[,] jaggedArray = new char[rows, cols];

            int count = 0;

            for (int row = 0; row < jaggedArray.GetLength(0); row++)
            {
                List<char> input = Console.ReadLine().ToList();

                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] == ' ')
                    {
                        input.RemoveAt(i);
                    }
                }

                for (int col = 0; col < jaggedArray.GetLength(1); col++)
                {
                    jaggedArray[row, col] = input[col];
                }
            }

            for (int row = 1; row < jaggedArray.GetLength(0); row++)
            {
                for (int col = 1; col < jaggedArray.GetLength(1); col++)
                {
                    if (jaggedArray[row - 1, col - 1] == jaggedArray[row - 1, col] && jaggedArray[row - 1, col] == jaggedArray[row, col - 1] && jaggedArray[row, col - 1] == jaggedArray[row, col])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
