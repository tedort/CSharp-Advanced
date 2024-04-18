namespace Constraints
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static void UseStream<T>(T parameter) where T : IEnumerable<T>
        {
            Console.WriteLine(parameter);
        }
    }
}
