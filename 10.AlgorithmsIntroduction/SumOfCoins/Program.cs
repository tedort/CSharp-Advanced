namespace SumOfCoins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] coins = Console.ReadLine().Split(", ").Select(int.Parse).OrderByDescending(c => c).ToArray();

            int targetSum = int.Parse(Console.ReadLine());

            int currentSum = 0;

            Dictionary<int, int> usedCoins = new Dictionary<int, int>();
            int numberOfCoins = 0;
            while (true)
            {
                bool isCoinTaken = false;
                int usedCoinsCount = usedCoins.Count;
                for (int i = 0; i < coins.Length; i++)
                {
                    if (currentSum + coins[i] <= targetSum)
                    {
                        if (!usedCoins.ContainsKey(coins[i]))
                        {
                            usedCoins.Add(coins[i], 0);
                        }
                        usedCoins[coins[i]]++;
                        currentSum += coins[i];
                        isCoinTaken = true;
                        numberOfCoins++;
                        break;
                    }
                }

                if (!isCoinTaken)
                {
                    break;
                }
            }

            Console.WriteLine($"Number of coins to take: {numberOfCoins}");

            foreach (var coin in usedCoins)
            {
                Console.WriteLine($"{coin.Value} coin(s) with value {coin.Key}");
            }
        }
    }
}
