namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> linkedList = new LinkedList<string>();

            Queue<string> queue = new Queue<string>();

            queue.Enqueue("Tedo");
            linkedList.AddFirst("Tedo");

            queue.Enqueue("Tedo1");
            linkedList.AddFirst("Tedo1");

            queue.Enqueue("Tedo2");
            linkedList.AddFirst("Tedo2");

            queue.Enqueue("Tedo3");
            linkedList.AddFirst("Tedo3");

            while (queue.Count != 0)
            {
                string element = queue.Dequeue();
                Console.WriteLine($"Queue: {element}");
            }

            LinkedListNode<string> linkedListNode = linkedList.First;
            while (linkedListNode != null)
            {
                Console.WriteLine(linkedListNode.Value);

                linkedList.RemoveFirst();
                linkedListNode = linkedList.First;
            }
        }
    }
}
