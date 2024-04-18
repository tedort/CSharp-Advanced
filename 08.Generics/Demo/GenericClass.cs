namespace Demo
{
    public class GenericClass<T>
    {
        public T x;

        public List<T> list = new List<T>();

        public T Name { get; set; }

        public void Add(T element)
        {
            list.Add(element);
            Console.WriteLine(element);
        }
    }
}
