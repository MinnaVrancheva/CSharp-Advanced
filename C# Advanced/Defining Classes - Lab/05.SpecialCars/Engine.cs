using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Engine
    {
        private int horsePower;
        private double cubicCapacity;

        //public Engine(int horsePower, double cubicCapacity)
        //{
        //    this.horsePower = horsePower;
        //    this.cubicCapacity = cubicCapacity;
        //}

        public int HorsePower { get { return horsePower; } set { horsePower = value; } }
        public double CubicCapacity { get { return cubicCapacity; } set { cubicCapacity = value; } }

        public int GetHorsePower(string[] command)
        {
            int horsePower = int.Parse(command[0]);

            return horsePower;
        }

        public double GetCubicCapacity(string[] command)
        {
            double cubicCapacity = double.Parse(command[1]);

            return cubicCapacity;
        }
    }
}
