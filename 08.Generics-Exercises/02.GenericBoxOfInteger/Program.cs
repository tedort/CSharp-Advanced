using _01.GenericBoxOfString;

namespace _02.GenericBoxOfInteger
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<int> box = new Box<int>();

            while (n > 0)
            {
                box.Add(int.Parse(Console.ReadLine()));
                n--;
            }

            Console.WriteLine(box);
        }
    }
}
