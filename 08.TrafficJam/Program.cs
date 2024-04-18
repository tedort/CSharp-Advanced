namespace _08.TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> cars = new Queue<string>();

            int n = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            int passedCars = 0;

            while (command != "end")
            {
                if (command != "green")
                {
                    cars.Enqueue(command);
                }
                else
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (cars.Count > 0)
                        {
                            string car = cars.Dequeue();
                            Console.WriteLine($"{car} passed!");
                            passedCars++;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{passedCars} cars passed the crossroads.");
        }
    }
}
