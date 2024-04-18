namespace _04.AddVAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> prices = Console.ReadLine()
                                  .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                  .Select(double.Parse)
                                  .Select(num => num * 1.2)
                                  .ToList();
            foreach (double price in prices)
            {
                Console.WriteLine($"{price:f2}");
            }
        }
    }
}
