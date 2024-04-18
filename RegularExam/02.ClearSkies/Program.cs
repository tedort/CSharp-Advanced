using System.Globalization;

namespace _02.ClearSkies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            int counter = 0;
            while (counter < n)
            {
                string input = Console.ReadLine();
                for (int i = 0; i < input.Length; i++)
                {
                    matrix[counter, i] = input[i];
                }
                counter++;
            }

            int armor = 300;
            int enemyCounter = 0;
            int[] jetfighterIndex = new int[2];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 'E')
                    {
                        enemyCounter++;
                    }
                }
            }

            while (true)
            {
                jetfighterIndex = GetJetPosition(matrix);
                if (armor == 0 || enemyCounter == 0)
                {
                    break;
                }
                string direction = Console.ReadLine();
                int rowJet = jetfighterIndex[0];
                int colJet = jetfighterIndex[1];
                int newRow = 0;
                int newCol = 0;
                if (direction == "left")
                {
                    newRow = rowJet;
                    newCol += colJet - 1;
                }
                else if (direction == "right")
                {
                    newRow = rowJet;
                    newCol += colJet + 1;
                }
                else if (direction == "up")
                {
                    newRow += rowJet -1;
                    newCol = colJet;
                }
                else if (direction == "down")
                {
                    newRow += rowJet + 1;
                    newCol = colJet;
                }

                matrix[rowJet, colJet] = '-';
                if (matrix[newRow, newCol] == 'E')
                {
                    enemyCounter--;
                    armor -= 100;
                }
                else if (matrix[newRow, newCol] == 'R')
                {
                    armor = 300;
                }
                matrix[newRow, newCol] = 'J';
            }

            if (enemyCounter == 0)
            {
                Console.WriteLine("Mission accomplished, you neutralized the aerial threat!");
            }
            else if (armor == 0)
            {
                Console.WriteLine($"Mission failed, your jetfighter was shot down! Last coordinates [{jetfighterIndex[0]}, {jetfighterIndex[1]}]!");
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static int[] GetJetPosition(char[,] matrix)
        {
            int[] jetPosition = new int[2];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 'J')
                    {
                        jetPosition[0] = i;
                        jetPosition[1] = j;
                        break;
                    }
                }
            }
            return jetPosition;
        }
    }
}
