using System.Numerics;

namespace _06.JaggedArrayModification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rows][];

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                jaggedArray[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] inputParts = command.Split();
                int row = int.Parse(inputParts[1]);
                int col = int.Parse(inputParts[2]);
                int value = int.Parse(inputParts[3]);

                if (inputParts[0] == "Add")
                {
                    try
                    {
                        jaggedArray[row][col] += value;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }

                else if (inputParts[0] == "Subtract")
                {
                    try
                    {
                        jaggedArray[row][col] -= value;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                command = Console.ReadLine();
            }

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write(jaggedArray[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
