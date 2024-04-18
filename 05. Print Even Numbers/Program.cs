namespace _05._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            Queue<int> evenNumbers = new Queue<int>();
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Enqueue(number);
                }
            }
            while (evenNumbers.Count > 0)
            {
                if (evenNumbers.Count == 1)
                {
                    Console.Write(evenNumbers.Dequeue());
                    break;
                }
                Console.Write(evenNumbers.Dequeue() + ", ");
            }
        }
    }
}
