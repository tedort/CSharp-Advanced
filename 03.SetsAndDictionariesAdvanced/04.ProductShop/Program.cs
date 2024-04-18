using System.Diagnostics;

namespace _04.ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            Dictionary<string, Dictionary<string, double>> store = new Dictionary<string, Dictionary<string, double>>();

            while (input[0] != "Revision")
            {
                if (!store.ContainsKey(input[0]))
                {
                    store[input[0]] = new Dictionary<string, double>();
                }
                store[input[0]][input[1]] = double.Parse(input[2]);
                input = Console.ReadLine().Split(", ");
            }

            store = store.OrderBy(name => name.Key).ToDictionary(name => name.Key, name => name.Value);

            foreach (var (shop, products) in store)
            {
                Console.WriteLine($"{shop}->");
                foreach (var (product, price) in products)
                {
                    Console.WriteLine($"Product: {product}, Price: {price}");
                }
            }
        }
    }
}
