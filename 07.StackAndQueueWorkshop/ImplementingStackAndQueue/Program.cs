namespace ImplementingStackAndQueue
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> list = new CustomList<string>();
            list.Add("Tosho");
            list.Add("Pesho");
            list.Add("Gosho");

            Console.WriteLine(list[1]);
        }
    }
}
