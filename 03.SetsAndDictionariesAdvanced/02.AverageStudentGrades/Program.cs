namespace _02.AverageStudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (students.ContainsKey(input[0]))
                {
                    students[input[0]].Add(decimal.Parse(input[1]));
                }
                else
                {
                    List<decimal> grades = new List<decimal>() { decimal.Parse(input[1]) };
                    students.Add(input[0], grades);
                }
            }
            foreach (KeyValuePair<string, List<decimal>> student in students)
            {
                Console.Write($"{student.Key} -> ");
                foreach (decimal grade in student.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {student.Value.Average():f2})");
            }
        }
    }
}
