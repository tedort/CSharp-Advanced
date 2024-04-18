using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.RawData
{
    public class Tire
    {
        private int age;
        private float pressure;

        public Tire()
        {

        }

        public Tire(float pressure, int age)
        {
            Age = age;
            Pressure = pressure;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public float Pressure
        {
            get => pressure;
            set => pressure = value;
        }
    }
}
