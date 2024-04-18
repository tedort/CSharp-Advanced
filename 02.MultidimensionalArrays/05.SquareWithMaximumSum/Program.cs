namespace _05.SquareWithMaximumSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizeOfArray = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = sizeOfArray[0];
            int cols = sizeOfArray[1];
            int[,] matrix = GenerateArray(rows, cols, ", ");
            int maxSum = int.MinValue;
            int topLeftRow = 0;
            int topLeftCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        topLeftRow = row;
                        topLeftCol = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[topLeftRow, topLeftCol]} {matrix[topLeftRow, topLeftCol + 1]}");
            Console.WriteLine($"{matrix[topLeftRow + 1, topLeftCol]} {matrix[topLeftRow + 1, topLeftCol + 1]}");
            Console.WriteLine(maxSum);
        }

        static int[,] GenerateArray(int rows, int cols, string separator)
        {
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowArray = Console.ReadLine().Split(separator).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowArray[col];
                }
            }
            return matrix;
        }
    }
}
