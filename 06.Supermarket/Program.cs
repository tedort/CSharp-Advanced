namespace _06.Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<string> people = new Queue<string>();
            while (input != "End")
            {
                if (input != "Paid")
                {
                    people.Enqueue(input);
                }
                else if (input == "Paid")
                {
                    while (people.Count > 0)
                    {
                        Console.WriteLine(people.Dequeue());
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{people.Count} people remaining.");
        }
    }
}
