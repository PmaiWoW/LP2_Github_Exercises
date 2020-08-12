using System;
using System.Collections.Generic;
using System.Text;

namespace _02_ex27
{
    public class Car : Vehicle
    {
        private Passenger[] passengers;

        public Car(double value, int numPassengers, float avgWeight) : base(value)
        {
            Random r = new Random();
            passengers = new Passenger[numPassengers];
            for (int i = 0; i < numPassengers; i++)
                passengers[i] = new Passenger() { Weight =
                    avgWeight + r.Next(-10, 10) };
        }
    }
}
