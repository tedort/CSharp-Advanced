namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            List<Person> people = new List<Person>();

            while (n > 0)
            {
                string[] input = Console.ReadLine().Split(' ', 
                    StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(input[0], int.Parse(input[1]));
                people.Add(person);
                n--;
            }

            family.People = people;
            Person oldestPerson = family.GetOldestMember();

            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}
