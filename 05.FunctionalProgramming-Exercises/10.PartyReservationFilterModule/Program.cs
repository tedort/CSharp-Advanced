namespace _10.PartyReservationFilterModule
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                 .ToList();
            List<string> filteredNames = new List<string>();

            foreach (string name in names)
            {
                filteredNames.Add(name);
            }

            string[] command = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            while (true)
            {
                if (command[0] == "Print")
                {
                    break;
                }
                Func<string, bool> predicate = GetPredicate(command[1], command[2]);

                switch (command[0])
                {
                    case "Add filter":
                        filteredNames = AddFilter(filteredNames, predicate);
                        break;
                    case "Remove filter":
                        filteredNames = RemoveFilter(names, filteredNames, predicate);
                        break;
                }

                command = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine(string.Join(" ", filteredNames));
        }

        private static Func<string,bool> GetPredicate(string command, string substring)
        {
            if (command == "Starts with")
            {
                return s => s.StartsWith(substring);
            }
            else if (command == "Ends with")
            {
                return s => s.EndsWith(substring);
            }
            else if (command == "Length")
            {
                return s => s.Length == int.Parse(substring);
            }
            else if (command == "Contains")
            {
                return s => s.Contains(substring);
            }
            return default;
        }

        private static List<string> AddFilter(List<string> filteredNames, Func<string, bool> predicate)
        {
            filteredNames = filteredNames.Where(name => !predicate(name)).ToList();
            return filteredNames;
        }

        private static List<string> RemoveFilter(List<string> names, List<string> filteredNames, Func<string, bool> predicate)
        {
            names = names.Where(name => predicate(name)).ToList();
            foreach (string name in names)
            {
                filteredNames.Add(name);
            }
            return filteredNames;
        }
    }
}
