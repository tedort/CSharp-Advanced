using System.Collections;

namespace Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 5, 4, 1, 8, 32, 15 };

            ForEach(new ListEnumerator(list));
            ForEach(new ListEnumerator(list));
        }

        public static void ForEach(IEnumerator<int> enumerator)
        {
            enumerator.Reset();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }

    class ListEnumerable : IEnumerable<int>
    {
        private List<int> list;
        public ListEnumerable(List<int> list)
        {
            this.list = list;
        }
        public IEnumerator<int> GetEnumerator()
        {
            return new ListEnumerator(list);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class ListEnumerator : IEnumerator<int>
    {
        private List<int> list;
        private int index = -1;

        public ListEnumerator(List<int> list)
        {
            this.list = list;
        }

        public int Current => list[index];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            index++;
            if (index >= list.Count)
            {
                return false;
            }

            return true;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
