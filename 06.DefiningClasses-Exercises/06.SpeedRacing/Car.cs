using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance;

        public Car()
        {

        }

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            TravelledDistance = 0;
        }

        public string Model { get => model; set => model = value; }
        public double FuelAmount { get => fuelAmount; set => fuelAmount = value; }
        public double FuelConsumptionPerKilometer { get => fuelConsumptionPerKilometer; set => fuelConsumptionPerKilometer = value; }
        public double TravelledDistance { get => travelledDistance; set => travelledDistance = value; }

        public void Drive(double distance)
        {
            bool canContinue = FuelAmount >= FuelConsumptionPerKilometer * distance;
            if (canContinue)
            {
                FuelAmount = FuelAmount - (FuelConsumptionPerKilometer * distance);
                TravelledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
