using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniHashSet
{
    internal class SoftUniHashSet
    {
        private List<string>[] internalArray;
        private double elementsCount = 0;
        private int maxCapacity = 60;

        public SoftUniHashSet()
        {
            internalArray = new List<string>[8];
        }

        public void Add(string element)
        {
            int index = HashFunction(element);

            if (internalArray[index] == null)
            {
                internalArray[index] = new List<string>();
            }
            internalArray[index].Add(element);
            elementsCount++;

            if (elementsCount / internalArray.Length * 100 > maxCapacity)
            {
                Resize();
            }
        }

        private void Resize()
        {
            elementsCount = 0;
            List<string>[] oldInternalArray = internalArray;

            internalArray = new List<string>[internalArray.Length * 2];

            for (int i = 0; i < oldInternalArray.Length; i++)
            {
                if (oldInternalArray[i] != null)
                {
                    for (int j = 0; j < oldInternalArray[i].Count; j++)
                    {
                        Add(oldInternalArray[i][j]);
                    }
                }
            }
        }

        public bool Containts(string element)
        {
            int index = HashFunction(element);

            if (internalArray[index] != null)
            {
                for (int i = 0; i < internalArray[index].Count; i++)
                {
                    if (internalArray[index][i] == element)
                    {
                        return true;
                    }
                }
            }

            return true;
        }

        public int HashFunction(string element)
        {
            int asciiSum = 0;

            for (int i = 0; i < element.Length; i++)
            {
                asciiSum += element[i];
            }

            return asciiSum % internalArray.Length;
        }
    }
}
