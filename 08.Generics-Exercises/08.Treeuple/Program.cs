namespace _07.Tuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] personTokens = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string town = personTokens[3];
            if (personTokens.Length > 4)
            {
                town += $" {personTokens[4]}";
            }

            CustomTuple<string, string, string> person = new CustomTuple<string, string, string>($"{personTokens[0]} {personTokens[1]}", personTokens[2], town);

            string[] beerTokens = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            CustomTuple<string, string, bool> beer = new CustomTuple<string, string, bool>(beerTokens[0], beerTokens[1], beerTokens[2] == "drunk");

            string[] bankTokens = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            CustomTuple<string, double, string> bank = new CustomTuple<string, double, string>(bankTokens[0], double.Parse(bankTokens[1]), bankTokens[2]);

            Console.WriteLine(person);
            Console.WriteLine(beer);
            Console.WriteLine(bank);
        }
    }
}
