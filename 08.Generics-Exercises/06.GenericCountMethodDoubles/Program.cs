using _01.GenericBoxOfString;

namespace _05.GenericCountMethodStrings
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();
            while (n > 0)
            {
                box.Add(double.Parse(Console.ReadLine()));
                n--;
            }
            double element = double.Parse(Console.ReadLine());
            int counter = box.Compare(element);
            Console.WriteLine(counter);
        }
    }
}
