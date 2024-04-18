using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CarSalesman
{
    public class Engine
    {
        private string model;
        private int power;
        private int displacement;
        private string efficiency;

        public Engine()
        {

        }

        public Engine(string model, int power)
        {
            Model = model;
            Power = power;
        }

        public Engine(string model, int power, int displacement, string efficiency) : this(model, power)
        {
            Displacement = displacement;
            Efficiency = efficiency;
        }

        public string Model
        {
            get => model;
            set => model = value;
        }

        public int Power
        {
            get => power;
            set => power = value;
        }

        public int Displacement
        {
            get => displacement;
            set => displacement = value;
        }

        public string Efficiency
        {
            get => efficiency;
            set => efficiency = value;
        }
    }
}
