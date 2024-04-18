using System.Text;

namespace _01.GenericBoxOfString
{
    public class Box<T> where T : IComparable
    {
        private List<T> list;

        public List<T> List { get => list; }

        public Box()
        {
            list = new List<T>();
        }

        public void Add(T item)
        {
            list.Add(item);
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            T temp = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = temp;
        }

        public int Compare(T element)
        {
            int counter = 0;
            foreach (var item in list)
            {
                if (item.CompareTo(element) > 0)
                {
                    counter++;
                }
            }
            return counter;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (T item in list)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
