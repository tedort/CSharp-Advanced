namespace _05.CitiesByContinentAndCountry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();

            while (n > 0)
            {
                string[] input = Console.ReadLine().Split();
                if (!continents.ContainsKey(input[0]))
                {
                    continents.Add(input[0], new Dictionary<string, List<string>>());
                }
                if (!continents[input[0]].ContainsKey(input[1]))
                {
                    continents[input[0]].Add(input[1], new List<string>());
                }
                continents[input[0]][input[1]].Add(input[2]);
                n--;
            }

            foreach (var (continent, countries) in continents)
            {
                Console.WriteLine($"{continent}:");
                foreach (var (country, city) in countries)
                {
                    Console.WriteLine($"{country} -> {string.Join(", ", city)}");
                }
            }
        }
    }
}
