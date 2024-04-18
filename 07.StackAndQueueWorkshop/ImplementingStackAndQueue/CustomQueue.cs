using System.Security.AccessControl;

namespace ImplementingStackAndQueue
{
    public class CustomQueue
    {
        private const int InitialCapacity = 4;
        private const int FirstElementIndex = 0;
        private int[] items;

        public int Count { get; private set; } = 0;

        public CustomQueue()
        {
            items = new int[InitialCapacity];
        }

        public void Enqueue(int item)
        {
            CheckIfCountIsZero();
            
            if (Count == items.Length)
            {
                IncreaseCapacity();
            }
            
            items[Count] = item;
            Count++;
        }

        public int Dequeue()
        {
            CheckIfCountIsZero();

            int firstElement = items[FirstElementIndex];
            ShiftAllLeft();
            Count--;
            return firstElement;
        }

        public int Peek()
        {
            CheckIfCountIsZero();

            return items[FirstElementIndex];
        }

        public void ForEach(Action<object> action)
        {
            for (int i = 0; i < Count; i++)
            {
                action(items[i]);
            }
        }

        public void Clear()
        {
            int[] empty = new int[InitialCapacity];
            items = empty;
            Count = 0;
        }

        private void ShiftAllLeft()
        {
            for (int i = 0; i < Count - 1; i++)
            {
                items[i] = items[i + 1];
            }
        }

        private void IncreaseCapacity()
        {
            int[] copy = new int[items.Length * 2];
            for (int i = 0; i < Count; i++)
            {
                copy[i] = items[i];
            }
            items = copy;
        }

        private void CheckIfCountIsZero()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
        }
    }
}
