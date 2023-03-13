using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Tire
    {
        private int year;
        private double pressure;

        //public Tire(int year, double pressure)
        //{
        //    this.year = year;
        //    this.pressure = pressure;
        //}

        public int Year { get { return year; } set { year = value; } }
        public double Pressure
        {
            get { return pressure; }
            set { pressure = value; }
        }

        public List<int> GetYearInfo(string[] command)
        {
            List<int> listedYears = new();

            for (int i = 0; i < command.Length; i += 2)
            {
                listedYears.Add(int.Parse(command[i]));
            }

            return listedYears;
        }

        public List<double> GetPressureInfo(string[] command)
        {
            List<double> listedPressure = new();

            for (int i = 1; i < command.Length; i += 2)
            {
                listedPressure.Add(double.Parse(command[i]));
            }

            return listedPressure;
        }

        public double GetTiresPressure(List<List<double>> tiresPressure, int tiresIndex)
        {
            double pressureSum = tiresPressure[tiresIndex].Sum();

            return pressureSum;
        }
    }
}
