namespace _05.FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int rack = int.Parse(Console.ReadLine());
            int rackUsed = 0;
            int currentRackCapacity = rack;

            if (clothes.Any())
            {
                rackUsed++;
            }

            while (clothes.Any())
            {
                if (clothes.Peek() <= currentRackCapacity)
                {
                    currentRackCapacity -= clothes.Pop();
                }
                else
                {
                    rackUsed++;
                    currentRackCapacity = rack;
                }
            }
            Console.WriteLine(rackUsed);
        }
    }
}
