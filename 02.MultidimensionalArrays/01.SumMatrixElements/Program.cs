namespace _01.SumMatrixElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizeOfArray = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = sizeOfArray[0];
            int cols = sizeOfArray[1];
            int sum = 0;
            int[,] matrix = GenerateArray(rows, cols, ", ");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sum += matrix[row, col];
                }
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
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
