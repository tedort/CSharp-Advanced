using System.Text;

namespace ImplementingStackAndQueue
{
    public class CustomList<T> where T : IComparable
    {
        private const int InitialArraySize = 2;
        private T[] items;
        public int Count { get; private set; } = 0;

        public T this[int index]
        {
            get
            {
                if (index >= Count || index < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return items[index];
            }
            set
            {
                if (index >= Count || index < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                items[index] = value;
            }
        }

        public CustomList()
        {
            items = new T[InitialArraySize];
        }
        public void Add(T element)
        {
            if (Count >= items.Length)
            {
                IncreaseCapacity();
            }
            items[Count] = element;
            Count++;

        }

        public void Insert(int index, T element)
        {
            if (index > Count)
            {
                throw new IndexOutOfRangeException();
            }

            if (Count == items.Length)
            {
                IncreaseCapacity();
            }
            ShiftRight(index);
            items[index] = element;
            Count++;
        }

        public T RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentNullException("Index out of range!");
            }

            T result = items[index];
            ShiftLeft(index);
            Count--;

            if (Count <= items.Length / 4)
            {
                Shrink();
            }

            return result;
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < Count; i++)
            {
                if (items[i].CompareTo(element) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            if (IsIndexValid(firstIndex, secondIndex))
            {
                throw new ArgumentOutOfRangeException();
            }

            T temp = items[firstIndex];
            items[firstIndex] = items[secondIndex];
            items[secondIndex] = temp;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Count; i++)
            {
                sb.Append($"{items[i]} ");
            }
            return sb.ToString().TrimEnd();
        }

        private bool IsIndexValid(int firstIndex, int secondIndex)
        {
            return firstIndex < 0
                            || secondIndex < 0
                            || firstIndex >= Count
                            || secondIndex >= Count;
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

        private void ShiftLeft(int index)
        {
            for (int i = index; i < Count - 1; i++)
            {
                items[i] = items[i + 1];
            }
        }

        private void ShiftRight(int index)
        {
            for (int i = index; i < Count - 1; i++)
            {
                items[i] = items[i - 1];
            }
        }

        private void Shrink()
        {
            T[] copy = new T[items.Length / 2];
            for (int i = 0; i < Count; i++)
            {
                copy[i] = items[i];
            }
            items = copy;
        }
    }
}
