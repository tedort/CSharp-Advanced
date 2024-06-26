﻿namespace MergeSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 5, 1, 7, 3, 4, 2 };
            Console.WriteLine(string.Join(' ', MergeSort(list, 0, list.Count)));
        }

        public static List<int> MergeSort(List<int> list, int start, int end)
        {
            if (end - start == 1)
            {
                return new List<int>() { list[start] };
            }

            if (end - start <= 0)
            {
                return new List<int>();
            }
            
            int middle = (start + end) / 2;

            List<int> sortedLeftPart = MergeSort(list, start, middle);
            List<int> sortedRightPart = MergeSort(list, middle, end);

            return MergeTwoSortedLists(sortedLeftPart, sortedRightPart);
        }

        public static List<int> MergeTwoSortedLists(List<int> left, List<int> right)
        {
            List<int> mergedList = new List<int>();
            int leftIndex = 0;
            int rightIndex = 0;

            for (int i = 0; i < left.Count + right.Count; i++)
            {
                if (leftIndex >= left.Count)
                {
                    mergedList.Add(right[rightIndex++]);
                    continue;
                }
                else if (rightIndex >= right.Count)
                {
                    mergedList.Add(left[leftIndex++]);
                    continue;
                }
                if (left[leftIndex] <= right[rightIndex])
                {
                    mergedList.Add(left[leftIndex++]);
                }
                else
                {
                    mergedList.Add(right[rightIndex++]);
                }
            }

            return mergedList;
        }
    }
}
