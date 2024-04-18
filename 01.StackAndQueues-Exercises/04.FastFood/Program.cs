namespace _04.FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            Queue<int> orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            if (orders.Any())
            {
                Console.WriteLine(orders.Max());
            }

            while (orders.Any())
            {
                if (quantity >= orders.Peek())
                {
                    quantity -= orders.Dequeue();
                }
                else
                {
                    Console.WriteLine("Orders left: " + string.Join(" ", orders));
                    return;
                }
            }
            Console.WriteLine("Orders complete");
        }
    }
}
