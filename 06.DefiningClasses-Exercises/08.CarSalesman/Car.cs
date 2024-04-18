using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CarSalesman
{
    public class Car
    {
        private string model;
        private Engine engine;
        private int weight;
        private string color;

        public Car()
        {

        }

        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }

        public Car(string model, Engine engine, int weight, string color) : this(model, engine)
        {
            Weight = weight;
            Color = color;
        }

        public string Model
        {
            get => model;
            set => model = value;
        }

        public Engine Engine
        {
            get => engine;
            set => engine = value;
        }

        public int Weight
        {
            get => weight;
            set => weight = value;
        }

        public string Color
        {
            get => color;
            set => color = value;
        }
    }
}
