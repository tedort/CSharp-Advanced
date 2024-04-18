namespace _05.CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] symbols = input.ToCharArray();
            Dictionary<char, int> counter = new Dictionary<char, int>();

            for (int i = 0; i < symbols.Length; i++)
            {
                if (!counter.ContainsKey(symbols[i]))
                {
                    counter.Add(symbols[i], 0);
                }
                counter[symbols[i]]++;
            }

            counter = counter
                    .OrderBy(symbol => symbol.Key)
                    .ToDictionary(symbol => symbol.Key, symbol => symbol.Value);

            foreach (var symbol in counter)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
