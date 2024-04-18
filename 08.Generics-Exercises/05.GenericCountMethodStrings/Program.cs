using _01.GenericBoxOfString;

namespace _05.GenericCountMethodStrings
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();
            while (n > 0)
            {
                box.Add(Console.ReadLine());
                n--;
            }
            string element = Console.ReadLine();
            int counter = box.Compare(element);
            Console.WriteLine(counter);
        }
    }
}
