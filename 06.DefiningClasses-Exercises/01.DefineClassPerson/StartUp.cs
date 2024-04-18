namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person Peter = new Person
            {
                Name = "Peter",
                Age = 20
            };

            Person Jose = new Person("Jose", 43);
        }
    }
}
