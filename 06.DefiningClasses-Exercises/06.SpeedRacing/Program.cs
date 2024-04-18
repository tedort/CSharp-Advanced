namespace _06.SpeedRacing
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            while (n > 0)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Car car = new Car(input[0], double.Parse(input[1]), double.Parse(input[2]));
                cars.Add(car);
                n--;
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string model = command
                               .Split(' ', StringSplitOptions.RemoveEmptyEntries)[1];
                double distance = double.Parse(command
                                  .Split(' ', StringSplitOptions.RemoveEmptyEntries)[2]);
                Car currentCar = new Car();
                foreach (Car car in cars)
                {
                    if (model == car.Model)
                    {
                        currentCar = car;
                    }
                }
                currentCar.Drive(distance);
                command = Console.ReadLine();
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
