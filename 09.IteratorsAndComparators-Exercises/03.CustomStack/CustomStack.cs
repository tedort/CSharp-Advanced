using System.Collections;

namespace _03.CustomStack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private T[] items;
        private const int InitialCapacity = 4;
        public int Count { get; private set; }

        public CustomStack()
        {
            items = new T[InitialCapacity];
        }

        public void ForEach(Action<object> action)
        {
            for (int i = 0; i < Count; i++)
            {
                action(items[i]);
            }
        }

        public void Push(T element)
        {
            if (Count == items.Length)
            {
                IncreaseCapacity();
            }

            items[Count] = element;
            Count++;
        }

        public T Pop()
        {
            CheckIfCountIsZero();

            T result = items[Count - 1];
            Count--;
            return result;
        }

        public T Peek()
        {
            CheckIfCountIsZero();

            return items[Count - 1];
        }

        private void IncreaseCapacity()
        {
            T[] copy = new T[items.Length * 2];
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

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
