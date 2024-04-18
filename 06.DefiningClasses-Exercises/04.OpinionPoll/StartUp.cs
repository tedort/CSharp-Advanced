namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            while (n > 0)
            {
                string[] input = Console.ReadLine().Split(' ', 
                    StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(input[0], int.Parse(input[1]));
                people.Add(person);
                n--;
            }

            people = people
                .OrderBy(person => person.Name)
                .Where(person => person.Age > 30)
                .ToList();

            foreach (Person person in people)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
