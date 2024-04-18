using System.Threading.Channels;

namespace Implementation
{
    public class Program
    {
        static void Main(string[] args)
        {
            SoftUniCustomLinkedList<string> linkedList = new SoftUniCustomLinkedList<string>();

            linkedList.AddLast("Pesho");
            linkedList.AddLast("Gosho");
            linkedList.AddLast("Tosho");
            linkedList.AddLast("Valyo");

            linkedList.RemoveFirst();

            Node<string> node = linkedList.Head;

            linkedList.ForEach(n =>
            {
                Console.WriteLine(n);
            });
            Console.WriteLine();
            string[] array = linkedList.ToArray();

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
