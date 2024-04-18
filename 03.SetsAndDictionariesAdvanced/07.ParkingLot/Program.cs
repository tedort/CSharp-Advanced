namespace _07.ParkingLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<String> cars = new HashSet<string>();
            string[] input = Console.ReadLine().Split(", ");


            while (input[0] != "END")
            {
                if (input[0] == "IN")
                {
                    cars.Add(input[1]);
                }
                else
                {
                    cars.Remove(input[1]);
                }
                input = Console.ReadLine().Split(", ");
            }

            if (cars.Count > 0)
            {
                Console.WriteLine(string.Join('\n', cars));
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
