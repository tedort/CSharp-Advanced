﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.RawData
{
    public class Cargo
    {
        private string type;
        private int weight;

        public Cargo()
        {

        }

        public Cargo(int weight, string type)
        {
            Type = type;
            Weight = weight;
        }

        public string Type
        {
            get => type;
            set => type = value;
        }

        public int Weight
        {
            get => weight; 
            set => weight = value;
        }
    }
}
