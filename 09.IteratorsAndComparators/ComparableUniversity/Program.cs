namespace ComparableUniversity
{
    public class Program
    {
        static void Main(string[] args)
        {
            University softUni = new University()
            {
                AverageScore = 6,
                Students = new List<string>() { "1", "2", "3" },
                Name = "SoftUni"
            };

            University MIT = new University()
            {
                AverageScore = 4.5,
                Students = new List<string> { "1" },
                Name = "MIT"
            };

            List<University> universities = new List<University>();
            universities.Add(softUni);
            universities.Add(MIT);

            SortedSet<University> sortedUniversities = new SortedSet<University>(universities, new UniversityNameComparer());

            foreach (var item in sortedUniversities)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
