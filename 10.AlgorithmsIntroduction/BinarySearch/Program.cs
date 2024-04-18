using System;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .OrderBy(num => num)
                .ToArray();
            int element = int.Parse(Console.ReadLine());

            int index = BinarySearch(arr, element);

            Console.WriteLine(index > -1 ? "Found at index " + index : "Not found");
        }

        public static int BinarySearch(int[] arr, int x)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;
                if (arr[middle] == x)
                {
                    return middle;
                }
                if (arr[middle] < x)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

            return -1;
        }
    }
}
