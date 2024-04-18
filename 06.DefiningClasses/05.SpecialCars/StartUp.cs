namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> tires = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            List<Car> specialCars = new List<Car>();

            string input = Console.ReadLine();
            while (input != "No more tires")
            {
                string[] nums = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Tire[] currentTires = new Tire[nums.Length / 2];
                int tireIndex = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    int year = 0;
                    double pressure = 0.0;
                    if (i % 2 == 0)
                    {
                        year = int.Parse(nums[i]);
                    }
                    else
                    {
                        pressure = double.Parse(nums[i]);
                        Tire tire = new Tire(year, pressure);
                        currentTires[tireIndex] = tire;
                        tireIndex++;
                    }
                }
                tires.Add(currentTires);
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "Engines done")
            {
                string[] nums = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int horsePower = int.Parse(nums[0]);
                double cubicCapacity = double.Parse(nums[1]);
                Engine engine = new Engine(horsePower, cubicCapacity);
                engines.Add(engine);
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "Show special")
            {
                string[] fields = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string make = fields[0];
                string model = fields[1];
                int year = int.Parse(fields[2]);
                double fuelQuantity = double.Parse(fields[3]);
                double fuelConsumption = double.Parse(fields[4]);
                int indexEngine = int.Parse(fields[5]);
                int indexTire = int.Parse(fields[6]);

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engines[indexEngine], tires[indexTire]);
                cars.Add(car);
                input = Console.ReadLine();
            }

            foreach (Car car in cars)
            {
                if (car.Year >= 2017 && car.Engine.HorsePower > 330)
                {
                    double tireSum = 0.0;
                    foreach (Tire tire in car.Tires)
                    {
                        tireSum += tire.Pressure;
                    }
                    if (tireSum >= 9 && tireSum <= 10)
                    {
                        car.Drive(20);
                        specialCars.Add(car);
                    }
                }
            }

            foreach (Car specialCar in specialCars)
            {
                Console.WriteLine($"Make: {specialCar.Make}");
                Console.WriteLine($"Model: {specialCar.Model}");
                Console.WriteLine($"Year: {specialCar.Year}");
                Console.WriteLine($"HorsePowers: {specialCar.Engine.HorsePower}");
                Console.WriteLine($"FuelQuantity: {specialCar.FuelQuantity}");
            }
        }
    }
}
