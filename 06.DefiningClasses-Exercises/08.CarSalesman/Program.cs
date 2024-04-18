namespace _08.CarSalesman
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();

            while (n > 0)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Engine engine = new Engine(input[0], int.Parse(input[1]));
                if (input.Length == 3)
                {
                    int number;
                    if (int.TryParse(input[2], out number))
                    {
                        engine.Displacement = int.Parse(input[2]);
                    }
                    else
                    {
                        engine.Efficiency = input[2];
                    }
                }
                if (input.Length == 4)
                {
                    engine.Displacement = int.Parse(input[2]);
                    engine.Efficiency = input[3];
                }
                engines.Add(engine);
                n--;
            }

            int m = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            while (m > 0)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Engine currentEngine = new Engine();
                foreach (Engine engine in engines)
                {
                    if (input[1] == engine.Model)
                    {
                        currentEngine = engine;
                        break;
                    }
                }
                Car car = new Car(input[0], currentEngine);

                if (input.Length == 3)
                {
                    int number;
                    if (int.TryParse(input[2], out number))
                    {
                        car.Weight = int.Parse(input[2]);
                    }
                    else
                    {
                        car.Color = input[2];
                    }
                }
                if (input.Length == 4)
                {
                    car.Weight = int.Parse(input[2]);
                    car.Color = input[3];
                }
                cars.Add(car);
                m--;
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                Console.WriteLine($"    Displacement: {(car.Engine.Displacement == 0 ? "n/a" : car.Engine.Displacement)}");
                Console.WriteLine($"    Efficiency: {(car.Engine.Efficiency == null ? "n/a" : car.Engine.Efficiency)}");
                Console.WriteLine($"  Weight: {(car.Weight == 0 ? "n/a" : car.Weight)}");
                Console.WriteLine($"  Color: {(car.Color == null ? "n/a" : car.Color)}");
            }
        }
    }
}
