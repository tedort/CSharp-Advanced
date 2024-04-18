namespace _01.ChickenSnack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> money = new Stack<int>(Console.ReadLine()
                                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse));
            Queue<int> prices = new Queue<int>(Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            int counter = 0;

            while (prices.Any() && money.Any())
            {
                if (money.Peek() == prices.Peek() || money.Peek() < prices.Peek())
                {
                    if (money.Peek() == prices.Peek())
                    {
                        counter++;
                    }
                    money.Pop();
                    prices.Dequeue();
                }
                else if (money.Peek() > prices.Peek())
                {
                    if (money.Count > 1)
                    {
                        int difference = money.Pop() - prices.Dequeue();
                        money.Push(money.Pop() + difference);
                    }
                    else
                    {
                        money.Pop();
                        prices.Dequeue();
                    }
                    counter++;
                }
            }

            if (counter >= 4)
            {
                Console.WriteLine($"Gluttony of the day! Henry ate {counter} foods.");
            }
            else if (counter > 0)
            {
                Console.WriteLine($"Henry ate: {counter} {(counter == 1 ? "food" : "foods")}.");
            }
            else
            {
                Console.WriteLine("Henry remained hungry. He will try next weekend again.");
            }
        }
    }
}
