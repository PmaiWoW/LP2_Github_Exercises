using System;
using System.Collections.Generic;
using System.Text;

namespace _02_ex27
{
    public struct Passenger
    {
        private double weight;
        public double Weight
        {
            get => weight;
            set => value = value < 5 ? 5 : value;
        }
    }
}
