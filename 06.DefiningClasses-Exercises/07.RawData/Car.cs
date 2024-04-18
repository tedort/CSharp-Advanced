using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.RawData
{
    public class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private Tire[] tires;

        public Car()
        {

        }

        public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
            Tires = tires;
        }

        public string Model
        {
            get => model; set => model = value;
        }

        public Engine Engine
        {
            get => engine; set => engine = value;
        }

        public Cargo Cargo
        {
            get => cargo; set => cargo = value;
        }

        public Tire[] Tires
        {
            get => tires; set => tires = value;
        }

        public void FilterCar(string cargoType)
        {
            if (cargoType == "fragile")
            {
                foreach (Tire tire in tires)
                {
                    if (Cargo.Type == cargoType && tire.Pressure < 1)
                    {
                        Console.WriteLine(Model);
                        break;
                    }
                }
            }
            else if (cargoType == "flammable" && Cargo.Type == cargoType && Engine.Power > 250)
            {
                Console.WriteLine(Model);
            }
        }
    }
}
