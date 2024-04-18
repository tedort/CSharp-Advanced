using System.Collections;

namespace YieldReturn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerator<int> enumerator = GenerateNumbers();
            Console.WriteLine($"Current: {enumerator.Current}");

            enumerator.MoveNext();
            Console.WriteLine($"Current: {enumerator.Current}");

            enumerator.MoveNext();
            Console.WriteLine($"Current: {enumerator.Current}");

            enumerator.MoveNext();
            Console.WriteLine($"Current: {enumerator.Current}");

            enumerator.MoveNext();
            Console.WriteLine($"Current: {enumerator.Current}");
        }

        /*public static void ForEach<T>(IEnumerator<T> enumerator)
        {
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }*/

        public static IEnumerator<int> GenerateNumbers()
        {
            Console.WriteLine("Before yield 0");
            yield return 5;
            Console.WriteLine("After yield 5");

            Console.WriteLine("Before yield 5");
            yield return 6;
            Console.WriteLine("After yield 6");

            Console.WriteLine("Before yield 6");
            yield return 7;
            Console.WriteLine("After yield 7");
        }
    }
 }
