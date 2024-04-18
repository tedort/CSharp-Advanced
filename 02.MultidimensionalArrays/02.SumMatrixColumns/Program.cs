namespace _02.SumMatrixColumns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizeOfArray = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = sizeOfArray[0];
            int cols = sizeOfArray[1];
            int[,] matrix = GenerateArray(rows, cols, " ");
            int sumCols = 0;

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                sumCols = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sumCols += matrix[row, col];
                }
                Console.WriteLine(sumCols);
            }
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
