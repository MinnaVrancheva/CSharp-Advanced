using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Car
    {
        private string model;
        
        public Car(string model, int speed, int power, int weight, string type, double tire1Pressure, int tire1Age, double tire2Pressure, int tire2Age, double tire3Pressure, int tire3Age, double tire4Pressure, int tire4Age)
        {
            Model = model;
            Engine = new(speed, power);
            Cargo = new(weight, type);
            Tires = new Tire[4];
            Tires[0] = new(tire1Age, tire1Pressure);
            Tires[1] = new(tire2Age, tire2Pressure);
            Tires[2] = new(tire3Age, tire3Pressure);
            Tires[3] = new(tire4Age, tire4Pressure);
        }

        public string Model { get { return model; } set { model = value; } }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tire[] Tires { get; set; }

    }
}
