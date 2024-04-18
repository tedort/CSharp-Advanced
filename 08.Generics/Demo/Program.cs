namespace Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> name = GenerateElements(2, 10);
            Console.WriteLine(string.Join(", ", GenerateElements<string>("Teodor", 10)));
        }

        public static List<T> GenerateElements<T>(T element, int n)
        {
            List<T> list = new List<T>();
            for (int i = 0; i < n; i++)
            {
                list.Add(element);
            }

            return list;
        }
    }
}
