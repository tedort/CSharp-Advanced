namespace _08.SoftUniParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> guests = new HashSet<string>();
            string input = Console.ReadLine();

            while (input != "END")
            {
                if (input != "PARTY")
                {
                    guests.Add(input);
                    input = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }

            if (input == "PARTY")
            {
                input = Console.ReadLine();
                while (input != "END")
                {
                    guests.Remove(input);
                    input = Console.ReadLine();
                }
            }

            Console.WriteLine(guests.Count);
            Console.WriteLine(string.Join("\n", guests));
        }
    }
}
