namespace _07.RawData
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
                Engine engine = new Engine(int.Parse(input[1]), int.Parse(input[2]));
                Cargo cargo = new Cargo(int.Parse(input[3]), input[4]);
                Tire[] tires = new Tire[4];
                for (int i = 5, j = 0; i < input.Length; i++, j++)
                {
                    Tire tire = new Tire(float.Parse(input[i]), int.Parse(input[++i]));
                    tires[j] = tire;
                }
                Car car = new Car(input[0], engine, cargo, tires);
                cars.Add(car);

                n--;
            }

            string cargoType = Console.ReadLine();

            foreach (Car car in cars)
            {
                car.FilterCar(cargoType);
            }
        }
    }
}
